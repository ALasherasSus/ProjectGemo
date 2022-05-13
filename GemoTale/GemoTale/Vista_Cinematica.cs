using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemoTale
{
    public partial class Vista_Cinematica : Form
    {
        Thread thread;
        System.Media.SoundPlayer player;
        public Vista_Cinematica(Cinematica cinematica)
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla

            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/" + cinematica.Cs_bg + ".gif");
            animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/" + cinematica.Cs_bg + ".gif");
            player = new System.Media.SoundPlayer(@"../../Sounds/Cutscenes/" + cinematica.Cs_sound + ".wav");

            WaveFileReader wf = new WaveFileReader(@"../../Sounds/Cutscenes/" + cinematica.Cs_sound + ".wav");
            TimeSpan sleepTime = wf.TotalTime;

            thread = new Thread(() =>
            {
                player.Play();
                if (cinematica.Special)
                {
                    player.PlayLooping();
                    this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene_finals1.gif");
                    animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene_finals1.gif");
                    Thread.Sleep(5000);
                    this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene_finals2.gif");
                    animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene_finals2.gif");
                    Thread.Sleep(5000);
                    this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene_finals3.gif");
                    animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene_finals3.gif");
                    Thread.Sleep(5000);
                    this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene_finals4.gif");
                    animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene_finals4.gif");
                    Thread.Sleep(5000);
                    this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene.gif");
                    animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene.gif");
                }
                Thread.Sleep(sleepTime);
                this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/cutscene.gif");
                animatedScreen.Image = Image.FromFile("../../Images/Backgrounds/cutscene.gif");
                go_back.Invoke(new Action(delegate () { go_back.Visible = true; }));
            });
            thread.Start();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            thread.Abort();
            player.Dispose();
            player = new System.Media.SoundPlayer(@"../../Sounds/SFX/crash_selectsound1.wav");
            player.Play();
            this.Close();
        }

        private void go_back_MouseHover(object sender, EventArgs e)
        {
            go_back.Image = Image.FromFile("../../Images/UI/control2.png");
        }

        private void go_back_MouseLeave(object sender, EventArgs e)
        {
            go_back.Image = Image.FromFile("../../Images/UI/control1.png");
        }
    }
}
