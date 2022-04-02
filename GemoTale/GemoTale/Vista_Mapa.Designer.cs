
namespace GemoTale
{
    partial class Vista_Mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Mapa));
            this.player = new System.Windows.Forms.PictureBox();
            this.arrow_top = new System.Windows.Forms.PictureBox();
            this.arrow_bottom = new System.Windows.Forms.PictureBox();
            this.arrow_left = new System.Windows.Forms.PictureBox();
            this.arrow_right = new System.Windows.Forms.PictureBox();
            this.shop_right = new System.Windows.Forms.PictureBox();
            this.shop_left = new System.Windows.Forms.PictureBox();
            this.checkpoint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.ImageLocation = "";
            this.player.Location = new System.Drawing.Point(250, 158);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(125, 125);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // arrow_top
            // 
            this.arrow_top.BackColor = System.Drawing.Color.Transparent;
            this.arrow_top.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.arrow_top.Image = ((System.Drawing.Image)(resources.GetObject("arrow_top.Image")));
            this.arrow_top.Location = new System.Drawing.Point(262, 12);
            this.arrow_top.Name = "arrow_top";
            this.arrow_top.Size = new System.Drawing.Size(100, 80);
            this.arrow_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow_top.TabIndex = 1;
            this.arrow_top.TabStop = false;
            this.arrow_top.Click += new System.EventHandler(this.arrow_top_Click);
            // 
            // arrow_bottom
            // 
            this.arrow_bottom.BackColor = System.Drawing.Color.Transparent;
            this.arrow_bottom.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.arrow_bottom.Image = ((System.Drawing.Image)(resources.GetObject("arrow_bottom.Image")));
            this.arrow_bottom.Location = new System.Drawing.Point(262, 349);
            this.arrow_bottom.Name = "arrow_bottom";
            this.arrow_bottom.Size = new System.Drawing.Size(100, 80);
            this.arrow_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow_bottom.TabIndex = 2;
            this.arrow_bottom.TabStop = false;
            this.arrow_bottom.Click += new System.EventHandler(this.arrow_bottom_Click);
            // 
            // arrow_left
            // 
            this.arrow_left.BackColor = System.Drawing.Color.Transparent;
            this.arrow_left.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.arrow_left.Image = ((System.Drawing.Image)(resources.GetObject("arrow_left.Image")));
            this.arrow_left.Location = new System.Drawing.Point(12, 170);
            this.arrow_left.Name = "arrow_left";
            this.arrow_left.Size = new System.Drawing.Size(80, 100);
            this.arrow_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow_left.TabIndex = 3;
            this.arrow_left.TabStop = false;
            this.arrow_left.Click += new System.EventHandler(this.arrow_left_Click);
            // 
            // arrow_right
            // 
            this.arrow_right.BackColor = System.Drawing.Color.Transparent;
            this.arrow_right.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.arrow_right.Image = ((System.Drawing.Image)(resources.GetObject("arrow_right.Image")));
            this.arrow_right.Location = new System.Drawing.Point(532, 170);
            this.arrow_right.Name = "arrow_right";
            this.arrow_right.Size = new System.Drawing.Size(80, 100);
            this.arrow_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow_right.TabIndex = 4;
            this.arrow_right.TabStop = false;
            this.arrow_right.Click += new System.EventHandler(this.arrow_right_Click);
            // 
            // shop_right
            // 
            this.shop_right.BackColor = System.Drawing.Color.Transparent;
            this.shop_right.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.shop_right.Image = ((System.Drawing.Image)(resources.GetObject("shop_right.Image")));
            this.shop_right.Location = new System.Drawing.Point(532, 170);
            this.shop_right.Name = "shop_right";
            this.shop_right.Size = new System.Drawing.Size(80, 100);
            this.shop_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shop_right.TabIndex = 5;
            this.shop_right.TabStop = false;
            this.shop_right.Click += new System.EventHandler(this.shop_right_Click);
            // 
            // shop_left
            // 
            this.shop_left.BackColor = System.Drawing.Color.Transparent;
            this.shop_left.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.shop_left.Image = ((System.Drawing.Image)(resources.GetObject("shop_left.Image")));
            this.shop_left.Location = new System.Drawing.Point(12, 170);
            this.shop_left.Name = "shop_left";
            this.shop_left.Size = new System.Drawing.Size(80, 100);
            this.shop_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shop_left.TabIndex = 6;
            this.shop_left.TabStop = false;
            this.shop_left.Click += new System.EventHandler(this.shop_left_Click);
            // 
            // checkpoint
            // 
            this.checkpoint.BackColor = System.Drawing.Color.Transparent;
            this.checkpoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkpoint.Image = ((System.Drawing.Image)(resources.GetObject("checkpoint.Image")));
            this.checkpoint.Location = new System.Drawing.Point(515, 349);
            this.checkpoint.Name = "checkpoint";
            this.checkpoint.Size = new System.Drawing.Size(97, 80);
            this.checkpoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkpoint.TabIndex = 7;
            this.checkpoint.TabStop = false;
            this.checkpoint.Click += new System.EventHandler(this.checkpoint_Click);
            // 
            // Vista_Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.checkpoint);
            this.Controls.Add(this.arrow_bottom);
            this.Controls.Add(this.arrow_top);
            this.Controls.Add(this.player);
            this.Controls.Add(this.shop_left);
            this.Controls.Add(this.shop_right);
            this.Controls.Add(this.arrow_right);
            this.Controls.Add(this.arrow_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Mapa";
            this.Text = "Gemo\'s Tale - Mapa";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkpoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox arrow_top;
        private System.Windows.Forms.PictureBox arrow_bottom;
        private System.Windows.Forms.PictureBox arrow_left;
        private System.Windows.Forms.PictureBox arrow_right;
        private System.Windows.Forms.PictureBox shop_right;
        private System.Windows.Forms.PictureBox shop_left;
        private System.Windows.Forms.PictureBox checkpoint;
    }
}