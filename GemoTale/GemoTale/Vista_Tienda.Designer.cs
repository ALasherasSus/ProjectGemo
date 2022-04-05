
namespace GemoTale
{
    partial class Vista_Tienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Tienda));
            this.go_back = new System.Windows.Forms.PictureBox();
            this.tbDinero = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.pbDefensa = new System.Windows.Forms.ProgressBar();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.pbAtaque = new System.Windows.Forms.ProgressBar();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.pbVidaMaxima = new System.Windows.Forms.ProgressBar();
            this.lblVidaMaxima = new System.Windows.Forms.Label();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.lblVida = new System.Windows.Forms.Label();
            this.btnVida = new System.Windows.Forms.Button();
            this.btnVidaMaxima = new System.Windows.Forms.Button();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.btnDefensa = new System.Windows.Forms.Button();
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
            this.go_back.TabIndex = 5;
            this.go_back.TabStop = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
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
            this.tbDinero.TabIndex = 26;
            this.tbDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.BackColor = System.Drawing.Color.Transparent;
            this.lblDinero.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(28, 350);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(103, 27);
            this.lblDinero.TabIndex = 25;
            this.lblDinero.Text = "Dinero:";
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
            this.pbDefensa.TabIndex = 24;
            // 
            // lblDefensa
            // 
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.BackColor = System.Drawing.Color.Transparent;
            this.lblDefensa.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensa.Location = new System.Drawing.Point(28, 294);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new System.Drawing.Size(115, 27);
            this.lblDefensa.TabIndex = 23;
            this.lblDefensa.Text = "Defensa:";
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
            this.pbAtaque.TabIndex = 22;
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
            this.lblAtaque.TabIndex = 21;
            this.lblAtaque.Text = "Ataque:";
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
            this.pbVidaMaxima.TabIndex = 20;
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
            this.lblVidaMaxima.TabIndex = 19;
            this.lblVidaMaxima.Text = "Vida Máxima:";
            // 
            // pbVida
            // 
            this.pbVida.BackColor = System.Drawing.Color.Red;
            this.pbVida.ForeColor = System.Drawing.Color.Lime;
            this.pbVida.Location = new System.Drawing.Point(33, 156);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(256, 23);
            this.pbVida.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVida.TabIndex = 18;
            this.pbVida.Value = 100;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(28, 126);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(77, 27);
            this.lblVida.TabIndex = 17;
            this.lblVida.Text = "Vida:";
            // 
            // btnVida
            // 
            this.btnVida.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVida.Location = new System.Drawing.Point(214, 130);
            this.btnVida.Name = "btnVida";
            this.btnVida.Size = new System.Drawing.Size(75, 23);
            this.btnVida.TabIndex = 27;
            this.btnVida.Text = "10";
            this.btnVida.UseVisualStyleBackColor = true;
            this.btnVida.Click += new System.EventHandler(this.btnVida_Click);
            // 
            // btnVidaMaxima
            // 
            this.btnVidaMaxima.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnVidaMaxima.Location = new System.Drawing.Point(214, 186);
            this.btnVidaMaxima.Name = "btnVidaMaxima";
            this.btnVidaMaxima.Size = new System.Drawing.Size(75, 23);
            this.btnVidaMaxima.TabIndex = 28;
            this.btnVidaMaxima.Text = "50";
            this.btnVidaMaxima.UseVisualStyleBackColor = true;
            this.btnVidaMaxima.Click += new System.EventHandler(this.btnVidaMaxima_Click);
            // 
            // btnAtaque
            // 
            this.btnAtaque.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnAtaque.Location = new System.Drawing.Point(214, 242);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(75, 23);
            this.btnAtaque.TabIndex = 29;
            this.btnAtaque.Text = "100";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnDefensa
            // 
            this.btnDefensa.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnDefensa.Location = new System.Drawing.Point(214, 298);
            this.btnDefensa.Name = "btnDefensa";
            this.btnDefensa.Size = new System.Drawing.Size(75, 23);
            this.btnDefensa.TabIndex = 30;
            this.btnDefensa.Text = "200";
            this.btnDefensa.UseVisualStyleBackColor = true;
            this.btnDefensa.Click += new System.EventHandler(this.btnDefensa_Click);
            // 
            // Vista_Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnDefensa);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.btnVidaMaxima);
            this.Controls.Add(this.btnVida);
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
            this.Name = "Vista_Tienda";
            this.Text = "Crash Bandicoot RPG - Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox go_back;
        private System.Windows.Forms.TextBox tbDinero;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.ProgressBar pbDefensa;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.ProgressBar pbAtaque;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.ProgressBar pbVidaMaxima;
        private System.Windows.Forms.Label lblVidaMaxima;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnVida;
        private System.Windows.Forms.Button btnVidaMaxima;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button btnDefensa;
    }
}