namespace ChatApp_Project
{
    partial class SocialsFriendSuggestions
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
            this.availableUsersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkClose = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // availableUsersContainer
            // 
            this.availableUsersContainer.AutoScroll = true;
            this.availableUsersContainer.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.availableUsersContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.availableUsersContainer.Location = new System.Drawing.Point(0, 63);
            this.availableUsersContainer.Name = "availableUsersContainer";
            this.availableUsersContainer.Size = new System.Drawing.Size(530, 486);
            this.availableUsersContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 63);
            this.panel1.TabIndex = 1;
            // 
            // linkClose
            // 
            this.linkClose.AutoSize = true;
            this.linkClose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkClose.Location = new System.Drawing.Point(70, 35);
            this.linkClose.Name = "linkClose";
            this.linkClose.Size = new System.Drawing.Size(93, 17);
            this.linkClose.TabIndex = 24;
            this.linkClose.TabStop = true;
            this.linkClose.Text = "Close Window";
            this.linkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClose_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(65, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Friends Suggestion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatApp_Project.Properties.Resources.user_add;
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // SocialsFriendSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.availableUsersContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SocialsFriendSuggestion";
            this.Size = new System.Drawing.Size(530, 549);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel availableUsersContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkClose;
    }
}
