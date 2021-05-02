namespace University12.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.gBoxPassword = new System.Windows.Forms.GroupBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLoginSignin = new System.Windows.Forms.Button();
            this.btnFormLoginExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxLogin.SuspendLayout();
            this.gBoxPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxLogin
            // 
            this.gBoxLogin.Controls.Add(this.tBoxLogin);
            this.gBoxLogin.Location = new System.Drawing.Point(61, 97);
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.Size = new System.Drawing.Size(170, 57);
            this.gBoxLogin.TabIndex = 1;
            this.gBoxLogin.TabStop = false;
            this.gBoxLogin.Text = "Потребител";
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxLogin.Location = new System.Drawing.Point(6, 19);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(158, 20);
            this.tBoxLogin.TabIndex = 0;
            // 
            // gBoxPassword
            // 
            this.gBoxPassword.Controls.Add(this.tBoxPassword);
            this.gBoxPassword.Location = new System.Drawing.Point(61, 160);
            this.gBoxPassword.Name = "gBoxPassword";
            this.gBoxPassword.Size = new System.Drawing.Size(170, 57);
            this.gBoxPassword.TabIndex = 2;
            this.gBoxPassword.TabStop = false;
            this.gBoxPassword.Text = "Парола";
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxPassword.Location = new System.Drawing.Point(6, 19);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(158, 20);
            this.tBoxPassword.TabIndex = 0;
            // 
            // btnLoginSignin
            // 
            this.btnLoginSignin.BackColor = System.Drawing.Color.White;
            this.btnLoginSignin.Location = new System.Drawing.Point(48, 223);
            this.btnLoginSignin.Name = "btnLoginSignin";
            this.btnLoginSignin.Size = new System.Drawing.Size(91, 35);
            this.btnLoginSignin.TabIndex = 4;
            this.btnLoginSignin.Text = "Вход";
            this.btnLoginSignin.UseVisualStyleBackColor = false;
            this.btnLoginSignin.Click += new System.EventHandler(this.BtnLoginSignin_Click);
            // 
            // btnFormLoginExit
            // 
            this.btnFormLoginExit.BackColor = System.Drawing.Color.White;
            this.btnFormLoginExit.Location = new System.Drawing.Point(154, 223);
            this.btnFormLoginExit.Name = "btnFormLoginExit";
            this.btnFormLoginExit.Size = new System.Drawing.Size(91, 35);
            this.btnFormLoginExit.TabIndex = 6;
            this.btnFormLoginExit.Text = "Изход";
            this.btnFormLoginExit.UseVisualStyleBackColor = false;
            this.btnFormLoginExit.Click += new System.EventHandler(this.BtnFormLoginExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFormLoginExit);
            this.Controls.Add(this.btnLoginSignin);
            this.Controls.Add(this.gBoxPassword);
            this.Controls.Add(this.gBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Идентификация на потребителите";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            this.gBoxPassword.ResumeLayout(false);
            this.gBoxPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.GroupBox gBoxPassword;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button btnLoginSignin;
        private System.Windows.Forms.Button btnFormLoginExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}