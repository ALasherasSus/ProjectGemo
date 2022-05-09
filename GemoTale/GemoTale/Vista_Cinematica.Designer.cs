
namespace GemoTale
{
    partial class Vista_Cinematica
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
            this.go_back = new System.Windows.Forms.PictureBox();
            this.animatedScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // go_back
            // 
            this.go_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back.Image = global::GemoTale.Properties.UI.control1;
            this.go_back.Location = new System.Drawing.Point(636, 533);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(309, 147);
            this.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.go_back.TabIndex = 7;
            this.go_back.TabStop = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            this.go_back.MouseLeave += new System.EventHandler(this.go_back_MouseLeave);
            this.go_back.MouseHover += new System.EventHandler(this.go_back_MouseHover);
            // 
            // animatedScreen
            // 
            this.animatedScreen.Image = global::GemoTale.Properties.Backgrounds.cutscene;
            this.animatedScreen.Location = new System.Drawing.Point(0, 0);
            this.animatedScreen.Name = "animatedScreen";
            this.animatedScreen.Size = new System.Drawing.Size(945, 682);
            this.animatedScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animatedScreen.TabIndex = 8;
            this.animatedScreen.TabStop = false;
            // 
            // Vista_Cinematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GemoTale.Properties.Backgrounds.cutscene;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.ControlBox = false;
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.animatedScreen);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Vista_Cinematica";
            this.Text = "Crash Bandicoot RPG - Cinemática";
            ((System.ComponentModel.ISupportInitialize)(this.go_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox go_back;
        private System.Windows.Forms.PictureBox animatedScreen;
    }
}