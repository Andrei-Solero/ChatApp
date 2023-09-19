namespace ChatApp_Project
{
    partial class SocialInfoFriendSuggestions
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
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblBio = new System.Windows.Forms.Label();
            this.btnAddFriend = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.FillColor = System.Drawing.Color.Transparent;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(59, 3);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(114, 107);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(3, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(227, 35);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblBio
            // 
            this.lblBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBio.Location = new System.Drawing.Point(3, 148);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(227, 48);
            this.lblBio.TabIndex = 10;
            this.lblBio.Text = "label1";
            this.lblBio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BorderRadius = 5;
            this.btnAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFriend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFriend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFriend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddFriend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.White;
            this.btnAddFriend.Image = global::ChatApp_Project.Properties.Resources.add;
            this.btnAddFriend.Location = new System.Drawing.Point(22, 199);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(188, 38);
            this.btnAddFriend.TabIndex = 11;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // SocialInfoFriendSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.userImage);
            this.Margin = new System.Windows.Forms.Padding(15, 5, 7, 5);
            this.Name = "SocialInfoFriendSuggestions";
            this.Size = new System.Drawing.Size(230, 269);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblBio;
        private Guna.UI2.WinForms.Guna2Button btnAddFriend;
    }
}
