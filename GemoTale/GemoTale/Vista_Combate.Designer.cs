
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
            this.player_combat = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.lblNombreEnemigo = new System.Windows.Forms.Label();
            this.pbEnemigo = new System.Windows.Forms.ProgressBar();
            this.pbJugador = new System.Windows.Forms.ProgressBar();
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnEsquivar = new System.Windows.Forms.Button();
            this.go_back = new System.Windows.Forms.PictureBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblVidaEnemigo = new System.Windows.Forms.Label();
            this.lblVidaJugador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_combat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).BeginInit();
            this.SuspendLayout();
            // 
            // player_combat
            // 
            this.player_combat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player_combat.BackColor = System.Drawing.Color.Transparent;
            this.player_combat.Image = global::GemoTale.Properties.Characters.player_combat;
            this.player_combat.Location = new System.Drawing.Point(12, 343);
            this.player_combat.Name = "player_combat";
            this.player_combat.Size = new System.Drawing.Size(435, 502);
            this.player_combat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_combat.TabIndex = 0;
            this.player_combat.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::GemoTale.Properties.Characters.boss1;
            this.enemy.Location = new System.Drawing.Point(482, 12);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(450, 320);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy.TabIndex = 1;
            this.enemy.TabStop = false;
            // 
            // lblNombreEnemigo
            // 
            this.lblNombreEnemigo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEnemigo.Font = new System.Drawing.Font("Cooper Black", 28F);
            this.lblNombreEnemigo.ForeColor = System.Drawing.Color.Red;
            this.lblNombreEnemigo.Location = new System.Drawing.Point(12, 36);
            this.lblNombreEnemigo.Name = "lblNombreEnemigo";
            this.lblNombreEnemigo.Size = new System.Drawing.Size(444, 48);
            this.lblNombreEnemigo.TabIndex = 2;
            this.lblNombreEnemigo.Text = "Tiny Tiger";
            this.lblNombreEnemigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEnemigo
            // 
            this.pbEnemigo.ForeColor = System.Drawing.Color.Lime;
            this.pbEnemigo.Location = new System.Drawing.Point(12, 87);
            this.pbEnemigo.Name = "pbEnemigo";
            this.pbEnemigo.Size = new System.Drawing.Size(445, 30);
            this.pbEnemigo.TabIndex = 3;
            // 
            // pbJugador
            // 
            this.pbJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbJugador.ForeColor = System.Drawing.Color.Lime;
            this.pbJugador.Location = new System.Drawing.Point(472, 463);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(460, 30);
            this.pbJugador.TabIndex = 4;
            // 
            // lblJugador
            // 
            this.lblJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador.Font = new System.Drawing.Font("Cooper Black", 28F);
            this.lblJugador.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblJugador.Location = new System.Drawing.Point(472, 412);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(460, 48);
            this.lblJugador.TabIndex = 5;
            this.lblJugador.Text = "Crash Bandicoot";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtacar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtacar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtacar.FlatAppearance.BorderSize = 2;
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.Black;
            this.btnAtacar.Location = new System.Drawing.Point(482, 528);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(225, 60);
            this.btnAtacar.TabIndex = 6;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnEsquivar
            // 
            this.btnEsquivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsquivar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEsquivar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEsquivar.FlatAppearance.BorderSize = 2;
            this.btnEsquivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquivar.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.btnEsquivar.ForeColor = System.Drawing.Color.Black;
            this.btnEsquivar.Location = new System.Drawing.Point(482, 602);
            this.btnEsquivar.Name = "btnEsquivar";
            this.btnEsquivar.Size = new System.Drawing.Size(225, 60);
            this.btnEsquivar.TabIndex = 7;
            this.btnEsquivar.Text = "Esquivar";
            this.btnEsquivar.UseVisualStyleBackColor = false;
            this.btnEsquivar.Click += new System.EventHandler(this.btnEsquivar_Click);
            // 
            // go_back
            // 
            this.go_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back.Image = global::GemoTale.Properties.UI.run;
            this.go_back.Location = new System.Drawing.Point(737, 519);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(195, 150);
            this.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.go_back.TabIndex = 8;
            this.go_back.TabStop = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
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
            // lblVidaEnemigo
            // 
            this.lblVidaEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaEnemigo.Location = new System.Drawing.Point(8, 153);
            this.lblVidaEnemigo.Name = "lblVidaEnemigo";
            this.lblVidaEnemigo.Size = new System.Drawing.Size(448, 23);
            this.lblVidaEnemigo.TabIndex = 10;
            this.lblVidaEnemigo.Text = "VIDA DEL ENEMIGO";
            this.lblVidaEnemigo.Visible = false;
            // 
            // lblVidaJugador
            // 
            this.lblVidaJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVidaJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaJugador.Location = new System.Drawing.Point(472, 353);
            this.lblVidaJugador.Name = "lblVidaJugador";
            this.lblVidaJugador.Size = new System.Drawing.Size(460, 24);
            this.lblVidaJugador.TabIndex = 11;
            this.lblVidaJugador.Text = "VIDA DEL JUGADOR";
            this.lblVidaJugador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVidaJugador.Visible = false;
            // 
            // Vista_Combate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GemoTale.Properties.Backgrounds.castillo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lblVidaJugador);
            this.Controls.Add(this.lblVidaEnemigo);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.btnEsquivar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.pbJugador);
            this.Controls.Add(this.pbEnemigo);
            this.Controls.Add(this.lblNombreEnemigo);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player_combat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Combate";
            this.Text = "Crash Bandicoot RPG - Combate";
            ((System.ComponentModel.ISupportInitialize)(this.player_combat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player_combat;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Label lblNombreEnemigo;
        private System.Windows.Forms.ProgressBar pbEnemigo;
        private System.Windows.Forms.ProgressBar pbJugador;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnEsquivar;
        private System.Windows.Forms.PictureBox go_back;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblVidaEnemigo;
        private System.Windows.Forms.Label lblVidaJugador;
    }
}