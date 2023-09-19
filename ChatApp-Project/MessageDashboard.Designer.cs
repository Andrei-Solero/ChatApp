namespace ChatApp_Project
{
    partial class MessageDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDashboard));
            this.header = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFriendRequest = new Guna.UI2.WinForms.Guna2ImageButton();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAddFriend = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.logo = new System.Windows.Forms.PictureBox();
            this.chatRefresher = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.contentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.friendRequestToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.addFriendToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.logoutToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.friendRequestCount = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelNoChat = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.contentContainer.SuspendLayout();
            this.panelNoChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.guna2TextBox1);
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.btnFriendRequest);
            this.header.Controls.Add(this.userImage);
            this.header.Controls.Add(this.btnAddFriend);
            this.header.Controls.Add(this.btnLogout);
            this.header.Controls.Add(this.guna2Separator1);
            this.header.Controls.Add(this.logo);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(530, 100);
            this.header.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.IconLeft = global::ChatApp_Project.Properties.Resources.search;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(113, 50);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Search WeTalk Conversation";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(305, 41);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(107, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(76)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(424, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "WeTalk!";
            // 
            // btnFriendRequest
            // 
            this.btnFriendRequest.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFriendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFriendRequest.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnFriendRequest.Image = global::ChatApp_Project.Properties.Resources.users;
            this.btnFriendRequest.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFriendRequest.ImageRotate = 0F;
            this.btnFriendRequest.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFriendRequest.Location = new System.Drawing.Point(303, 15);
            this.btnFriendRequest.Name = "btnFriendRequest";
            this.btnFriendRequest.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnFriendRequest.Size = new System.Drawing.Size(49, 32);
            this.btnFriendRequest.TabIndex = 16;
            this.btnFriendRequest.Click += new System.EventHandler(this.btnFriendRequest_Click);
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.FillColor = System.Drawing.Color.Transparent;
            this.userImage.ImageRotate = 0F;
            this.userImage.Location = new System.Drawing.Point(30, 15);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.Size = new System.Drawing.Size(70, 70);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 2;
            this.userImage.TabStop = false;
            this.userImage.UseTransparentBackground = true;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriend.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnAddFriend.Image = global::ChatApp_Project.Properties.Resources.user_add;
            this.btnAddFriend.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddFriend.ImageRotate = 0F;
            this.btnAddFriend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddFriend.Location = new System.Drawing.Point(346, 15);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAddFriend.Size = new System.Drawing.Size(36, 32);
            this.btnAddFriend.TabIndex = 14;
            this.btnAddFriend.Click += new System.EventHandler(this.addFriend_Clicked);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageRotate = 0F;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(382, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLogout.Size = new System.Drawing.Size(36, 32);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(184)))), ((int)(((byte)(235)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 99);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(530, 1);
            this.guna2Separator1.TabIndex = 12;
            // 
            // logo
            // 
            this.logo.Image = global::ChatApp_Project.Properties.Resources.edited;
            this.logo.Location = new System.Drawing.Point(401, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 95);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // chatRefresher
            // 
            this.chatRefresher.Enabled = true;
            this.chatRefresher.Tick += new System.EventHandler(this.chatRefresher_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.header;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // contentContainer
            // 
            this.contentContainer.AutoScroll = true;
            this.contentContainer.BackColor = System.Drawing.Color.Transparent;
            this.contentContainer.Controls.Add(this.panelNoChat);
            this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contentContainer.Location = new System.Drawing.Point(0, 100);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(530, 549);
            this.contentContainer.TabIndex = 4;
            this.contentContainer.WrapContents = false;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Hey";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // friendRequestToolTip
            // 
            this.friendRequestToolTip.AllowLinksHandling = true;
            this.friendRequestToolTip.AutomaticDelay = 200;
            this.friendRequestToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.friendRequestToolTip.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRequestToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.friendRequestToolTip.UseFading = false;
            // 
            // addFriendToolTip
            // 
            this.addFriendToolTip.AllowLinksHandling = true;
            this.addFriendToolTip.AutomaticDelay = 200;
            this.addFriendToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.addFriendToolTip.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFriendToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.addFriendToolTip.UseFading = false;
            // 
            // logoutToolTip
            // 
            this.logoutToolTip.AllowLinksHandling = true;
            this.logoutToolTip.AutomaticDelay = 200;
            this.logoutToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.logoutToolTip.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.logoutToolTip.UseFading = false;
            // 
            // friendRequestCount
            // 
            this.friendRequestCount.FillColor = System.Drawing.Color.Navy;
            this.friendRequestCount.TargetControl = this.btnFriendRequest;
            this.friendRequestCount.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(114, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Looks like you got no chats. Add Friend now!";
            // 
            // panelNoChat
            // 
            this.panelNoChat.Controls.Add(this.label1);
            this.panelNoChat.Location = new System.Drawing.Point(3, 3);
            this.panelNoChat.Name = "panelNoChat";
            this.panelNoChat.Size = new System.Drawing.Size(524, 543);
            this.panelNoChat.TabIndex = 0;
            // 
            // MessageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.header);
            this.Name = "MessageDashboard";
            this.Size = new System.Drawing.Size(530, 649);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.contentContainer.ResumeLayout(false);
            this.panelNoChat.ResumeLayout(false);
            this.panelNoChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private System.Windows.Forms.Timer chatRefresher;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
        private System.Windows.Forms.FlowLayoutPanel contentContainer;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddFriend;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton btnFriendRequest;
        private Guna.UI2.WinForms.Guna2HtmlToolTip friendRequestToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip addFriendToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip logoutToolTip;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2NotificationPaint friendRequestCount;
        private System.Windows.Forms.Panel panelNoChat;
        private System.Windows.Forms.Label label1;
    }
}
