
namespace GemoTale
{
    partial class Vista_Muerte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.continuar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.continuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.SuspendLayout();
            // 
            // continuar
            // 
            this.continuar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.continuar.BackColor = System.Drawing.Color.Transparent;
            this.continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuar.Image = global::GemoTale.Properties.UI._continue;
            this.continuar.Location = new System.Drawing.Point(93, 212);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(330, 67);
            this.continuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.continuar.TabIndex = 6;
            this.continuar.TabStop = false;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = global::GemoTale.Properties.UI.exit;
            this.salir.Location = new System.Drawing.Point(651, 212);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(180, 67);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salir.TabIndex = 7;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Vista_Muerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GemoTale.Properties.Backgrounds.gameOver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.ControlBox = false;
            this.Controls.Add(this.salir);
            this.Controls.Add(this.continuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Muerte";
            this.Text = "Crash Bandicoot RPG - Fin de la Partida";
            ((System.ComponentModel.ISupportInitialize)(this.continuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox continuar;
        private System.Windows.Forms.PictureBox salir;
    }
}