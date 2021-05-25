namespace Spicy_management.EPL
{
    partial class FRM_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_login));
            this.edit_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_username
            // 
            this.edit_username.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_username.Location = new System.Drawing.Point(74, 202);
            this.edit_username.Name = "edit_username";
            this.edit_username.Size = new System.Drawing.Size(332, 43);
            this.edit_username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المستخدم";
            // 
            // edit_password
            // 
            this.edit_password.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_password.Location = new System.Drawing.Point(73, 318);
            this.edit_password.Name = "edit_password";
            this.edit_password.PasswordChar = '*';
            this.edit_password.Size = new System.Drawing.Size(332, 43);
            this.edit_password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(177, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "كلمه السر";
            // 
            // pic_title
            // 
            this.pic_title.Image = ((System.Drawing.Image)(resources.GetObject("pic_title.Image")));
            this.pic_title.Location = new System.Drawing.Point(179, 20);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(120, 116);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_title.TabIndex = 9;
            this.pic_title.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(143, 400);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(192, 52);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "تسجيل الدخول";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(478, 503);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_title);
            this.Controls.Add(this.edit_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit_username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FRM_login";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox edit_username;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edit_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_title;
        public DevExpress.XtraEditors.SimpleButton btn_add;
    }
}