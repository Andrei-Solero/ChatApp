namespace ChatApp_Project
{
    partial class UserProfile
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
            this.lblName = new System.Windows.Forms.Label();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblBio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(282, 83);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.FillColor = System.Drawing.Color.Transparent;
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(61, 6);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(166, 166);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.profilePicture);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(238)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(288, 178);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // lblBio
            // 
            this.lblBio.BackColor = System.Drawing.Color.Transparent;
            this.lblBio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(3, 264);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(282, 52);
            this.lblBio.TabIndex = 3;
            this.lblBio.Text = "label1";
            this.lblBio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblName);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(288, 408);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lblBio;
    }
}
