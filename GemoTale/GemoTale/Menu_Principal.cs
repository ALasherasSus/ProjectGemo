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
    public partial class Menu_Principal : Form
    {
        // Este boolean definirá si la partida es nueva o se está cargando
        Boolean load = false;
        public Menu_Principal()
        {
            InitializeComponent();
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
            load = false;
            this.btnNueva.BackColor = Color.White;
            this.btnCargar.BackColor = Color.DeepSkyBlue;
            this.btnRanura1.Visible = true;
            this.btnRanura2.Visible = true;
            this.btnRanura3.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load = true;
            this.btnCargar.BackColor = Color.White;
            this.btnNueva.BackColor = Color.DeepSkyBlue;
            this.btnRanura1.Visible = true;
            this.btnRanura2.Visible = true;
            this.btnRanura3.Visible = true;
        }
    }
}
