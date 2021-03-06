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
    public partial class Vista_FinalBueno : Form
    {
        public Vista_FinalBueno()
        {
            InitializeComponent();
            this.CenterToScreen(); //Centrar la ventana en la pantalla
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/Music/GoodEndingTheme.wav");
            player.PlayLooping();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/click1.wav");
            player.Play();
            Application.Restart();
            Environment.Exit(0);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/click2.wav");
            player.PlaySync();
            Environment.Exit(0);
        }
    }
}
