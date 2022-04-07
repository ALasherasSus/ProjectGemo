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
    public partial class Vista_Tienda : Form
    {
        public Vista_Tienda(String tienda)
        {
            InitializeComponent();
            this.CenterToScreen(); //Centrar la ventana en la pantalla
            cargarPantalla();
            switch (tienda)
            {
                case "izquierda":
                    cargarIzquierda();
                    break;
                case "derecha":
                    cargarDerecha();
                    break;
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

        private void cargarIzquierda()
        {
            go_back.Image = Image.FromFile("../../Images/UI/arrow_right.png");
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/shop1.jpg");

            lblAtaque.Enabled = false;
            pbAtaque.Enabled = false;
            btnAtaque.Enabled = false;
            lblDefensa.Enabled = false;
            pbDefensa.Enabled = false;
            btnDefensa.Enabled = false;
        }

        private void cargarDerecha()
        {
            go_back.Image = Image.FromFile("../../Images/UI/arrow_left.png");
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/shop2.jpg");

            lblVida.Enabled = false;
            pbVida.Enabled = false;
            btnVida.Enabled = false;
            lblVidaMaxima.Enabled = false;
            pbVidaMaxima.Enabled = false;
            btnVidaMaxima.Enabled = false;
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/door_close.wav");
            player.Play();
            this.Close();
        }

        private void btnVida_Click(object sender, EventArgs e)
        {
            if (Globales.Jugador.Dinero >= Convert.ToInt32(btnVida.Text) && pbVida.Maximum != Globales.Jugador.Vida)
            {
                Globales.Jugador.Dinero -= Convert.ToInt32(btnVida.Text);
                Globales.Jugador.Vida += 10;
                if (Globales.Jugador.Vida > Globales.Jugador.VidaMaxima)
                {
                    Globales.Jugador.Vida = Globales.Jugador.VidaMaxima;
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/buy_upgrade.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/upgrade_unavailable.wav");
                player.Play();
            }
            cargarPantalla();
        }

        private void btnVidaMaxima_Click(object sender, EventArgs e)
        {
            if (Globales.Jugador.Dinero >= Convert.ToInt32(btnVidaMaxima.Text) && pbVidaMaxima.Maximum != Globales.Jugador.VidaMaxima)
            {
                Globales.Jugador.Dinero -= Convert.ToInt32(btnVidaMaxima.Text);
                Globales.Jugador.VidaMaxima += 50;
                Globales.Jugador.Vida += 50;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/buy_upgrade.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/upgrade_unavailable.wav");
                player.Play();
            }
            cargarPantalla();
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            if (Globales.Jugador.Dinero >= Convert.ToInt32(btnAtaque.Text) && pbAtaque.Maximum != Globales.Jugador.Ataque)
            {
                Globales.Jugador.Dinero -= Convert.ToInt32(btnAtaque.Text);
                Globales.Jugador.Ataque += 5;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/buy_upgrade.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/upgrade_unavailable.wav");
                player.Play();
            }
            cargarPantalla();
        }

        private void btnDefensa_Click(object sender, EventArgs e)
        {
            if (Globales.Jugador.Dinero >= Convert.ToInt32(btnDefensa.Text) && pbDefensa.Maximum != Globales.Jugador.Defensa)
            {
                Globales.Jugador.Dinero -= Convert.ToInt32(btnDefensa.Text);
                Globales.Jugador.Defensa += 1;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/buy_upgrade.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/upgrade_unavailable.wav");
                player.Play();
            }
            cargarPantalla();
        }

        private void cargarPantalla()
        {
            pbVida.Maximum = (int)Globales.Jugador.VidaMaxima;
            pbVida.Value = (int)Globales.Jugador.Vida;
            pbVidaMaxima.Value = (int)Globales.Jugador.VidaMaxima;
            pbAtaque.Value = Globales.Jugador.Ataque;
            pbDefensa.Value = (int)(Globales.Jugador.Defensa);
            tbDinero.Text = Globales.Jugador.Dinero + "$";
        }
    }
}
