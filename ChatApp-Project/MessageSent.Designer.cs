namespace ChatApp_Project
{
    partial class MessageSent
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtMessageSent = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.statusRefresher = new System.Windows.Forms.Timer(this.components);
            this.messageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Controls.Add(this.txtMessageSent);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 6);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(494, 106);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // txtMessageSent
            // 
            this.txtMessageSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.txtMessageSent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageSent.ForeColor = System.Drawing.Color.Black;
            this.txtMessageSent.Location = new System.Drawing.Point(51, 10);
            this.txtMessageSent.Name = "txtMessageSent";
            this.txtMessageSent.Padding = new System.Windows.Forms.Padding(5);
            this.txtMessageSent.Size = new System.Drawing.Size(431, 85);
            this.txtMessageSent.TabIndex = 0;
            this.txtMessageSent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 100;
            this.guna2Elipse1.TargetControl = this.txtMessageSent;
            // 
            // statusRefresher
            // 
            this.statusRefresher.Enabled = true;
            this.statusRefresher.Interval = 1;
            // 
            // messageToolTip
            // 
            this.messageToolTip.UseFading = false;
            // 
            // MessageSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MessageSent";
            this.Size = new System.Drawing.Size(500, 112);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label txtMessageSent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer statusRefresher;
        private System.Windows.Forms.ToolTip messageToolTip;
    }
}
