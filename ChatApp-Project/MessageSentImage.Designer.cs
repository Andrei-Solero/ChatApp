namespace ChatApp_Project
{
    partial class MessageSentImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.sentImage = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Controls.Add(this.sentImage);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(500, 364);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // sentImage
            // 
            this.sentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.sentImage.Location = new System.Drawing.Point(186, 10);
            this.sentImage.Name = "sentImage";
            this.sentImage.Size = new System.Drawing.Size(308, 344);
            this.sentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sentImage.TabIndex = 0;
            this.sentImage.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.sentImage;
            // 
            // MessageSentImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "MessageSentImage";
            this.Size = new System.Drawing.Size(500, 364);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox sentImage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
