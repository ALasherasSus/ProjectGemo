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
        public List<Nivel> niveles;
        public Vista_Mapa()
        {
            InitializeComponent();
        }

        public void generarMapas()
        {
            Nivel lvl1_1 = new Nivel();
            lvl1_1.FlechaArriba = true;
            lvl1_1.DireccionArriba = "lvl1_2";
            lvl1_1.ImagenFondo = "../../Images/Backgrounds/level1_1.jpg";
            niveles.Add(lvl1_1);

            Nivel lvl1_2 = new Nivel();
            lvl1_2.FlechaArriba = true;
            lvl1_2.DireccionArriba = "lvl1_3";
            lvl1_2.TiendaIzquierda = true;
            lvl1_2.ImagenFondo = "../../Images/Backgrounds/level1_2.jpg";
            niveles.Add(lvl1_2);
        }

        public void cargarNivel(Nivel lvl)
        {
            arrow_bottom.Visible = false;
            arrow_left.Visible = false;
            arrow_right.Visible = false;
            arrow_top.Visible = false;
            shop_left.Visible = false;
            shop_right.Visible = false;

            if (lvl.FlechaAbajo == true)
            {
                arrow_bottom.Visible = true;
            }

            if (lvl.FlechaArriba == true)
            {
                arrow_top.Visible = true;
            }

            if (lvl.FlechaDerecha == true)
            {
                arrow_right.Visible = true;
            }

            if (lvl.FlechaIzquierda == true)
            {
                arrow_left.Visible = true;
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

        private void arrow_top_Click(object sender, EventArgs e)
        {

        }
    }
}
