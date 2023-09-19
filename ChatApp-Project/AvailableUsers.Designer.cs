namespace ChatApp_Project
{
    partial class AvailableUsers
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAddFriend = new Guna.UI2.WinForms.Guna2Button();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblUserName
            // 
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(89, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 21);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "label1";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Click += new System.EventHandler(this.SendData_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BorderRadius = 5;
            this.btnAddFriend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFriend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFriend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFriend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddFriend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.White;
            this.btnAddFriend.Image = global::ChatApp_Project.Properties.Resources.add;
            this.btnAddFriend.Location = new System.Drawing.Point(92, 31);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(152, 44);
            this.btnAddFriend.TabIndex = 10;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userImage.FillColor = System.Drawing.Color.Transparent;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(18, 11);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(63, 60);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 9;
            this.userImage.TabStop = false;
            this.userImage.UseTransparentBackground = true;
            // 
            // AvailableUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.lblUserName);
            this.Name = "AvailableUsers";
            this.Size = new System.Drawing.Size(296, 83);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnAddFriend;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
