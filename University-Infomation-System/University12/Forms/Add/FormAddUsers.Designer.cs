namespace University12.Forms.Add
{
    partial class FormAddUsers
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
            this.btnFormRegistrationLectureSave = new System.Windows.Forms.Button();
            this.gBoxFormAddUsers = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddUsers = new System.Windows.Forms.TextBox();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(52, 76);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 36;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.btnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddUsers
            // 
            this.gBoxFormAddUsers.Controls.Add(this.tBoxFormAddUsers);
            this.gBoxFormAddUsers.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddUsers.Name = "gBoxFormAddUsers";
            this.gBoxFormAddUsers.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddUsers.TabIndex = 35;
            this.gBoxFormAddUsers.TabStop = false;
            this.gBoxFormAddUsers.Text = "Потребители";
            // 
            // tBoxFormAddUsers
            // 
            this.tBoxFormAddUsers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddUsers.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddUsers.Name = "tBoxFormAddUsers";
            this.tBoxFormAddUsers.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddUsers.TabIndex = 0;
            this.tBoxFormAddUsers.TextChanged += new System.EventHandler(this.TBoxFormAddUsers_TextChanged);
            // 
            // bsUsers
            // 
            this.bsUsers.AllowNew = false;
            this.bsUsers.DataSource = typeof(University12.Classes.TUsers);
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 121);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребители";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            this.gBoxFormAddUsers.ResumeLayout(false);
            this.gBoxFormAddUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.GroupBox gBoxFormAddUsers;
        private System.Windows.Forms.TextBox tBoxFormAddUsers;
        public System.Windows.Forms.BindingSource bsUsers;
    }
}