
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
            this.gameLogo = new System.Windows.Forms.PictureBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnRanura1 = new System.Windows.Forms.Button();
            this.btnRanura2 = new System.Windows.Forms.Button();
            this.btnRanura3 = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.cheatBox = new System.Windows.Forms.TextBox();
            this.manual = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLogo
            // 
            this.gameLogo.BackColor = System.Drawing.Color.Transparent;
            this.gameLogo.Image = global::GemoTale.Properties.UI.game_logo;
            this.gameLogo.Location = new System.Drawing.Point(12, 12);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(920, 480);
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
            this.btnNueva.Location = new System.Drawing.Point(12, 498);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(920, 50);
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
            this.btnCargar.Location = new System.Drawing.Point(12, 554);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(920, 50);
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
            this.btnRanura1.Location = new System.Drawing.Point(12, 610);
            this.btnRanura1.Name = "btnRanura1";
            this.btnRanura1.Size = new System.Drawing.Size(304, 59);
            this.btnRanura1.TabIndex = 3;
            this.btnRanura1.Text = "Ranura 1";
            this.btnRanura1.UseVisualStyleBackColor = false;
            this.btnRanura1.Click += new System.EventHandler(this.btnRanura1_Click);
            // 
            // btnRanura2
            // 
            this.btnRanura2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRanura2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRanura2.FlatAppearance.BorderSize = 2;
            this.btnRanura2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanura2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanura2.ForeColor = System.Drawing.Color.Black;
            this.btnRanura2.Location = new System.Drawing.Point(320, 610);
            this.btnRanura2.Name = "btnRanura2";
            this.btnRanura2.Size = new System.Drawing.Size(304, 59);
            this.btnRanura2.TabIndex = 4;
            this.btnRanura2.Text = "Ranura 2";
            this.btnRanura2.UseVisualStyleBackColor = false;
            this.btnRanura2.Click += new System.EventHandler(this.btnRanura2_Click);
            // 
            // btnRanura3
            // 
            this.btnRanura3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRanura3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRanura3.FlatAppearance.BorderSize = 2;
            this.btnRanura3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanura3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanura3.ForeColor = System.Drawing.Color.Black;
            this.btnRanura3.Location = new System.Drawing.Point(628, 610);
            this.btnRanura3.Name = "btnRanura3";
            this.btnRanura3.Size = new System.Drawing.Size(304, 59);
            this.btnRanura3.TabIndex = 5;
            this.btnRanura3.Text = "Ranura 3";
            this.btnRanura3.UseVisualStyleBackColor = false;
            this.btnRanura3.Click += new System.EventHandler(this.btnRanura3_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.BackColor = System.Drawing.Color.Transparent;
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.Location = new System.Drawing.Point(0, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(149, 24);
            this.lblDebug.TabIndex = 9;
            this.lblDebug.Text = "MODO DEBUG";
            this.lblDebug.Visible = false;
            // 
            // cheatBox
            // 
            this.cheatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cheatBox.Location = new System.Drawing.Point(844, 0);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(100, 20);
            this.cheatBox.TabIndex = 10;
            this.cheatBox.Visible = false;
            this.cheatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cheatBox_KeyDown);
            // 
            // manual
            // 
            this.manual.BackColor = System.Drawing.Color.Transparent;
            this.manual.Cursor = System.Windows.Forms.Cursors.Help;
            this.manual.Image = global::GemoTale.Properties.UI.manual;
            this.manual.Location = new System.Drawing.Point(12, 27);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(158, 193);
            this.manual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manual.TabIndex = 11;
            this.manual.TabStop = false;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            this.manual.MouseLeave += new System.EventHandler(this.manual_MouseLeave);
            this.manual.MouseHover += new System.EventHandler(this.manual_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test Cinemática";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GemoTale.Properties.Backgrounds.mainmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.cheatBox);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnRanura3);
            this.Controls.Add(this.btnRanura2);
            this.Controls.Add(this.btnRanura1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.gameLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.Text = "Crash Bandicoot RPG";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_Principal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameLogo;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnRanura1;
        private System.Windows.Forms.Button btnRanura2;
        private System.Windows.Forms.Button btnRanura3;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.TextBox cheatBox;
        private System.Windows.Forms.PictureBox manual;
        private System.Windows.Forms.Button button1;
    }
}

