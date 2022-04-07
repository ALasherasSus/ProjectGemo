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
    public partial class Vista_Combate : Form
    {
        public Vista_Combate()
        {
            InitializeComponent();

            //BURBUJAS DE INFORMACIÓN
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.go_back, "Huye del combate asumiendo el daño recibido.");
            toolTip1.SetToolTip(this.btnAtacar, "Ataca al enemigo.");
            toolTip1.SetToolTip(this.btnEsquivar, "Esquiva el ataque sufriendo la mitad de daño\ny recupera algo de energia.");
            toolTip1.SetToolTip(this.pbEnemigo, "La salud del enemigo.");
            toolTip1.SetToolTip(this.pbJugador, "Tu propia salud.");
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sounds/SFX/door_close.wav");
            player.Play();
            this.Close();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {

        }

        private void btnEsquivar_Click(object sender, EventArgs e)
        {

        }
    }
}
