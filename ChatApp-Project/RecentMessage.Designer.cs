namespace ChatApp_Project
{
    partial class RecentMessage
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
            this.lblRecentMessage = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblDateSent = new System.Windows.Forms.Label();
            this.lblTimeSent = new System.Windows.Forms.Label();
            this.chatRefresher = new System.Windows.Forms.Timer(this.components);
            this.statusNotif = new Guna.UI2.WinForms.Guna2Panel();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecentMessage
            // 
            this.lblRecentMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecentMessage.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblRecentMessage.Location = new System.Drawing.Point(101, 37);
            this.lblRecentMessage.Name = "lblRecentMessage";
            this.lblRecentMessage.Size = new System.Drawing.Size(345, 28);
            this.lblRecentMessage.TabIndex = 5;
            this.lblRecentMessage.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblUserName.Location = new System.Drawing.Point(101, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(345, 28);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "label1";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblDateSent
            // 
            this.lblDateSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDateSent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSent.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateSent.Location = new System.Drawing.Point(102, 65);
            this.lblDateSent.Name = "lblDateSent";
            this.lblDateSent.Size = new System.Drawing.Size(195, 20);
            this.lblDateSent.TabIndex = 6;
            this.lblDateSent.Text = "label1";
            // 
            // lblTimeSent
            // 
            this.lblTimeSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeSent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSent.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimeSent.Location = new System.Drawing.Point(303, 65);
            this.lblTimeSent.Name = "lblTimeSent";
            this.lblTimeSent.Size = new System.Drawing.Size(195, 20);
            this.lblTimeSent.TabIndex = 7;
            this.lblTimeSent.Text = "label2";
            // 
            // chatRefresher
            // 
            this.chatRefresher.Tick += new System.EventHandler(this.chatRefresher_Tick);
            // 
            // statusNotif
            // 
            this.statusNotif.BorderRadius = 10;
            this.statusNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusNotif.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.statusNotif.Location = new System.Drawing.Point(468, 35);
            this.statusNotif.Name = "statusNotif";
            this.statusNotif.Size = new System.Drawing.Size(20, 20);
            this.statusNotif.TabIndex = 8;
            this.statusNotif.Visible = false;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userImage.FillColor = System.Drawing.Color.Transparent;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(15, 5);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(80, 80);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 4;
            this.userImage.TabStop = false;
            this.userImage.UseTransparentBackground = true;
            // 
            // RecentMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusNotif);
            this.Controls.Add(this.lblTimeSent);
            this.Controls.Add(this.lblDateSent);
            this.Controls.Add(this.lblRecentMessage);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.lblUserName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "RecentMessage";
            this.Size = new System.Drawing.Size(524, 91);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRecentMessage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblTimeSent;
        private System.Windows.Forms.Label lblDateSent;
        private System.Windows.Forms.Timer chatRefresher;
        private Guna.UI2.WinForms.Guna2Panel statusNotif;
    }
}
