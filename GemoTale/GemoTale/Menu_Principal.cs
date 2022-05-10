﻿using System;
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
    public partial class Menu_Principal : Form
    {
        // Este boolean definirá si la partida es nueva o se está cargando
        Boolean load = false;
        public Menu_Principal()
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            gameLogo.Image = Image.FromFile("../../Images/UI/game_logo.png");
            this.BackgroundImage = Image.FromFile("../../Images/Backgrounds/mainmenu.jpg");
            button1.Visible = false;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_Principal_KeyDown);

            if (Globales.modoDebug == true)
            {
                lblDebug.Visible = true;
            }

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.manual, "Abrir el Manual de Juego.");
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            // Las ranuras empiezan invisibles
            this.btnRanura1.Visible = false;
            this.btnRanura2.Visible = false;
            this.btnRanura3.Visible = false;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/click1.wav");
            player.Play();
            load = false;
            this.btnNueva.BackColor = Color.White;
            this.btnCargar.BackColor = Color.DeepSkyBlue;
            this.btnRanura1.Visible = true;
            this.btnRanura2.Visible = true;
            this.btnRanura3.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/click1.wav");
            player.Play();
            load = true;
            this.btnCargar.BackColor = Color.White;
            this.btnNueva.BackColor = Color.DeepSkyBlue;
            this.btnRanura1.Visible = true;
            this.btnRanura2.Visible = true;
            this.btnRanura3.Visible = true;
        }

        private void btnRanura1_Click(object sender, EventArgs e)
        {
            entrarJuego(1);
        }

        private void btnRanura2_Click(object sender, EventArgs e)
        {
            entrarJuego(2);
        }

        private void btnRanura3_Click(object sender, EventArgs e)
        {
            entrarJuego(3);
        }

        private void entrarJuego(int ranura)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/click2.wav");
            player.Play();

            // Esto esconde la ventana actual
            // La prepara para que si se cierra la ventana hija se cierre el programa
            // Y muestra la nueva ventana
            this.Hide();
            Vista_Mapa vistaMapa = new Vista_Mapa(load, ranura);
            vistaMapa.Closed += (s, args) => this.Close();
            vistaMapa.Show();
        }

        private void Menu_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                cheatBox.Visible = true;
            }
        }

        private void cheatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cheatBox.Text.ToUpper() == "WOMBAT")
            {
                Globales.modoDebug = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/buy_upgrade.wav");
                player.Play();
                if (Globales.modoDebug == true)
                {
                    lblDebug.Visible = true;
                    button1.Visible = true;
                }
            }
        }

        private void manual_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_up.wav");
            player.Play();

            manual.Visible = false;
            Manual vistaManual = new Manual();
            vistaManual.Closed += (s, args) => { manual.Visible = true; };
            vistaManual.Show();
        }

        private void manual_MouseHover(object sender, EventArgs e)
        {
            manual.Image = Image.FromFile("../../Images/UI/manual_on.png");
        }

        private void manual_MouseLeave(object sender, EventArgs e)
        {
            manual.Image = Image.FromFile("../../Images/UI/manual.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vista_Cinematica VistaCinematica = new Vista_Cinematica(new Cinematica("cutscene_cortex", "cortex_vortex1"));
            VistaCinematica.Show();
        }
    }
}
