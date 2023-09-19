namespace ChatApp_Project
{
    partial class SocialInfoFriendRequests
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblName
            // 
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(2, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(227, 32);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.FillColor = System.Drawing.Color.Transparent;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(58, 17);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(114, 107);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 12;
            this.userImage.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BorderRadius = 5;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Image = global::ChatApp_Project.Properties.Resources.comment_check;
            this.btnAccept.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnAccept.Location = new System.Drawing.Point(12, 167);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(206, 53);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Accept Requests";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // SocialInfoFriendRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.btnAccept);
            this.Name = "SocialInfoFriendRequests";
            this.Size = new System.Drawing.Size(230, 269);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
    }
}
