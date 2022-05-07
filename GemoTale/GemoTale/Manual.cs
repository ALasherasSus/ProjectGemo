using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemoTale
{
    public partial class Manual : Form
    {
        private string[] pages;

        public Manual()
        {
            InitializeComponent();

            String sdira = "../../Images/Manual";

            pages = Directory.GetFiles(sdira, "*", SearchOption.AllDirectories).Where(s => (Path.GetExtension(s).ToLower() == ".jpg")).ToArray();

            this.BackgroundImage = Image.FromFile(pages[0]);
            numericUpDown1.Maximum = pages.Length;
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Image.FromFile(pages[Convert.ToInt32(numericUpDown1.Value) - 1]);
            }
            catch (Exception)
            {
                numericUpDown1.Value = 1;
            }
        }
    }
}
