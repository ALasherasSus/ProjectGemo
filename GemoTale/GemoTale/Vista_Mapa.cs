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
    public partial class Vista_Mapa : Form
    {
        private List<Nivel> niveles;
        private String direccionArriba;
        private String direccionAbajo;
        private String direccionIzquierda;
        private String direccionDerecha;
        public Vista_Mapa(Boolean cargar, int ranura)
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            player.Image = Image.FromFile("../../Images/Characters/player_map.png");
            niveles = new List<Nivel>();
            generarMapas();

            switch (cargar)
            {
                case false:
                    cargarNivel(niveles[0]);
                    break;
                case true:
                    cargarNivel(niveles[1]);
                    break;
            }
        }

        private void generarMapas()
        {
            Nivel lvl1_1 = new Nivel();
            lvl1_1.Nombre = "lvl1_1";
            lvl1_1.FlechaArriba = true;
            lvl1_1.DireccionArriba = "lvl1_2";
            lvl1_1.ImagenFondo = "../../Images/Backgrounds/level1_1.jpg";
            niveles.Add(lvl1_1);

            Nivel lvl1_2 = new Nivel();
            lvl1_2.Nombre = "lvl1_2";
            lvl1_2.FlechaArriba = true;
            lvl1_2.DireccionArriba = "lvl1_3";
            lvl1_2.FlechaAbajo = true;
            lvl1_2.DireccionAbajo = "lvl1_1";
            lvl1_2.TiendaIzquierda = true;
            lvl1_2.ImagenFondo = "../../Images/Backgrounds/level1_2.jpg";
            niveles.Add(lvl1_2);
        }

        private void cargarNivel(Nivel lvl)
        {
            arrow_bottom.Visible = false;
            arrow_left.Visible = false;
            arrow_right.Visible = false;
            arrow_top.Visible = false;
            shop_left.Visible = false;
            shop_right.Visible = false;
            direccionArriba = "";
            direccionAbajo = "";
            direccionIzquierda = "";
            direccionDerecha = "";

            if (lvl.FlechaAbajo == true)
            {
                arrow_bottom.Visible = true;
                direccionAbajo = lvl.DireccionAbajo;
            }

            if (lvl.FlechaArriba == true)
            {
                arrow_top.Visible = true;
                direccionArriba = lvl.DireccionArriba;
            }

            if (lvl.FlechaDerecha == true)
            {
                arrow_right.Visible = true;
                direccionDerecha = lvl.DireccionDerecha;
            }

            if (lvl.FlechaIzquierda == true)
            {
                arrow_left.Visible = true;
                direccionIzquierda = lvl.DireccionIzquierda;
            }

            if (lvl.TiendaDerecha == true)
            {
                shop_right.Visible = true;
            }

            if (lvl.TiendaIzquierda == true)
            {
                shop_left.Visible = true;
            }

            this.BackgroundImage = Image.FromFile(lvl.ImagenFondo);
        }

        private int extraerNombreNivel(String nombreNivel)
        {
            int numeroNivel = -1;

            for (int i = 0; i < niveles.Count; i++)
            {
                if (niveles[i].Nombre == nombreNivel)
                {
                    numeroNivel = i;
                    break;
                }
            }

            return numeroNivel;
        }

        private void arrow_top_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionArriba)]);
        }

        private void arrow_bottom_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionAbajo)]);
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionIzquierda)]);
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionDerecha)]);
        }

        private void shop_left_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/door_open.wav");
            player.Play();
            this.Hide();
            Vista_Tienda vistaTienda = new Vista_Tienda("izquierda");
            vistaTienda.Closed += (s, args) => this.Show(); this.CenterToScreen();
            vistaTienda.Show();
        }

        private void shop_right_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/door_open.wav");
            player.Play();
            this.Hide();
            Vista_Tienda vistaTienda = new Vista_Tienda("derecha");
            vistaTienda.Closed += (s, args) => this.Show(); this.CenterToScreen();
            vistaTienda.Show();
        }

        private void player_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_up.wav");
            player.Play();
        }

        private void checkpoint_Click(object sender, EventArgs e)
        {
            // IMPLEMENTAR GUARDAR PARTIDA (!)
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/checkpoint.wav");
            player.PlaySync();
        }
    }
}
