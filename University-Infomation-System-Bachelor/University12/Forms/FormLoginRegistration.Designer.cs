namespace University12.Forms
{
    partial class FormLoginRegistration
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
            this.gBoxFormRegistrationFirstName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationFirstName = new System.Windows.Forms.TextBox();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormRegistrationLastName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLastName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationUserName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationUserName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationPassword = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationPassword = new System.Windows.Forms.TextBox();
            this.btnFormRefistrationSignin = new System.Windows.Forms.Button();
            this.btnFormRefistrationExit = new System.Windows.Forms.Button();
            this.gBoxFormRegistrationEmail = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationEmail = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationPhone = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationPhone = new System.Windows.Forms.TextBox();
            this.gBoxRole = new System.Windows.Forms.GroupBox();
            this.cBoxStudent = new System.Windows.Forms.CheckBox();
            this.cBoxAdmin = new System.Windows.Forms.CheckBox();
            this.cBoxLecture = new System.Windows.Forms.CheckBox();
            this.gBoxFormRegistrationFirstName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.gBoxFormRegistrationLastName.SuspendLayout();
            this.gBoxFormRegistrationUserName.SuspendLayout();
            this.gBoxFormRegistrationPassword.SuspendLayout();
            this.gBoxFormRegistrationEmail.SuspendLayout();
            this.gBoxFormRegistrationPhone.SuspendLayout();
            this.gBoxRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxFormRegistrationFirstName
            // 
            this.gBoxFormRegistrationFirstName.Controls.Add(this.txtBoxFormRegistrationFirstName);
            this.gBoxFormRegistrationFirstName.Location = new System.Drawing.Point(54, 24);
            this.gBoxFormRegistrationFirstName.Name = "gBoxFormRegistrationFirstName";
            this.gBoxFormRegistrationFirstName.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationFirstName.TabIndex = 10;
            this.gBoxFormRegistrationFirstName.TabStop = false;
            this.gBoxFormRegistrationFirstName.Text = "Име";
            // 
            // txtBoxFormRegistrationFirstName
            // 
            this.txtBoxFormRegistrationFirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "FirstName", true));
            this.txtBoxFormRegistrationFirstName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationFirstName.Name = "txtBoxFormRegistrationFirstName";
            this.txtBoxFormRegistrationFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationFirstName.TabIndex = 1;
            // 
            // bsUser
            // 
            this.bsUser.AllowNew = false;
            this.bsUser.DataSource = typeof(University12.Classes.TUsers);
            // 
            // gBoxFormRegistrationLastName
            // 
            this.gBoxFormRegistrationLastName.Controls.Add(this.txtBoxFormRegistrationLastName);
            this.gBoxFormRegistrationLastName.Location = new System.Drawing.Point(54, 82);
            this.gBoxFormRegistrationLastName.Name = "gBoxFormRegistrationLastName";
            this.gBoxFormRegistrationLastName.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationLastName.TabIndex = 10;
            this.gBoxFormRegistrationLastName.TabStop = false;
            this.gBoxFormRegistrationLastName.Text = "Фамилия";
            // 
            // txtBoxFormRegistrationLastName
            // 
            this.txtBoxFormRegistrationLastName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "LastName", true));
            this.txtBoxFormRegistrationLastName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationLastName.Name = "txtBoxFormRegistrationLastName";
            this.txtBoxFormRegistrationLastName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationLastName.TabIndex = 2;
            // 
            // gBoxFormRegistrationUserName
            // 
            this.gBoxFormRegistrationUserName.Controls.Add(this.txtBoxFormRegistrationUserName);
            this.gBoxFormRegistrationUserName.Location = new System.Drawing.Point(54, 140);
            this.gBoxFormRegistrationUserName.Name = "gBoxFormRegistrationUserName";
            this.gBoxFormRegistrationUserName.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationUserName.TabIndex = 10;
            this.gBoxFormRegistrationUserName.TabStop = false;
            this.gBoxFormRegistrationUserName.Text = "Потребителско име";
            // 
            // txtBoxFormRegistrationUserName
            // 
            this.txtBoxFormRegistrationUserName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Username", true));
            this.txtBoxFormRegistrationUserName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationUserName.Name = "txtBoxFormRegistrationUserName";
            this.txtBoxFormRegistrationUserName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationUserName.TabIndex = 3;
            // 
            // gBoxFormRegistrationPassword
            // 
            this.gBoxFormRegistrationPassword.Controls.Add(this.txtBoxFormRegistrationPassword);
            this.gBoxFormRegistrationPassword.Location = new System.Drawing.Point(54, 198);
            this.gBoxFormRegistrationPassword.Name = "gBoxFormRegistrationPassword";
            this.gBoxFormRegistrationPassword.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationPassword.TabIndex = 10;
            this.gBoxFormRegistrationPassword.TabStop = false;
            this.gBoxFormRegistrationPassword.Text = "Парола";
            // 
            // txtBoxFormRegistrationPassword
            // 
            this.txtBoxFormRegistrationPassword.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Password", true));
            this.txtBoxFormRegistrationPassword.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationPassword.Name = "txtBoxFormRegistrationPassword";
            this.txtBoxFormRegistrationPassword.PasswordChar = '*';
            this.txtBoxFormRegistrationPassword.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationPassword.TabIndex = 4;
            // 
            // btnFormRefistrationSignin
            // 
            this.btnFormRefistrationSignin.BackColor = System.Drawing.Color.White;
            this.btnFormRefistrationSignin.Location = new System.Drawing.Point(32, 474);
            this.btnFormRefistrationSignin.Name = "btnFormRefistrationSignin";
            this.btnFormRefistrationSignin.Size = new System.Drawing.Size(91, 35);
            this.btnFormRefistrationSignin.TabIndex = 7;
            this.btnFormRefistrationSignin.Text = "Запази";
            this.btnFormRefistrationSignin.UseVisualStyleBackColor = false;
            this.btnFormRefistrationSignin.Click += new System.EventHandler(this.BtnFormRefistrationSignin_Click);
            // 
            // btnFormRefistrationExit
            // 
            this.btnFormRefistrationExit.BackColor = System.Drawing.Color.White;
            this.btnFormRefistrationExit.Location = new System.Drawing.Point(129, 474);
            this.btnFormRefistrationExit.Name = "btnFormRefistrationExit";
            this.btnFormRefistrationExit.Size = new System.Drawing.Size(91, 35);
            this.btnFormRefistrationExit.TabIndex = 10;
            this.btnFormRefistrationExit.Text = "Изход";
            this.btnFormRefistrationExit.UseVisualStyleBackColor = false;
            this.btnFormRefistrationExit.Click += new System.EventHandler(this.BtnFormRefistrationExit_Click);
            // 
            // gBoxFormRegistrationEmail
            // 
            this.gBoxFormRegistrationEmail.Controls.Add(this.txtBoxFormRegistrationEmail);
            this.gBoxFormRegistrationEmail.Location = new System.Drawing.Point(54, 256);
            this.gBoxFormRegistrationEmail.Name = "gBoxFormRegistrationEmail";
            this.gBoxFormRegistrationEmail.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationEmail.TabIndex = 10;
            this.gBoxFormRegistrationEmail.TabStop = false;
            this.gBoxFormRegistrationEmail.Text = "Имейл";
            // 
            // txtBoxFormRegistrationEmail
            // 
            this.txtBoxFormRegistrationEmail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Email", true));
            this.txtBoxFormRegistrationEmail.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationEmail.Name = "txtBoxFormRegistrationEmail";
            this.txtBoxFormRegistrationEmail.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationEmail.TabIndex = 5;
            // 
            // gBoxFormRegistrationPhone
            // 
            this.gBoxFormRegistrationPhone.Controls.Add(this.txtBoxFormRegistrationPhone);
            this.gBoxFormRegistrationPhone.Location = new System.Drawing.Point(54, 314);
            this.gBoxFormRegistrationPhone.Name = "gBoxFormRegistrationPhone";
            this.gBoxFormRegistrationPhone.Size = new System.Drawing.Size(174, 52);
            this.gBoxFormRegistrationPhone.TabIndex = 10;
            this.gBoxFormRegistrationPhone.TabStop = false;
            this.gBoxFormRegistrationPhone.Text = "Телефон";
            // 
            // txtBoxFormRegistrationPhone
            // 
            this.txtBoxFormRegistrationPhone.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUser, "Phone", true));
            this.txtBoxFormRegistrationPhone.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationPhone.Name = "txtBoxFormRegistrationPhone";
            this.txtBoxFormRegistrationPhone.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationPhone.TabIndex = 6;
            // 
            // gBoxRole
            // 
            this.gBoxRole.Controls.Add(this.cBoxStudent);
            this.gBoxRole.Controls.Add(this.cBoxAdmin);
            this.gBoxRole.Controls.Add(this.cBoxLecture);
            this.gBoxRole.Location = new System.Drawing.Point(54, 372);
            this.gBoxRole.Name = "gBoxRole";
            this.gBoxRole.Size = new System.Drawing.Size(174, 88);
            this.gBoxRole.TabIndex = 11;
            this.gBoxRole.TabStop = false;
            this.gBoxRole.Text = "Роли";
            // 
            // cBoxStudent
            // 
            this.cBoxStudent.AutoSize = true;
            this.cBoxStudent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsUser, "IsStudent", true));
            this.cBoxStudent.Location = new System.Drawing.Point(15, 65);
            this.cBoxStudent.Name = "cBoxStudent";
            this.cBoxStudent.Size = new System.Drawing.Size(66, 17);
            this.cBoxStudent.TabIndex = 14;
            this.cBoxStudent.Text = "Студент";
            this.cBoxStudent.UseVisualStyleBackColor = true;
            this.cBoxStudent.CheckedChanged += new System.EventHandler(this.CBoxStudent_CheckedChanged);
            // 
            // cBoxAdmin
            // 
            this.cBoxAdmin.AutoSize = true;
            this.cBoxAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsUser, "IsAdmin", true));
            this.cBoxAdmin.Location = new System.Drawing.Point(15, 19);
            this.cBoxAdmin.Name = "cBoxAdmin";
            this.cBoxAdmin.Size = new System.Drawing.Size(105, 17);
            this.cBoxAdmin.TabIndex = 12;
            this.cBoxAdmin.Text = "Администратор";
            this.cBoxAdmin.UseVisualStyleBackColor = true;
            this.cBoxAdmin.CheckedChanged += new System.EventHandler(this.CBoxAdmin_CheckedChanged);
            // 
            // cBoxLecture
            // 
            this.cBoxLecture.AutoSize = true;
            this.cBoxLecture.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsUser, "IsLecture", true));
            this.cBoxLecture.Location = new System.Drawing.Point(15, 42);
            this.cBoxLecture.Name = "cBoxLecture";
            this.cBoxLecture.Size = new System.Drawing.Size(99, 17);
            this.cBoxLecture.TabIndex = 13;
            this.cBoxLecture.Text = "Преподавател";
            this.cBoxLecture.UseVisualStyleBackColor = true;
            this.cBoxLecture.CheckedChanged += new System.EventHandler(this.CBoxLecture_CheckedChanged);
            // 
            // FormLoginRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 526);
            this.Controls.Add(this.gBoxRole);
            this.Controls.Add(this.gBoxFormRegistrationPhone);
            this.Controls.Add(this.gBoxFormRegistrationEmail);
            this.Controls.Add(this.btnFormRefistrationExit);
            this.Controls.Add(this.btnFormRefistrationSignin);
            this.Controls.Add(this.gBoxFormRegistrationPassword);
            this.Controls.Add(this.gBoxFormRegistrationUserName);
            this.Controls.Add(this.gBoxFormRegistrationLastName);
            this.Controls.Add(this.gBoxFormRegistrationFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне и редакция на потребители";
            this.Load += new System.EventHandler(this.FormLoginRegistration_Load);
            this.gBoxFormRegistrationFirstName.ResumeLayout(false);
            this.gBoxFormRegistrationFirstName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.gBoxFormRegistrationLastName.ResumeLayout(false);
            this.gBoxFormRegistrationLastName.PerformLayout();
            this.gBoxFormRegistrationUserName.ResumeLayout(false);
            this.gBoxFormRegistrationUserName.PerformLayout();
            this.gBoxFormRegistrationPassword.ResumeLayout(false);
            this.gBoxFormRegistrationPassword.PerformLayout();
            this.gBoxFormRegistrationEmail.ResumeLayout(false);
            this.gBoxFormRegistrationEmail.PerformLayout();
            this.gBoxFormRegistrationPhone.ResumeLayout(false);
            this.gBoxFormRegistrationPhone.PerformLayout();
            this.gBoxRole.ResumeLayout(false);
            this.gBoxRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormRegistrationFirstName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationFirstName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLastName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLastName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationUserName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationUserName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationPassword;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationPassword;
        private System.Windows.Forms.Button btnFormRefistrationSignin;
        private System.Windows.Forms.Button btnFormRefistrationExit;
        public System.Windows.Forms.BindingSource bsUser;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationEmail;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationEmail;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationPhone;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationPhone;
        private System.Windows.Forms.GroupBox gBoxRole;
        private System.Windows.Forms.CheckBox cBoxAdmin;
        private System.Windows.Forms.CheckBox cBoxLecture;
        private System.Windows.Forms.CheckBox cBoxStudent;
    }
}