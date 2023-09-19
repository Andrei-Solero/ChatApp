namespace ChatApp_Project
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserFriendName = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.userFriendImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkClearImage = new System.Windows.Forms.LinkLabel();
            this.sendImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.messages = new System.Windows.Forms.FlowLayoutPanel();
            this.chatRefresher = new System.Windows.Forms.Timer(this.components);
            this.messageDataIdentifier = new System.Windows.Forms.Timer(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFriendImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lblUserFriendName);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.userFriendImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(531, 61);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(133, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Now";
            // 
            // lblUserFriendName
            // 
            this.lblUserFriendName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFriendName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblUserFriendName.Location = new System.Drawing.Point(129, 7);
            this.lblUserFriendName.Name = "lblUserFriendName";
            this.lblUserFriendName.Size = new System.Drawing.Size(358, 34);
            this.lblUserFriendName.TabIndex = 4;
            this.lblUserFriendName.Text = "Messages";
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
            this.btnBack.Location = new System.Drawing.Point(19, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(46, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userFriendImage
            // 
            this.userFriendImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userFriendImage.ImageRotate = 0F;
            this.userFriendImage.Location = new System.Drawing.Point(71, 5);
            this.userFriendImage.Name = "userFriendImage";
            this.userFriendImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userFriendImage.Size = new System.Drawing.Size(52, 50);
            this.userFriendImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userFriendImage.TabIndex = 3;
            this.userFriendImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkClearImage);
            this.panel1.Controls.Add(this.sendImage);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 87);
            this.panel1.TabIndex = 1;
            // 
            // linkClearImage
            // 
            this.linkClearImage.AutoSize = true;
            this.linkClearImage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClearImage.Location = new System.Drawing.Point(94, 63);
            this.linkClearImage.Name = "linkClearImage";
            this.linkClearImage.Size = new System.Drawing.Size(74, 16);
            this.linkClearImage.TabIndex = 5;
            this.linkClearImage.TabStop = true;
            this.linkClearImage.Text = "Clear Image";
            this.linkClearImage.Visible = false;
            this.linkClearImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClearImage_LinkClicked);
            // 
            // sendImage
            // 
            this.sendImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sendImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendImage.HoverState.ImageSize = new System.Drawing.Size(53, 53);
            this.sendImage.Image = ((System.Drawing.Image)(resources.GetObject("sendImage.Image")));
            this.sendImage.ImageOffset = new System.Drawing.Point(0, 0);
            this.sendImage.ImageRotate = 0F;
            this.sendImage.ImageSize = new System.Drawing.Size(50, 50);
            this.sendImage.Location = new System.Drawing.Point(17, 11);
            this.sendImage.Name = "sendImage";
            this.sendImage.PressedState.ImageSize = new System.Drawing.Size(51, 51);
            this.sendImage.Size = new System.Drawing.Size(74, 57);
            this.sendImage.TabIndex = 4;
            this.sendImage.Click += new System.EventHandler(this.sendImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.IndicateFocus = true;
            this.btnSend.Location = new System.Drawing.Point(464, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.Size = new System.Drawing.Size(49, 49);
            this.btnSend.TabIndex = 3;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Transparent;
            this.txtMessage.BorderRadius = 20;
            this.txtMessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMessage.BorderThickness = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.IconLeftOffset = new System.Drawing.Point(-10, 3);
            this.txtMessage.IconLeftSize = new System.Drawing.Size(70, 70);
            this.txtMessage.Location = new System.Drawing.Point(97, 9);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMessage.PlaceholderText = "Send a Message...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(361, 55);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // messages
            // 
            this.messages.AutoScroll = true;
            this.messages.BackColor = System.Drawing.Color.White;
            this.messages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messages.Location = new System.Drawing.Point(0, 60);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(531, 505);
            this.messages.TabIndex = 2;
            this.messages.WrapContents = false;
            // 
            // chatRefresher
            // 
            this.chatRefresher.Interval = 500;
            // 
            // messageDataIdentifier
            // 
            this.messageDataIdentifier.Enabled = true;
            this.messageDataIdentifier.Interval = 500;
            this.messageDataIdentifier.Tick += new System.EventHandler(this.messageDataIdentifier_Tick);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 61);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(531, 1);
            this.guna2Separator1.TabIndex = 3;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messages);
            this.DoubleBuffered = true;
            this.Name = "MessageForm";
            this.Size = new System.Drawing.Size(531, 649);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFriendImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userFriendImage;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private System.Windows.Forms.Label lblUserFriendName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel messages;
        private System.Windows.Forms.Timer chatRefresher;
        private System.Windows.Forms.Timer messageDataIdentifier;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton sendImage;
        private System.Windows.Forms.LinkLabel linkClearImage;
    }
}
