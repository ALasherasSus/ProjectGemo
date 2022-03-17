
namespace GemoTale
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.gameLogo = new System.Windows.Forms.PictureBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnRanura1 = new System.Windows.Forms.Button();
            this.btnRanura2 = new System.Windows.Forms.Button();
            this.btnRanura3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLogo
            // 
            this.gameLogo.BackColor = System.Drawing.Color.Transparent;
            this.gameLogo.Image = ((System.Drawing.Image)(resources.GetObject("gameLogo.Image")));
            this.gameLogo.Location = new System.Drawing.Point(12, 12);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(600, 240);
            this.gameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameLogo.TabIndex = 0;
            this.gameLogo.TabStop = false;
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNueva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNueva.FlatAppearance.BorderSize = 2;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.Location = new System.Drawing.Point(12, 258);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(600, 50);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva Partida";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargar.FlatAppearance.BorderSize = 2;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(12, 314);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(600, 50);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Partida";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRanura1
            // 
            this.btnRanura1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRanura1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRanura1.FlatAppearance.BorderSize = 2;
            this.btnRanura1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanura1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanura1.ForeColor = System.Drawing.Color.Black;
            this.btnRanura1.Location = new System.Drawing.Point(12, 370);
            this.btnRanura1.Name = "btnRanura1";
            this.btnRanura1.Size = new System.Drawing.Size(190, 59);
            this.btnRanura1.TabIndex = 3;
            this.btnRanura1.Text = "0%";
            this.btnRanura1.UseVisualStyleBackColor = false;
            // 
            // btnRanura2
            // 
            this.btnRanura2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRanura2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRanura2.FlatAppearance.BorderSize = 2;
            this.btnRanura2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanura2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanura2.ForeColor = System.Drawing.Color.Black;
            this.btnRanura2.Location = new System.Drawing.Point(217, 370);
            this.btnRanura2.Name = "btnRanura2";
            this.btnRanura2.Size = new System.Drawing.Size(190, 59);
            this.btnRanura2.TabIndex = 4;
            this.btnRanura2.Text = "0%";
            this.btnRanura2.UseVisualStyleBackColor = false;
            // 
            // btnRanura3
            // 
            this.btnRanura3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRanura3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRanura3.FlatAppearance.BorderSize = 2;
            this.btnRanura3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanura3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanura3.ForeColor = System.Drawing.Color.Black;
            this.btnRanura3.Location = new System.Drawing.Point(422, 370);
            this.btnRanura3.Name = "btnRanura3";
            this.btnRanura3.Size = new System.Drawing.Size(190, 59);
            this.btnRanura3.TabIndex = 5;
            this.btnRanura3.Text = "0%";
            this.btnRanura3.UseVisualStyleBackColor = false;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnRanura3);
            this.Controls.Add(this.btnRanura2);
            this.Controls.Add(this.btnRanura1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.gameLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu_Principal";
            this.Text = "Gemo";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLogo;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnRanura1;
        private System.Windows.Forms.Button btnRanura2;
        private System.Windows.Forms.Button btnRanura3;
    }
}

