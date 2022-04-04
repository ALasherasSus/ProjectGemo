
namespace GemoTale
{
    partial class Vista_Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Estadisticas));
            this.go_back = new System.Windows.Forms.PictureBox();
            this.lblVida = new System.Windows.Forms.Label();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.pbVidaMaxima = new System.Windows.Forms.ProgressBar();
            this.lblVidaMaxima = new System.Windows.Forms.Label();
            this.pbAtaque = new System.Windows.Forms.ProgressBar();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.pbDefensa = new System.Windows.Forms.ProgressBar();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.tbDinero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).BeginInit();
            this.SuspendLayout();
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back.Image = ((System.Drawing.Image)(resources.GetObject("go_back.Image")));
            this.go_back.Location = new System.Drawing.Point(532, 329);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(80, 100);
            this.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.go_back.TabIndex = 6;
            this.go_back.TabStop = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(28, 126);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(77, 27);
            this.lblVida.TabIndex = 7;
            this.lblVida.Text = "Vida:";
            // 
            // pbVida
            // 
            this.pbVida.BackColor = System.Drawing.Color.Red;
            this.pbVida.ForeColor = System.Drawing.Color.Lime;
            this.pbVida.Location = new System.Drawing.Point(33, 156);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(256, 23);
            this.pbVida.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVida.TabIndex = 8;
            this.pbVida.Value = 100;
            // 
            // pbVidaMaxima
            // 
            this.pbVidaMaxima.BackColor = System.Drawing.Color.Red;
            this.pbVidaMaxima.ForeColor = System.Drawing.Color.Lime;
            this.pbVidaMaxima.Location = new System.Drawing.Point(33, 212);
            this.pbVidaMaxima.Maximum = 650;
            this.pbVidaMaxima.Name = "pbVidaMaxima";
            this.pbVidaMaxima.Size = new System.Drawing.Size(256, 23);
            this.pbVidaMaxima.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVidaMaxima.TabIndex = 10;
            this.pbVidaMaxima.Value = 100;
            // 
            // lblVidaMaxima
            // 
            this.lblVidaMaxima.AutoSize = true;
            this.lblVidaMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaMaxima.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaMaxima.Location = new System.Drawing.Point(28, 182);
            this.lblVidaMaxima.Name = "lblVidaMaxima";
            this.lblVidaMaxima.Size = new System.Drawing.Size(178, 27);
            this.lblVidaMaxima.TabIndex = 9;
            this.lblVidaMaxima.Text = "Vida Máxima:";
            // 
            // pbAtaque
            // 
            this.pbAtaque.BackColor = System.Drawing.Color.Red;
            this.pbAtaque.ForeColor = System.Drawing.Color.Lime;
            this.pbAtaque.Location = new System.Drawing.Point(33, 268);
            this.pbAtaque.Maximum = 300;
            this.pbAtaque.Name = "pbAtaque";
            this.pbAtaque.Size = new System.Drawing.Size(256, 23);
            this.pbAtaque.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbAtaque.TabIndex = 12;
            this.pbAtaque.Value = 20;
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.BackColor = System.Drawing.Color.Transparent;
            this.lblAtaque.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.Location = new System.Drawing.Point(28, 238);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(109, 27);
            this.lblAtaque.TabIndex = 11;
            this.lblAtaque.Text = "Ataque:";
            // 
            // pbDefensa
            // 
            this.pbDefensa.BackColor = System.Drawing.Color.Red;
            this.pbDefensa.ForeColor = System.Drawing.Color.Lime;
            this.pbDefensa.Location = new System.Drawing.Point(33, 324);
            this.pbDefensa.Maximum = 9;
            this.pbDefensa.Name = "pbDefensa";
            this.pbDefensa.Size = new System.Drawing.Size(256, 23);
            this.pbDefensa.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDefensa.TabIndex = 14;
            // 
            // lblDefensa
            // 
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.BackColor = System.Drawing.Color.Transparent;
            this.lblDefensa.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensa.Location = new System.Drawing.Point(28, 294);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new System.Drawing.Size(115, 27);
            this.lblDefensa.TabIndex = 13;
            this.lblDefensa.Text = "Defensa:";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.BackColor = System.Drawing.Color.Transparent;
            this.lblDinero.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(28, 350);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(103, 27);
            this.lblDinero.TabIndex = 15;
            this.lblDinero.Text = "Dinero:";
            // 
            // tbDinero
            // 
            this.tbDinero.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDinero.Enabled = false;
            this.tbDinero.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDinero.Location = new System.Drawing.Point(33, 381);
            this.tbDinero.Name = "tbDinero";
            this.tbDinero.ReadOnly = true;
            this.tbDinero.Size = new System.Drawing.Size(256, 26);
            this.tbDinero.TabIndex = 16;
            this.tbDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vista_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tbDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.pbDefensa);
            this.Controls.Add(this.lblDefensa);
            this.Controls.Add(this.pbAtaque);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.pbVidaMaxima);
            this.Controls.Add(this.lblVidaMaxima);
            this.Controls.Add(this.pbVida);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.go_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Estadisticas";
            this.Text = "Crash Bandicoot RPG - Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox go_back;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.ProgressBar pbVidaMaxima;
        private System.Windows.Forms.Label lblVidaMaxima;
        private System.Windows.Forms.ProgressBar pbAtaque;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.ProgressBar pbDefensa;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.TextBox tbDinero;
    }
}