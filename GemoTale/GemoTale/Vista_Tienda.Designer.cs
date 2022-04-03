
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
            this.shopper = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
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
            // shopper
            // 
            this.shopper.BackColor = System.Drawing.Color.Transparent;
            this.shopper.Image = ((System.Drawing.Image)(resources.GetObject("shopper.Image")));
            this.shopper.Location = new System.Drawing.Point(12, 96);
            this.shopper.Name = "shopper";
            this.shopper.Size = new System.Drawing.Size(280, 462);
            this.shopper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopper.TabIndex = 6;
            this.shopper.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(12, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(600, 92);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.title.TabIndex = 7;
            this.title.TabStop = false;
            // 
            // Vista_Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.shopper);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Tienda";
            this.Text = "Crash Bandicoot RPG - Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox go_back;
        private System.Windows.Forms.PictureBox shopper;
        private System.Windows.Forms.PictureBox title;
    }
}