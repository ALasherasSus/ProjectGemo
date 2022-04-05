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
        public Vista_Estadisticas(Jugador jugador)
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            pbVida.Maximum = (int)jugador.VidaMaxima;
            pbVida.Value = (int)jugador.Vida;
            pbVidaMaxima.Value = (int)jugador.VidaMaxima;
            pbAtaque.Value = jugador.Ataque;
            pbDefensa.Value = (int)(jugador.Defensa * 10);
            tbDinero.Text = jugador.Dinero + "$";

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.lblVida, "La vida actual de tu personaje.");
            toolTip1.SetToolTip(this.lblVidaMaxima, "Como de mejorada está la vida máxima de tu personaje.");
            toolTip1.SetToolTip(this.lblAtaque, "Cuanto daño hace tu personaje.");
            toolTip1.SetToolTip(this.lblDefensa, "Cuanto defensa tiene tu personaje.");
            toolTip1.SetToolTip(this.lblDinero, "Cuanto dinero tiene tu personaje.");
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_hit.wav");
            player.Play();
            this.Close();
        }
    }
}
