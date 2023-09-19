namespace ChatApp_Project
{
    partial class CreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnBrowseImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBio = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 71);
            this.panel1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ChatApp_Project.Properties.Resources.image_processing20210410_3722_1dral1b_removebg_preview__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-30, -28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(136, 126);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create WeChat Account";
            // 
            // profilePicture
            // 
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(30, 85);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(175, 175);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BorderRadius = 6;
            this.btnBrowseImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Location = new System.Drawing.Point(29, 264);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(176, 32);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "Browse Profile Picture";
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(220, 90);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(298, 51);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.DefaultText = "";
            this.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.Location = new System.Drawing.Point(220, 149);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMiddleName.PlaceholderText = "Middle Name";
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.Size = new System.Drawing.Size(298, 51);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(220, 207);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(298, 51);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(47, 372);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(437, 51);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(47, 313);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(437, 51);
            this.txtUsername.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(47, 431);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(437, 51);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtBio
            // 
            this.txtBio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBio.DefaultText = "";
            this.txtBio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBio.Location = new System.Drawing.Point(30, 490);
            this.txtBio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = '\0';
            this.txtBio.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBio.PlaceholderText = "Bio";
            this.txtBio.SelectedText = "";
            this.txtBio.Size = new System.Drawing.Size(488, 72);
            this.txtBio.TabIndex = 9;
            this.txtBio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreate
            // 
            this.btnCreate.CustomBorderColor = System.Drawing.Color.Aqua;
            this.btnCreate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(45, 572);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(217, 51);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create WeChat Account";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCancel.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.btnCancel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(268, 572);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 51);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Guna.UI2.WinForms.Guna2Button btnBrowseImage;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtBio;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}