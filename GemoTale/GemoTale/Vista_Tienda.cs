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
            this.CenterToScreen(); // Centrar la ventana en la pantalla

            switch (tienda)
            {
                case "izquierda":
                    cargarIzquierda();
                    break;
                case "derecha":
                    cargarDerecha();
                    break;
            }
        }

        private void cargarIzquierda()
        {
            go_back.Image = Image.FromFile("../../Images/UI/arrow_right.png");
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/shop1.jpg");
        }

        private void cargarDerecha()
        {
            go_back.Image = Image.FromFile("../../Images/UI/arrow_left.png");
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/shop2.jpg");
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/door_close.wav");
            player.Play();
            this.Close();
        }
    }
}
