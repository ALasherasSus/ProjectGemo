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
    public partial class Vista_Estadisticas : Form
    {
        public Vista_Estadisticas()
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/Music/StatsTheme.wav");
            player.PlayLooping();
            cargarPantalla();

            if (Globales.modoDebug == true)
            {
                lblDebug.Visible = true;
                nudVida.Visible = true;
                nudVidaMaxima.Visible = true;
                nudAtaque.Visible = true;
                nudDefensa.Visible = true;
                nudDinero.Visible = true;
            }

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.lblVida, "La vida actual de tu personaje.");
            toolTip1.SetToolTip(this.lblVidaMaxima, "Como de mejorada está la vida máxima de tu personaje.");
            toolTip1.SetToolTip(this.lblAtaque, "El daño que inflinges en los ataques.");
            toolTip1.SetToolTip(this.lblDefensa, "La defensa reduce el daño del ataque enemigo.");
            toolTip1.SetToolTip(this.lblDinero, "Cuanto dinero tiene tu personaje.");
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_hit.wav");
            player.Play();
            this.Close();
        }

        private void cargarPantalla()
        {
            try
            {
                pbVida.Maximum = (int)Globales.Jugador.VidaMaxima;
                pbVida.Value = (int)Globales.Jugador.Vida;
                pbVidaMaxima.Value = (int)Globales.Jugador.VidaMaxima;
                pbAtaque.Value = Globales.Jugador.Ataque;
                pbDefensa.Value = (int)(Globales.Jugador.Defensa);
                tbDinero.Text = Globales.Jugador.Dinero + "$";

                nudVida.Value = (int)Globales.Jugador.Vida;
                nudVidaMaxima.Value = (int)Globales.Jugador.VidaMaxima;
                nudAtaque.Value = Globales.Jugador.Ataque;
                nudDefensa.Value = (int)(Globales.Jugador.Defensa);
                nudDinero.Value = Globales.Jugador.Dinero;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("El valor no es valido.");
            }
        }

        private void nudVida_ValueChanged(object sender, EventArgs e)
        {
            Globales.Jugador.Vida = (double)nudVida.Value;
            cargarPantalla();
        }

        private void nudVidaMaxima_ValueChanged(object sender, EventArgs e)
        {
            Globales.Jugador.VidaMaxima = (double)nudVidaMaxima.Value;
            cargarPantalla();
        }

        private void nudAtaque_ValueChanged(object sender, EventArgs e)
        {
            Globales.Jugador.Ataque = (int)nudAtaque.Value;
            cargarPantalla();
        }

        private void nudDefensa_ValueChanged(object sender, EventArgs e)
        {
            Globales.Jugador.Defensa = (int)nudDefensa.Value;
            cargarPantalla();
        }

        private void nudDinero_ValueChanged(object sender, EventArgs e)
        {
            Globales.Jugador.Dinero = (int)nudDinero.Value;
            cargarPantalla();
        }
    }
}
