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
    public partial class Vista_Mapa : Form
    {
        private List<Nivel> niveles; //Listado de niveles generados - GUARDAR
        private String mapaAnterior = "lvl1_1"; //Mapa anterior al que huir - GUARDAR
        private Nivel mapaActual; //Mapa en el que te encuentras - GUARDAR
        private String direccionArriba; //Mapa al que te mueves usando la flecha de arriba
        private String direccionAbajo; //Mapa al que te mueves usando la flecha de abajo
        private String direccionIzquierda; //Mapa al que te mueves usando la flecha de la izquierda
        private String direccionDerecha; //Mapa al que te mueves usando la flecha de la derecha
        private Boolean enemigoVisible; //Indica si hay un enemigo en el mapa actual
        //public static Jugador jugador; //El objeto jugador - GUARDAR
        private int ranura; //La ranura en la que se guarda/carga la partida
        public Vista_Mapa(Boolean cargar, int ranura)
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            niveles = new List<Nivel>();
            this.ranura = ranura;

            Globales.modoDebug = true; //ACTIVAR EL MODO DEBUG
            if (Globales.modoDebug == true)
            {
                lblDebug.Visible = true;
            }

            switch (cargar)
            {
                case false: //Nueva Partida
                    generarMapas();
                    Globales.Jugador = new Jugador(60, 100, 100, 900, 0);
                    cargarNivel(niveles[0]);
                    break;
                case true: //Cargar Partida
                    cargarRanura(ranura);
                    //generarMapas(); //CUANDO ESTÉ IMPLEMENTADA LA CARGA DE PARTIDA ESTO DEBERÁ QUITARSE Y CARGAR LOS MAPAS DESDE LA PARTIDA
                    cargarNivel(mapaActual);
                    break;
            }

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.checkpoint, "Cuando no haya un enemigo en pantalla,\nutiliza este icono para guardar partida.\nSi estás en peligro utliza la bota para huir.");
            toolTip1.SetToolTip(this.player, "Pincha aquí para interactuar.");

        }

        private void cargarRanura(int ranura)
        {
            List<Object> objetos = cargarGuardar.cargarPartida(ranura);
            niveles = (List<Nivel>)objetos[0];
            mapaAnterior = (string)objetos[1];
            mapaActual = (Nivel)objetos[2];
            Globales.Jugador = (Jugador)objetos[3];
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
            lvl1_2.EnemigoAcechante = true;
            Enemigo enemigo1 = new Enemigo("Cangrejo", 100, 20, "../../Images/Characters/enemy1.png");
            lvl1_2.Enemigo = enemigo1;
            niveles.Add(lvl1_2);

            Nivel lvl1_3 = new Nivel();
            lvl1_3.Nombre = "lvl1_3";
            lvl1_3.FlechaArriba = true;
            lvl1_3.DireccionArriba = "lvl2_1";
            lvl1_3.FlechaDerecha = true;
            lvl1_3.DireccionDerecha = "lvl3_1";
            lvl1_3.FlechaAbajo = true;
            lvl1_3.DireccionAbajo = "lvl1_2";
            lvl1_3.ImagenFondo = "../../Images/Backgrounds/level1_3.jpg";
            niveles.Add(lvl1_3);

            Nivel lvl2_1 = new Nivel();
            lvl2_1.Nombre = "lvl2_1";
            lvl2_1.FlechaArriba = true;
            lvl2_1.DireccionArriba = "lvl2_2";
            lvl2_1.FlechaAbajo = true;
            lvl2_1.DireccionAbajo = "lvl1_3";
            lvl2_1.ImagenFondo = "../../Images/Backgrounds/level2_1.jpg";
            lvl2_1.EnemigoAcechante = true;
            Enemigo enemigo2 = new Enemigo("Pingüino", 150, 25, "../../Images/Characters/enemy2.png");
            lvl2_1.Enemigo = enemigo2;
            niveles.Add(lvl2_1);

            Nivel lvl2_2 = new Nivel();
            lvl2_2.Nombre = "lvl2_2";
            lvl2_2.FlechaDerecha = true;
            lvl2_2.DireccionDerecha = "lvl2_3";
            lvl2_2.FlechaAbajo = true;
            lvl2_2.DireccionAbajo = "lvl2_1";
            lvl2_2.ImagenFondo = "../../Images/Backgrounds/level2_2.jpg";
            lvl2_2.EnemigoAcechante = true;
            Enemigo jefe2 = new Enemigo("Dingodile", 500, 150, "../../Images/Characters/boss2.png");
            lvl2_2.Enemigo = jefe2;
            niveles.Add(lvl2_2);

            Nivel lvl2_3 = new Nivel();
            lvl2_3.Nombre = "lvl2_3";
            lvl2_3.FlechaDerecha = true;
            lvl2_3.DireccionDerecha = "lvl5_1";
            lvl2_3.FlechaIzquierda = true;
            lvl2_3.DireccionIzquierda = "lvl2_2";
            lvl2_3.ImagenFondo = "../../Images/Backgrounds/level2_3.jpg";
            lvl2_3.EnemigoAcechante = true;
            Enemigo enemigo3 = new Enemigo("Tiburón", 200, 30, "../../Images/Characters/enemy3.png");
            lvl2_3.Enemigo = enemigo3;
            niveles.Add(lvl2_3);

            Nivel lvl3_1 = new Nivel();
            lvl3_1.Nombre = "lvl3_1";
            lvl3_1.FlechaDerecha = true;
            lvl3_1.DireccionDerecha = "lvl3_2";
            lvl3_1.FlechaIzquierda = true;
            lvl3_1.DireccionIzquierda = "lvl1_3";
            lvl3_1.ImagenFondo = "../../Images/Backgrounds/level3_1.jpg";
            lvl3_1.EnemigoAcechante = true;
            Enemigo enemigo4 = new Enemigo("Planta Piraña", 250, 35, "../../Images/Characters/enemy4.png");
            lvl3_1.Enemigo = enemigo4;
            niveles.Add(lvl3_1);

            Nivel lvl3_2 = new Nivel();
            lvl3_2.Nombre = "lvl3_2";
            lvl3_2.FlechaDerecha = true;
            lvl3_2.DireccionDerecha = "lvl3_3";
            lvl3_2.FlechaIzquierda = true;
            lvl3_2.DireccionIzquierda = "lvl3_1";
            lvl3_2.ImagenFondo = "../../Images/Backgrounds/level3_2.jpg";
            lvl3_2.EnemigoAcechante = true;
            Enemigo enemigo5 = new Enemigo("Indígena", 300, 40, "../../Images/Characters/enemy5.png");
            lvl3_2.Enemigo = enemigo5;
            niveles.Add(lvl3_2);

            Nivel lvl3_3 = new Nivel();
            lvl3_3.Nombre = "lvl3_3";
            lvl3_3.FlechaArriba = true;
            lvl3_3.DireccionArriba = "lvl4_1";
            lvl3_3.FlechaIzquierda = true;
            lvl3_3.DireccionIzquierda = "lvl3_2";
            lvl3_3.ImagenFondo = "../../Images/Backgrounds/level3_3.jpg";
            lvl3_3.EnemigoAcechante = true;
            Enemigo jefe1 = new Enemigo("Tiny Tiger", 450, 100, "../../Images/Characters/boss1.png");
            lvl3_3.Enemigo = jefe1;
            niveles.Add(lvl3_3);

            Nivel lvl4_1 = new Nivel();
            lvl4_1.Nombre = "lvl4_1";
            lvl4_1.FlechaArriba = true;
            lvl4_1.DireccionArriba = "lvl4_2";
            lvl4_1.FlechaAbajo = true;
            lvl4_1.DireccionAbajo = "lvl3_3";
            lvl4_1.TiendaDerecha = true;
            lvl4_1.ImagenFondo = "../../Images/Backgrounds/level4_1.jpg";
            niveles.Add(lvl4_1);

            Nivel lvl4_2 = new Nivel();
            lvl4_2.Nombre = "lvl4_2";
            lvl4_2.FlechaIzquierda = true;
            lvl4_2.DireccionIzquierda = "lvl5_1";
            lvl4_2.FlechaAbajo = true;
            lvl4_2.DireccionAbajo = "lvl4_1";
            lvl4_2.ImagenFondo = "../../Images/Backgrounds/level4_2.jpg";
            lvl4_2.EnemigoAcechante = true;
            Enemigo jefe3 = new Enemigo("Dr. N. Tropy", 550, 200, "../../Images/Characters/boss3.png");
            lvl4_2.Enemigo = jefe3;
            niveles.Add(lvl4_2);

            Nivel lvl5_1 = new Nivel();
            lvl5_1.Nombre = "lvl5_1";
            lvl5_1.FlechaArriba = true;
            lvl5_1.DireccionArriba = "lvl5_2";
            lvl5_1.FlechaIzquierda = true;
            lvl5_1.DireccionIzquierda = "lvl2_3";
            lvl5_1.FlechaDerecha = true;
            lvl5_1.DireccionDerecha = "lvl4_2";
            lvl5_1.ImagenFondo = "../../Images/Backgrounds/level5_1.jpg";
            niveles.Add(lvl5_1);

            Nivel lvl5_2 = new Nivel();
            lvl5_2.Nombre = "lvl5_2";
            lvl5_2.FlechaArriba = true;
            lvl5_2.DireccionArriba = "lvl5_3";
            lvl5_2.FlechaAbajo = true;
            lvl5_2.DireccionAbajo = "lvl5_1";
            lvl5_2.ImagenFondo = "../../Images/Backgrounds/level5_2.jpg";
            lvl5_2.EnemigoAcechante = true;
            Enemigo jefe4 = new Enemigo("Dr. N. Gin", 600, 250, "../../Images/Characters/boss4.png");
            lvl5_2.Enemigo = jefe4;
            niveles.Add(lvl5_2);

            Nivel lvl5_3 = new Nivel();
            lvl5_3.Nombre = "lvl5_3";
            lvl5_3.FlechaAbajo = true;
            lvl5_3.DireccionAbajo = "lvl5_2";
            lvl5_3.ImagenFondo = "../../Images/Backgrounds/level5_3.jpg";
            lvl5_3.EnemigoAcechante = true;
            Enemigo jefe5 = new Enemigo("Dr. N. Cortex", 650, 300, "../../Images/Characters/boss5.png");
            lvl5_3.Enemigo = jefe5;
            niveles.Add(lvl5_3);
        }

        private void cargarNivel(Nivel lvl)
        {
            //Se cargan todos los atributos de un mapa a su estado por defecto
            player.Image = Image.FromFile("../../Images/Characters/player_map.png");
            checkpoint.Image = Image.FromFile("../../Images/UI/checkpoint.png");
            arrow_bottom.Visible = false;
            arrow_left.Visible = false;
            arrow_right.Visible = false;
            arrow_top.Visible = false;
            shop_left.Visible = false;
            shop_right.Visible = false;
            enemigoVisible = false;
            direccionArriba = "";
            direccionAbajo = "";
            direccionIzquierda = "";
            direccionDerecha = "";

            //Se guarda el nombre del mapa anterior para volver a él en caso de huida
            if (mapaActual != null)
            {
                mapaAnterior = mapaActual.Nombre;
            }
            //Se establece el nuevo nivel como actual
            mapaActual = lvl;

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

            if (lvl.EnemigoAcechante == true)
            {
                enemigoVisible = true;
                player.Image = Image.FromFile(lvl.Enemigo.Foto);
                checkpoint.Image = Image.FromFile("../../Images/UI/run.png");
                if (Globales.modoDebug == false)
                {
                    arrow_bottom.Visible = false;
                    arrow_top.Visible = false;
                    arrow_right.Visible = false;
                    arrow_left.Visible = false;
                    shop_left.Visible = false;
                    shop_right.Visible = false;
                }
            }

            this.BackgroundImage = Image.FromFile(lvl.ImagenFondo);
        }

        private int extraerNombreNivel(String nombreNivel)
        {
            //Se introduce el nombre del nivel a buscar y devuelve su id en el list
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

        private void arrow_top_MouseHover(object sender, EventArgs e)
        {
            arrow_top.Image = Image.FromFile("../../Images/UI/arrow_up_on.png");
        }

        private void arrow_top_MouseLeave(object sender, EventArgs e)
        {
            arrow_top.Image = Image.FromFile("../../Images/UI/arrow_up.png");
        }

        private void arrow_bottom_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionAbajo)]);
        }

        private void arrow_bottom_MouseHover(object sender, EventArgs e)
        {
            arrow_bottom.Image = Image.FromFile("../../Images/UI/arrow_down_on.png");
        }

        private void arrow_bottom_MouseLeave(object sender, EventArgs e)
        {
            arrow_bottom.Image = Image.FromFile("../../Images/UI/arrow_down.png");
        }

        private void arrow_left_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionIzquierda)]);
        }

        private void arrow_left_MouseHover(object sender, EventArgs e)
        {
            arrow_left.Image = Image.FromFile("../../Images/UI/arrow_left_on.png");
        }

        private void arrow_left_MouseLeave(object sender, EventArgs e)
        {
            arrow_left.Image = Image.FromFile("../../Images/UI/arrow_left.png");
        }

        private void arrow_right_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(niveles[extraerNombreNivel(direccionDerecha)]);
        }

        private void arrow_right_MouseHover(object sender, EventArgs e)
        {
            arrow_right.Image = Image.FromFile("../../Images/UI/arrow_right_on.png");
        }

        private void arrow_right_MouseLeave(object sender, EventArgs e)
        {
            arrow_right.Image = Image.FromFile("../../Images/UI/arrow_right.png");
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

        private void shop_MouseHover(object sender, EventArgs e)
        {
            shop_left.Image = Image.FromFile("../../Images/UI/shop_icon_on.png");
            shop_right.Image = Image.FromFile("../../Images/UI/shop_icon_on.png");
        }

        private void shop_MouseLeave(object sender, EventArgs e)
        {
            shop_left.Image = Image.FromFile("../../Images/UI/shop_icon.png");
            shop_right.Image = Image.FromFile("../../Images/UI/shop_icon.png");
        }

        private void player_Click(object sender, EventArgs e)
        {
            if (enemigoVisible == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/enemy_encounter.wav");
                player.Play();
                // EMPEZAR COMBATE (!)
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_up.wav");
                player.Play();
                this.Hide();
                Vista_Estadisticas vistaEstadisticas = new Vista_Estadisticas();
                vistaEstadisticas.Closed += (s, args) => this.Show(); this.CenterToScreen();
                vistaEstadisticas.Show();
            }
        }

        private void player_MouseHover(object sender, EventArgs e)
        {
            if (enemigoVisible == false)
            {
                player.Image = Image.FromFile("../../Images/Characters/player_map_on.png");
            }
        }

        private void player_MouseLeave(object sender, EventArgs e)
        {
            if (enemigoVisible == false)
            {
                player.Image = Image.FromFile("../../Images/Characters/player_map.png");
            }
        }

        private void checkpoint_Click(object sender, EventArgs e)
        {
            if (enemigoVisible == false)
            {
                cargarGuardar.guardarPartida(niveles, mapaAnterior, mapaActual, Globales.Jugador, ranura);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/checkpoint.wav");
                player.PlaySync();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
                player.Play();
                cargarNivel(niveles[extraerNombreNivel(mapaAnterior)]);
            }
        }
    }
}
