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
    public partial class Vista_Mapa : Form
    {
        private String mapaAnterior = "lvl1_1"; //Mapa anterior al que huir - GUARDAR
        private Nivel mapaActual; //Mapa en el que te encuentras - GUARDAR
        private String direccionArriba; //Mapa al que te mueves usando la flecha de arriba
        private String direccionAbajo; //Mapa al que te mueves usando la flecha de abajo
        private String direccionIzquierda; //Mapa al que te mueves usando la flecha de la izquierda
        private String direccionDerecha; //Mapa al que te mueves usando la flecha de la derecha
        private Boolean enemigoVisible; //Indica si hay un enemigo en el mapa actual
        private int ranura; //La ranura en la que se guarda/carga la partida
        private Boolean enemigosVivos; //Indica si aun quedan enemigos por derrotar en el juego
        public Vista_Mapa(Boolean cargar, int ranura)
        {
            InitializeComponent();
            this.CenterToScreen(); // Centrar la ventana en la pantalla
            this.ranura = ranura;

            //Globales.modoDebug = true; //ACTIVAR EL MODO DEBUG
            if (Globales.modoDebug == true)
            {
                lblDebug.Visible = true;
            }

            switch (cargar)
            {
                case false: //Nueva Partida
                    Globales.niveles = new List<Nivel>();
                    generarMapas();
                    Globales.Jugador = new Jugador(100, 100, 25, 0, 0);
                    cargarNivel(Globales.niveles[0]);
                    break;
                case true: //Cargar Partida
                    try
                    {
                        cargarRanura(ranura);
                        cargarNivel(mapaActual);
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La partida a cargar no existe o está dañada. Iniciando una nueva.");
                        Globales.niveles = new List<Nivel>();
                        generarMapas();
                        Globales.Jugador = new Jugador(100, 100, 25, 0, 0);
                        cargarNivel(Globales.niveles[0]);
                        break;
                    }
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
            partida P = cargarGuardar.cargarPartida(ranura);
            Globales.niveles = P.Niveles;
            mapaAnterior = P.MapaAnterior;
            mapaActual = P.MapaActual;
            Globales.Jugador = P.Jugador;
        }

        private void generarMapas()
        {
            //Este método crea el listado de mapas en su forma de salida,
            //como estarían en una nueva partida
            enemigosVivos = true;

            Nivel lvl1_1 = new Nivel();
            lvl1_1.Nombre = "lvl1_1";
            lvl1_1.FlechaArriba = true;
            lvl1_1.DireccionArriba = "lvl1_2";
            lvl1_1.ImagenFondo = "../../Images/Backgrounds/level1_1.jpg";
            lvl1_1.Mundo = "selva";
            Globales.niveles.Add(lvl1_1);

            Nivel lvl1_2 = new Nivel();
            lvl1_2.Nombre = "lvl1_2";
            lvl1_2.FlechaArriba = true;
            lvl1_2.DireccionArriba = "lvl1_3";
            lvl1_2.FlechaAbajo = true;
            lvl1_2.DireccionAbajo = "lvl1_1";
            lvl1_2.TiendaIzquierda = true;
            lvl1_2.ImagenFondo = "../../Images/Backgrounds/level1_2.jpg";
            lvl1_2.Mundo = "selva";
            lvl1_2.EnemigoAcechante = true;
            lvl1_2.Enemigo = new Enemigo("Cangrejo", 100, 20, "../../Images/Characters/enemy1.png");
            lvl1_2.Cinematica = new Cinematica("cutscene_cortex", "cortex_vortex1");
            Globales.niveles.Add(lvl1_2);

            Nivel lvl1_3 = new Nivel();
            lvl1_3.Nombre = "lvl1_3";
            lvl1_3.FlechaArriba = true;
            lvl1_3.DireccionArriba = "lvl2_1";
            lvl1_3.FlechaDerecha = true;
            lvl1_3.DireccionDerecha = "lvl3_1";
            lvl1_3.FlechaAbajo = true;
            lvl1_3.DireccionAbajo = "lvl1_2";
            lvl1_3.ImagenFondo = "../../Images/Backgrounds/level1_3.jpg";
            lvl1_3.Mundo = "selva";
            Globales.niveles.Add(lvl1_3);

            Nivel lvl2_1 = new Nivel();
            lvl2_1.Nombre = "lvl2_1";
            lvl2_1.FlechaArriba = true;
            lvl2_1.DireccionArriba = "lvl2_2";
            lvl2_1.FlechaAbajo = true;
            lvl2_1.DireccionAbajo = "lvl1_3";
            lvl2_1.ImagenFondo = "../../Images/Backgrounds/level2_1.jpg";
            lvl2_1.Mundo = "nieve";
            lvl2_1.EnemigoAcechante = true;
            lvl2_1.Enemigo = new Enemigo("Pingüino", 150, 25, "../../Images/Characters/enemy2.png");
            lvl2_1.Cinematica = new Cinematica("cutscene_dingodile", "dingodile_vortex1");
            Globales.niveles.Add(lvl2_1);

            Nivel lvl2_2 = new Nivel();
            lvl2_2.Nombre = "lvl2_2";
            lvl2_2.FlechaDerecha = true;
            lvl2_2.DireccionDerecha = "lvl2_3";
            lvl2_2.FlechaAbajo = true;
            lvl2_2.DireccionAbajo = "lvl2_1";
            lvl2_2.ImagenFondo = "../../Images/Backgrounds/level2_2.jpg";
            lvl2_2.Mundo = "nieve";
            lvl2_2.EnemigoAcechante = true;
            lvl2_2.Enemigo = new Enemigo("Nash", 300, 50, "../../Images/Characters/enemy3.png");
            lvl2_2.Cinematica = new Cinematica("cutscene_dingodile", "dingodile_vortex2");
            Globales.niveles.Add(lvl2_2);

            Nivel lvl2_3 = new Nivel();
            lvl2_3.Nombre = "lvl2_3";
            lvl2_3.FlechaDerecha = true;
            lvl2_3.DireccionDerecha = "lvl5_1";
            lvl2_3.FlechaIzquierda = true;
            lvl2_3.DireccionIzquierda = "lvl2_2";
            lvl2_3.ImagenFondo = "../../Images/Backgrounds/level2_3.jpg";
            lvl2_3.Mundo = "nieve";
            lvl2_3.EnemigoAcechante = true;
            lvl2_3.Enemigo = new Enemigo("Dingodile", 500, 150, "../../Images/Characters/boss2.png", "../../Sounds/SFX/boss2intro.wav", "../../Sounds/SFX/boss2defeat.wav");
            Globales.niveles.Add(lvl2_3);

            Nivel lvl3_1 = new Nivel();
            lvl3_1.Nombre = "lvl3_1";
            lvl3_1.FlechaDerecha = true;
            lvl3_1.DireccionDerecha = "lvl3_2";
            lvl3_1.FlechaIzquierda = true;
            lvl3_1.DireccionIzquierda = "lvl1_3";
            lvl3_1.ImagenFondo = "../../Images/Backgrounds/level3_1.jpg";
            lvl3_1.Mundo = "templo";
            lvl3_1.EnemigoAcechante = true;
            lvl3_1.Enemigo = new Enemigo("Planta Piraña", 250, 35, "../../Images/Characters/enemy4.png");
            lvl3_1.Cinematica = new Cinematica("cutscene_tiny", "tiny_vortex1");
            Globales.niveles.Add(lvl3_1);

            Nivel lvl3_2 = new Nivel();
            lvl3_2.Nombre = "lvl3_2";
            lvl3_2.FlechaDerecha = true;
            lvl3_2.DireccionDerecha = "lvl3_3";
            lvl3_2.FlechaIzquierda = true;
            lvl3_2.DireccionIzquierda = "lvl3_1";
            lvl3_2.ImagenFondo = "../../Images/Backgrounds/level3_2.jpg";
            lvl3_2.Mundo = "templo";
            lvl3_2.EnemigoAcechante = true;
            lvl3_2.Enemigo = new Enemigo("Indígena", 300, 40, "../../Images/Characters/enemy5.png");
            lvl3_2.Cinematica = new Cinematica("cutscene_tiny", "tiny_vortex2");
            Globales.niveles.Add(lvl3_2);

            Nivel lvl3_3 = new Nivel();
            lvl3_3.Nombre = "lvl3_3";
            lvl3_3.FlechaArriba = true;
            lvl3_3.DireccionArriba = "lvl4_1";
            lvl3_3.FlechaIzquierda = true;
            lvl3_3.DireccionIzquierda = "lvl3_2";
            lvl3_3.ImagenFondo = "../../Images/Backgrounds/level3_3.jpg";
            lvl3_3.Mundo = "templo";
            lvl3_3.EnemigoAcechante = true;
            lvl3_3.Enemigo = new Enemigo("Tiny Tiger", 450, 100, "../../Images/Characters/boss1.png", "../../Sounds/SFX/boss1intro.wav", "../../Sounds/SFX/boss1defeat.wav");
            Globales.niveles.Add(lvl3_3);

            Nivel lvl4_1 = new Nivel();
            lvl4_1.Nombre = "lvl4_1";
            lvl4_1.FlechaArriba = true;
            lvl4_1.DireccionArriba = "lvl4_2";
            lvl4_1.FlechaAbajo = true;
            lvl4_1.DireccionAbajo = "lvl3_3";
            lvl4_1.TiendaDerecha = true;
            lvl4_1.ImagenFondo = "../../Images/Backgrounds/level4_1.jpg";
            lvl4_1.Mundo = "alterno";
            lvl4_1.Cinematica = new Cinematica("cutscene_cortex", "cortex_vortex2");
            Globales.niveles.Add(lvl4_1);

            Nivel lvl4_2 = new Nivel();
            lvl4_2.Nombre = "lvl4_2";
            lvl4_2.FlechaArriba = true;
            lvl4_2.DireccionArriba = "lvl4_3";
            lvl4_2.FlechaAbajo = true;
            lvl4_2.DireccionAbajo = "lvl4_1";
            lvl4_2.ImagenFondo = "../../Images/Backgrounds/level4_2.jpg";
            lvl4_2.Mundo = "alterno";
            lvl4_2.EnemigoAcechante = true;
            lvl4_2.Enemigo = new Enemigo("N. Trance", 400, 80, "../../Images/Characters/enemy6.png");
            lvl4_2.Cinematica = new Cinematica("cutscene_ntropy", "ntropy_vortex1");
            Globales.niveles.Add(lvl4_2);

            Nivel lvl4_3 = new Nivel();
            lvl4_3.Nombre = "lvl4_3";
            lvl4_3.FlechaIzquierda = true;
            lvl4_3.DireccionIzquierda = "lvl5_1";
            lvl4_3.FlechaAbajo = true;
            lvl4_3.DireccionAbajo = "lvl4_2";
            lvl4_3.ImagenFondo = "../../Images/Backgrounds/level4_3.jpg";
            lvl4_3.Mundo = "alterno";
            lvl4_3.EnemigoAcechante = true;
            lvl4_3.Enemigo = new Enemigo("Dr. N. Tropy", 550, 200, "../../Images/Characters/boss3.png", "../../Sounds/SFX/boss3intro.wav", "../../Sounds/SFX/boss3defeat.wav");
            lvl4_3.Cinematica = new Cinematica("cutscene_ntropy", "ntropy_vortex3");
            Globales.niveles.Add(lvl4_3);

            Nivel lvl5_1 = new Nivel();
            lvl5_1.Nombre = "lvl5_1";
            lvl5_1.FlechaArriba = true;
            lvl5_1.DireccionArriba = "lvl5_2";
            lvl5_1.FlechaIzquierda = false;
            lvl5_1.DireccionIzquierda = "lvl2_3";
            lvl5_1.FlechaDerecha = false;
            lvl5_1.DireccionDerecha = "lvl4_3";
            lvl5_1.ImagenFondo = "../../Images/Backgrounds/level5_1_left.jpg";
            lvl5_1.Mundo = "castillo";
            lvl5_1.Cinematica = new Cinematica("cutscene_cortex", "cortex_vortex3");
            Globales.niveles.Add(lvl5_1);

            Nivel lvl5_2 = new Nivel();
            lvl5_2.Nombre = "lvl5_2";
            lvl5_2.FlechaArriba = true;
            lvl5_2.DireccionArriba = "lvl5_3";
            lvl5_2.FlechaAbajo = true;
            lvl5_2.DireccionAbajo = "lvl5_1";
            lvl5_2.ImagenFondo = "../../Images/Backgrounds/level5_2.jpg";
            lvl5_2.Mundo = "castillo";
            lvl5_2.EnemigoAcechante = true;
            lvl5_2.Enemigo = new Enemigo("Dr. N. Gin", 600, 250, "../../Images/Characters/boss4.png", "../../Sounds/SFX/boss4intro.wav", "../../Sounds/SFX/boss4defeat.wav");
            lvl5_2.Cinematica = new Cinematica("cutscene_ngin", "ngin_vortex1");
            Globales.niveles.Add(lvl5_2);

            Nivel lvl5_3 = new Nivel();
            lvl5_3.Nombre = "lvl5_3";
            lvl5_3.FlechaAbajo = true;
            lvl5_3.DireccionAbajo = "lvl5_2";
            lvl5_3.ImagenFondo = "../../Images/Backgrounds/level5_3.jpg";
            lvl5_3.Mundo = "castillo";
            lvl5_3.EnemigoAcechante = true;
            lvl5_3.Enemigo = new Enemigo("Dr. Neo Cortex", 650, 300, "../../Images/Characters/boss5.png", "../../Sounds/SFX/boss5intro.wav", "../../Sounds/SFX/boss5defeat.wav");
            lvl5_3.Cinematica = new Cinematica("cutscene_cortex", "cortex_vortex6");
            Globales.niveles.Add(lvl5_3);
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

            //Se reproduce cinematica si el nivel la incluye
            if (mapaActual.Cinematica != null)
            {
                Vista_Cinematica VistaCinematica = new Vista_Cinematica(mapaActual.Cinematica);
                this.Hide();
                VistaCinematica.Closed += (s, args) => { this.Show(); mapaActual.Cinematica = null; };
                VistaCinematica.Show();
            }
            //Se establece que flechas están disponibles y si lo están, a que dirección te dirigen
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

            //Comprueba si hay un enemigo en el mapa actual
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

            //Establece el fondo del nivel/pantalla actual
            this.BackgroundImage = Image.FromFile(lvl.ImagenFondo);
        }

        private int extraerNombreNivel(String nombreNivel)
        {
            //Se introduce el nombre del nivel a buscar y devuelve su id en el list
            int numeroNivel = -1;

            for (int i = 0; i < Globales.niveles.Count; i++)
            {
                if (Globales.niveles[i].Nombre == nombreNivel)
                {
                    numeroNivel = i;
                    break;
                }
            }

            return numeroNivel;
        }

        private void comprobarFinal()
        {
            //Comprueba si aun quedan enemigos vivos en el juego para dar valor a la variable
            enemigosVivos = false;
            foreach (var nivel in Globales.niveles)
            {
                if (nivel.EnemigoAcechante == true)
                {
                    enemigosVivos = true;
                }
            }
        }

        private void cargarFinal()
        {
            //En base a si quedan enemigos en el juego o no, recibes un final u otro
            if (enemigosVivos == true)
            {
                Vista_FinalMalo vistaFinalMalo = new Vista_FinalMalo();
                vistaFinalMalo.Show();
            }
            else
            {
                Cinematica cs = new Cinematica("cutscene_finals1", "secret_ending_bg");
                cs.Special = true;
                Vista_Cinematica vistaCinematica = new Vista_Cinematica(cs);
                this.Hide();
                vistaCinematica.Closed += (s, args) =>
                {
                    mapaActual.Mundo = "secreto";
                    mapaActual.EnemigoAcechante = true;
                    mapaActual.Enemigo = new Enemigo("Mega-Mix", 1000, 500, "../../Images/Characters/boss6.png", "../../Sounds/SFX/boss6intro.wav", "../../Sounds/SFX/boss6defeat.wav");
                    Thread.Sleep(1000);
                    Vista_Combate vistaCombate = new Vista_Combate(extraerNombreNivel(mapaActual.Nombre));
                    vistaCombate.Closed += (s2, args2) =>
                    {
                        Vista_FinalBueno vistaFinalBueno = new Vista_FinalBueno();
                        vistaFinalBueno.Show();
                    };
                    vistaCombate.Show();
                };
                vistaCinematica.Show();

            }
        }

        private void arrow_top_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(Globales.niveles[extraerNombreNivel(direccionArriba)]);
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
            cargarNivel(Globales.niveles[extraerNombreNivel(direccionAbajo)]);
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
            if (mapaActual.Nombre == "lvl4_3")
            {
                Globales.niveles[extraerNombreNivel("lvl5_1")].FlechaDerecha = true;
                if (Globales.niveles[extraerNombreNivel("lvl5_1")].FlechaIzquierda == true)
                {
                    Globales.niveles[extraerNombreNivel("lvl5_1")].ImagenFondo = "../../Images/Backgrounds/level5_1_both.jpg";
                }
                else
                {
                    Globales.niveles[extraerNombreNivel("lvl5_1")].ImagenFondo = "../../Images/Backgrounds/level5_1_right.jpg";
                }
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(Globales.niveles[extraerNombreNivel(direccionIzquierda)]);
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
            if (mapaActual.Nombre == "lvl2_3")
            {
                Globales.niveles[extraerNombreNivel("lvl5_1")].FlechaIzquierda = true;
                if (Globales.niveles[extraerNombreNivel("lvl5_1")].FlechaDerecha == true)
                {
                    Globales.niveles[extraerNombreNivel("lvl5_1")].ImagenFondo = "../../Images/Backgrounds/level5_1_both.jpg";
                }
                else
                {
                    Globales.niveles[extraerNombreNivel("lvl5_1")].ImagenFondo = "../../Images/Backgrounds/level5_1_left.jpg";
                }
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
            player.Play();
            cargarNivel(Globales.niveles[extraerNombreNivel(direccionDerecha)]);
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
                //EMPEZAR COMBATE
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/enemy_encounter.wav");
                player.Play();
                this.Hide();
                Vista_Combate vistaCombate = new Vista_Combate(extraerNombreNivel(mapaActual.Nombre));
                vistaCombate.Closed += (s, args) =>
                {
                    if (mapaActual.Nombre == "lvl5_3" && Globales.niveles[extraerNombreNivel("lvl5_3")].EnemigoAcechante == false) //Si es el nivel final (Jefe de fase final)
                    {
                        comprobarFinal();
                        cargarFinal();
                    }
                    else
                    {
                        this.Show();
                        this.CenterToScreen();
                        if (Globales.niveles[extraerNombreNivel(mapaActual.Nombre)].EnemigoAcechante == false) cargarNivel(Globales.niveles[extraerNombreNivel(mapaActual.Nombre)]);
                    }
                };
                vistaCombate.Show();
            }
            else
            {
                //MOSTRAR ESTADÍSTICAS
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/aku_up.wav");
                player.Play();
                this.Hide();
                Vista_Estadisticas vistaEstadisticas = new Vista_Estadisticas();
                vistaEstadisticas.Closed += (s, args) => { this.Show(); this.CenterToScreen(); };
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
                //Si no hay enemigos, guardas partida
                cargarGuardar.guardarPartida(Globales.niveles, mapaAnterior, mapaActual, Globales.Jugador, ranura);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/checkpoint.wav");
                player.PlaySync();
            }
            else
            {
                //Si hay enemigos, huyes del nivel
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/change_screen.wav");
                player.Play();
                cargarNivel(Globales.niveles[extraerNombreNivel(mapaAnterior)]);
            }
        }
    }
}
