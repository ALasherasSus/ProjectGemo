using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemoTale
{
    public partial class Vista_Combate : Form
    {
        private int idNivel;
        public Vista_Combate(int idLvl)
        {
            InitializeComponent();
            this.CenterToScreen(); //Centrar la ventana en la pantalla

            idNivel = idLvl;

            enemy.Image = Image.FromFile(Globales.niveles[idNivel].Enemigo.Foto);
            lblNombreEnemigo.Text = Globales.niveles[idNivel].Enemigo.Nombre;
            pbEnemigo.Maximum = (int)Globales.niveles[idNivel].Enemigo.Vida;
            pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
            pbJugador.Maximum = (int)Globales.Jugador.VidaMaxima;
            pbJugador.Value = (int)Globales.Jugador.Vida;
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/" + Globales.niveles[idNivel].Mundo + ".jpg");

            if(Globales.niveles[idNivel].Enemigo.SonidoIntro != null)
            {
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + Globales.niveles[idNivel].Enemigo.SonidoIntro);
                player.Play();
            }

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.go_back, "Huye del combate asumiendo el daño recibido.");
            toolTip1.SetToolTip(this.btnAtacar, "Ataca al enemigo.");
            toolTip1.SetToolTip(this.btnEsquivar, "Esquiva el ataque sufriendo la mitad de daño\ny recupera algo de energia.");
            toolTip1.SetToolTip(this.pbEnemigo, "La salud del enemigo.");
            toolTip1.SetToolTip(this.pbJugador, "Tu propia salud.");
        }

        private void actualizarDatos()
        {
            if (Globales.Jugador.Vida <= 0)
            {
                Globales.Jugador.Vida = 0;
                pbJugador.Value = (int)Globales.Jugador.Vida;
                pbJugador.Refresh();
                player_combat.Image = Image.FromFile("../../Images/Characters/player_combat_dead.png");
                player_combat.Refresh();
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/gameOver.wav");
                player.PlaySync();
                //FIN DE LA PARTIDA Y REINICIAR EL JUEGO
                this.Hide();
                Vista_Muerte vistaMuerte = new Vista_Muerte();
                //vistaMuerte.Closed += (s, args) => { Application.Restart(); Environment.Exit(0); };
                vistaMuerte.Show();
            }
            else if (Globales.niveles[idNivel].Enemigo.Vida <= 0)
            {
                Globales.niveles[idNivel].Enemigo.Vida = 0;
                pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
                pbEnemigo.Refresh();
                player_combat.Image = Image.FromFile("../../Images/Characters/player_combat_win.png");
                player_combat.Refresh();
                enemy.Image = Image.FromFile("../../Images/Characters/deadEnemy.png");
                Globales.niveles[idNivel].EnemigoAcechante = false;
                Globales.Jugador.Dinero += pbEnemigo.Maximum;
                Globales.Jugador.Vida += (Globales.Jugador.VidaMaxima / 4);
                if (Globales.Jugador.Vida > Globales.Jugador.VidaMaxima)
                {
                    Globales.Jugador.Vida = Globales.Jugador.VidaMaxima;
                }
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + Globales.niveles[idNivel].Enemigo.SonidoDerrota);
                player.PlaySync();
                btnAtacar.Visible = false;
                btnEsquivar.Visible = false;
                go_back.Image = Image.FromFile("../../Images/UI/arrow_right.png");
            }
            try
            {
                pbJugador.Value = (int)Globales.Jugador.Vida;
            }
            catch (Exception)
            {
                pbJugador.Value = 0;
            }
            try
            {
                pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
            }
            catch (Exception)
            {
                pbEnemigo.Value = 0;
            }
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = null;
            if (pbEnemigo.Value > 0)
            {
                player = new System.Media.SoundPlayer(@"../../Sounds/SFX/enemy_encounter.wav");
            }
            else
            {
                player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            }
            player.Play();
            this.Close();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            int sonidoAtaque = 1;

            if (Globales.Jugador.Vida % 2 == 0)
            {
                sonidoAtaque = 1;
            }
            else
            {
                sonidoAtaque = 2;
            }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/crash_spin" + sonidoAtaque + ".wav");
            player.Play();

            Globales.Jugador.recibirAtaque(Globales.niveles[idNivel].Enemigo.generarAtaque());
            Globales.niveles[idNivel].Enemigo.recibirAtaque(Globales.Jugador.generarAtaque());

            actualizarDatos();
        }

        private void btnEsquivar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/crash_cortexthrow.wav");
            player.Play();

            Globales.Jugador.recibirAtaque((Globales.niveles[idNivel].Enemigo.generarAtaque() / 2));

            Random rnd = new Random();
            int saludGenerada = rnd.Next(10, (int)(Globales.Jugador.VidaMaxima / 4));
            Globales.Jugador.Vida += saludGenerada;
            if (Globales.Jugador.Vida > Globales.Jugador.VidaMaxima)
            {
                Globales.Jugador.Vida = Globales.Jugador.VidaMaxima;
            }
            int saludEnemigo = rnd.Next(1, (int)(pbEnemigo.Maximum / 5));
            Globales.niveles[idNivel].Enemigo.Vida += saludEnemigo;
            if (Globales.niveles[idNivel].Enemigo.Vida > pbEnemigo.Maximum)
            {
                Globales.niveles[idNivel].Enemigo.Vida = pbEnemigo.Maximum;
            }

            actualizarDatos();
        }
    }
}
