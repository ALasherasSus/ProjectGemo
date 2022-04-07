
namespace GemoTale
{
    partial class Vista_Combate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Combate));
            this.player_combat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreEnemigo = new System.Windows.Forms.Label();
            this.pbEnemigo = new System.Windows.Forms.ProgressBar();
            this.pbJugador = new System.Windows.Forms.ProgressBar();
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnEsquivar = new System.Windows.Forms.Button();
            this.go_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player_combat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).BeginInit();
            this.SuspendLayout();
            // 
            // player_combat
            // 
            this.player_combat.BackColor = System.Drawing.Color.Transparent;
            this.player_combat.Image = ((System.Drawing.Image)(resources.GetObject("player_combat.Image")));
            this.player_combat.Location = new System.Drawing.Point(12, 211);
            this.player_combat.Name = "player_combat";
            this.player_combat.Size = new System.Drawing.Size(290, 335);
            this.player_combat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_combat.TabIndex = 0;
            this.player_combat.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreEnemigo
            // 
            this.lblNombreEnemigo.AutoSize = true;
            this.lblNombreEnemigo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEnemigo.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.lblNombreEnemigo.Location = new System.Drawing.Point(12, 14);
            this.lblNombreEnemigo.Name = "lblNombreEnemigo";
            this.lblNombreEnemigo.Size = new System.Drawing.Size(198, 39);
            this.lblNombreEnemigo.TabIndex = 2;
            this.lblNombreEnemigo.Text = "Tiny Tiger";
            // 
            // pbEnemigo
            // 
            this.pbEnemigo.ForeColor = System.Drawing.Color.Lime;
            this.pbEnemigo.Location = new System.Drawing.Point(12, 56);
            this.pbEnemigo.Name = "pbEnemigo";
            this.pbEnemigo.Size = new System.Drawing.Size(290, 23);
            this.pbEnemigo.TabIndex = 3;
            // 
            // pbJugador
            // 
            this.pbJugador.ForeColor = System.Drawing.Color.Lime;
            this.pbJugador.Location = new System.Drawing.Point(312, 300);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(300, 23);
            this.pbJugador.TabIndex = 4;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.lblJugador.Location = new System.Drawing.Point(312, 258);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(300, 39);
            this.lblJugador.TabIndex = 5;
            this.lblJugador.Text = "Crash Bandicoot";
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtacar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtacar.FlatAppearance.BorderSize = 2;
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.btnAtacar.ForeColor = System.Drawing.Color.Black;
            this.btnAtacar.Location = new System.Drawing.Point(312, 329);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(163, 46);
            this.btnAtacar.TabIndex = 6;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnEsquivar
            // 
            this.btnEsquivar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEsquivar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEsquivar.FlatAppearance.BorderSize = 2;
            this.btnEsquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquivar.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.btnEsquivar.ForeColor = System.Drawing.Color.Black;
            this.btnEsquivar.Location = new System.Drawing.Point(312, 383);
            this.btnEsquivar.Name = "btnEsquivar";
            this.btnEsquivar.Size = new System.Drawing.Size(163, 46);
            this.btnEsquivar.TabIndex = 7;
            this.btnEsquivar.Text = "Esquivar";
            this.btnEsquivar.UseVisualStyleBackColor = false;
            this.btnEsquivar.Click += new System.EventHandler(this.btnEsquivar_Click);
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back.Image = ((System.Drawing.Image)(resources.GetObject("go_back.Image")));
            this.go_back.Location = new System.Drawing.Point(481, 329);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(131, 100);
            this.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.go_back.TabIndex = 8;
            this.go_back.TabStop = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // Vista_Combate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.btnEsquivar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.pbJugador);
            this.Controls.Add(this.pbEnemigo);
            this.Controls.Add(this.lblNombreEnemigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player_combat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Combate";
            this.Text = "Crash Bandicoot RPG - Combate";
            ((System.ComponentModel.ISupportInitialize)(this.player_combat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player_combat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreEnemigo;
        private System.Windows.Forms.ProgressBar pbEnemigo;
        private System.Windows.Forms.ProgressBar pbJugador;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnEsquivar;
        private System.Windows.Forms.PictureBox go_back;
    }
}