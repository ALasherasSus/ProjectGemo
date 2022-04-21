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
    public partial class Vista_Muerte : Form
    {
        public Vista_Muerte()
        {
            InitializeComponent();
            this.CenterToScreen(); //Centrar la ventana en la pantalla
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/cortex_game_over.wav");
            player.Play();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/cortex_game_over_continue_yes.wav");
            player.PlaySync();
            Application.Restart();
            Environment.Exit(0);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/cortex_game_over_continue_no.wav");
            player.PlaySync();
            Environment.Exit(0);
        }
    }
}
