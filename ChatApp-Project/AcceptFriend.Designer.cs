namespace ChatApp_Project
{
    partial class AcceptFriend
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptFriend));
            this.header = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.userContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.header.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.btnBack);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(592, 69);
            this.header.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(5, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friend Requests";
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.guna2VSeparator1);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(304, 69);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(288, 408);
            this.profilePanel.TabIndex = 4;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.Location = new System.Drawing.Point(0, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(1, 408);
            this.guna2VSeparator1.TabIndex = 1;
            // 
            // userContainer
            // 
            this.userContainer.AutoScroll = true;
            this.userContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.userContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userContainer.Location = new System.Drawing.Point(0, 69);
            this.userContainer.Name = "userContainer";
            this.userContainer.Size = new System.Drawing.Size(304, 408);
            this.userContainer.TabIndex = 3;
            this.userContainer.WrapContents = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // AcceptFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 477);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.userContainer);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcceptFriend";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel profilePanel;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.FlowLayoutPanel userContainer;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}