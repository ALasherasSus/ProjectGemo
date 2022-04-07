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
            pbJugador.Maximum = (int)Globales.Jugador.Vida;
            pbJugador.Value = (int)Globales.Jugador.Vida;

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
            pbEnemigo.Value = (int)Globales.niveles[idNivel].Enemigo.Vida;
            pbJugador.Value = (int)Globales.Jugador.Vida;
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/enemy_encounter.wav");
            player.Play();
            this.Close();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/spin.wav");
            player.Play();
            //AÑADIR LOS METODOS FALTANTES
            Globales.Jugador.recibirAtaque(Globales.niveles[idNivel].Enemigo.generarAtaque());
            actualizarDatos();
        }

        private void btnEsquivar_Click(object sender, EventArgs e)
        {

            actualizarDatos();
        }
    }
}
