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
            lblVidaEnemigo.Text = "" + (int)Globales.niveles[idNivel].Enemigo.Vida;
            pbJugador.Maximum = (int)Globales.Jugador.VidaMaxima;
            pbJugador.Value = (int)Globales.Jugador.Vida;
            lblVidaJugador.Text = "" + (int)Globales.Jugador.Vida;
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/" + Globales.niveles[idNivel].Mundo + ".jpg");
            if (Globales.niveles[idNivel].Enemigo.Nombre.Equals("Mega-Mix"))
            {
                go_back.Visible = false;
            }

            if (Globales.niveles[idNivel].Enemigo.SonidoIntro != null)
            {
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + Globales.niveles[idNivel].Enemigo.SonidoIntro);
                player.Play();
            }

            if (Globales.modoDebug == true)
            {
                lblDebug.Visible = true;
                lblVidaEnemigo.Visible = true;
                lblVidaJugador.Visible = true;
            }

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.go_back, "Huye del combate asumiendo el daño recibido.");
            toolTip1.SetToolTip(this.btnAtacar, "Ataca al enemigo.");
            toolTip1.SetToolTip(this.btnEsquivar, "Esquiva el ataque sufriendo la mitad de daño\ny recupera algo de energía.");
            toolTip1.SetToolTip(this.pbEnemigo, "La salud del enemigo.");
            toolTip1.SetToolTip(this.pbJugador, "Tu propia salud.");
        }

        private void actualizarDatos()
        {
            if (Globales.Jugador.Vida <= 0)
            {
                //FIN DE LA PARTIDA Y REINICIAR EL JUEGO
                Globales.Jugador.Vida = 0;
                pbJugador.Value = (int)Globales.Jugador.Vida;
                pbJugador.Refresh();
                player_combat.Image = Image.FromFile("../../Images/Characters/player_combat_dead.png");
                player_combat.Refresh();
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/gameOver.wav");
                player.PlaySync();
                this.Hide();
                Vista_Muerte vistaMuerte = new Vista_Muerte();
                //vistaMuerte.Closed += (s, args) => { Application.Restart(); Environment.Exit(0); };
                vistaMuerte.Show();
            }
            else if (Globales.niveles[idNivel].Enemigo.Vida <= 0)
            {
                //ENEMIGO DERROTADO
                Globales.niveles[idNivel].Enemigo.Vida = 0;
                pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
                pbEnemigo.Refresh();
                player_combat.Image = Image.FromFile("../../Images/Characters/player_combat_win.png");
                player_combat.Refresh();
                enemy.Image = Image.FromFile("../../Images/Characters/deadEnemy.png");
                Globales.niveles[idNivel].EnemigoAcechante = false;
                Globales.Jugador.Dinero += pbEnemigo.Maximum; //El jugador recibe la cantidad inicial de vida del enemigo en dinero
                Globales.Jugador.Vida += (Globales.Jugador.VidaMaxima / 3); //El jugador recupera hasta un tercio de su vida máxima
                if (Globales.Jugador.Vida > Globales.Jugador.VidaMaxima)
                {
                    Globales.Jugador.Vida = Globales.Jugador.VidaMaxima;
                }
                Globales.Jugador.Ataque += 10; //El jugador sube de ataque al derrotar a un enemigo
                if (Globales.Jugador.Ataque > Globales.ataqueMaximo)
                {
                    Globales.Jugador.Ataque = Globales.ataqueMaximo;
                }
                //Si derrotas a un Jefe Supremo (que se identifican por tener diálogo inicial), subes el nivel de defensa del jugador
                if (Globales.niveles[idNivel].Enemigo.SonidoIntro != null)
                {
                    Globales.Jugador.Defensa++;
                    if (Globales.Jugador.Defensa > Globales.defensaMaxima)
                    {
                        //Si el nivel de defensa del jugador ya está al maximo, recibes el coste de subir el nivel de defensa
                        Globales.Jugador.Defensa = Globales.defensaMaxima;
                        Globales.Jugador.Dinero += 250;
                    }
                }
                System.Threading.Thread.Sleep(1000);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"" + Globales.niveles[idNivel].Enemigo.SonidoDerrota);
                player.PlaySync();
                player = new System.Media.SoundPlayer(@"../../Sounds/SFX/crystal_aquire.wav");
                player.Play();
                btnAtacar.Visible = false;
                btnEsquivar.Visible = false;
                go_back.Visible = true;
                go_back.Image = Image.FromFile("../../Images/UI/arrow_right.png");
            }

            try
            {
                pbJugador.Value = (int)Globales.Jugador.Vida;
                lblVidaJugador.Text = "" + (int)Globales.Jugador.Vida;
            }
            catch (Exception)
            {
                pbJugador.Value = 0;
                lblVidaJugador.Text = "0";
            }
            try
            {
                pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
                lblVidaEnemigo.Text = "" + (int)Globales.niveles[idNivel].Enemigo.Vida;
            }
            catch (Exception)
            {
                pbEnemigo.Value = 0;
                lblVidaEnemigo.Text = "0";
            }
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = null;
            if (pbEnemigo.Value > 0)
            {
                Globales.Jugador.Huidas++;
                if (Globales.Jugador.Huidas == 1)
                {
                    Vista_Cinematica VistaCinematica = new Vista_Cinematica(new Cinematica("cutscene_aku", "aku_crystals_1"));
                    this.Hide();
                    VistaCinematica.Closed += (s, args) => { salirCombate(); };
                    VistaCinematica.Show();
                }
                else if (Globales.Jugador.Huidas == 2)
                {
                    Vista_Cinematica VistaCinematica = new Vista_Cinematica(new Cinematica("cutscene_akucrystal", "aku_crystals_2"));
                    this.Hide();
                    VistaCinematica.Closed += (s, args) => { salirCombate(); };
                    VistaCinematica.Show();
                }
                else
                {
                    player = new System.Media.SoundPlayer(@"../../Sounds/SFX/enemy_encounter.wav");
                    player.Play();
                    salirCombate();
                }
            }
            else
            {
                player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
                player.Play();
                salirCombate();
            }
        }
        private void salirCombate()
        {
            this.Show();
            Globales.niveles[idNivel].Enemigo.Vida = pbEnemigo.Maximum;
            this.Close();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            int sonidoAtaque = 1;

            //Dependiendo de si la vida del jugador es par o impar, el ataque hace un sonido u otro
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
            int saludGenerada = rnd.Next(10, (int)(Globales.Jugador.VidaMaxima / 3));
            Globales.Jugador.Vida += saludGenerada;
            if (Globales.Jugador.Vida > Globales.Jugador.VidaMaxima)
            {
                Globales.Jugador.Vida = Globales.Jugador.VidaMaxima;
            }
            int saludEnemigo = rnd.Next(1, (int)(pbEnemigo.Maximum / 5));
            if (Globales.niveles[idNivel].Enemigo.SonidoIntro != null)
            {
                saludEnemigo = saludEnemigo / 2;
            }
            Globales.niveles[idNivel].Enemigo.Vida += saludEnemigo;
            if (Globales.niveles[idNivel].Enemigo.Vida > pbEnemigo.Maximum)
            {
                Globales.niveles[idNivel].Enemigo.Vida = pbEnemigo.Maximum;
            }

            actualizarDatos();
        }
    }
}
