namespace University12.Forms.Add
{
    partial class FormAddFaculty
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
            this.gBoxFormAddFaculty = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddFaculty = new System.Windows.Forms.TextBox();
            this.bsFaculty = new System.Windows.Forms.BindingSource(this.components);
            this.btnFormRegistrationLectureSave = new System.Windows.Forms.Button();
            this.gBoxFormAddUniversity = new System.Windows.Forms.GroupBox();
            this.cBoxFormAddFacultyUniversity = new System.Windows.Forms.ComboBox();
            this.tUniversityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaculty)).BeginInit();
            this.gBoxFormAddUniversity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUniversityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFormAddFaculty
            // 
            this.gBoxFormAddFaculty.Controls.Add(this.tBoxFormAddFaculty);
            this.gBoxFormAddFaculty.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormAddFaculty.Name = "gBoxFormAddFaculty";
            this.gBoxFormAddFaculty.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormAddFaculty.TabIndex = 16;
            this.gBoxFormAddFaculty.TabStop = false;
            this.gBoxFormAddFaculty.Text = "Име на факултета";
            // 
            // tBoxFormAddFaculty
            // 
            this.tBoxFormAddFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFaculty, "FacultyName", true));
            this.tBoxFormAddFaculty.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddFaculty.Name = "tBoxFormAddFaculty";
            this.tBoxFormAddFaculty.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormAddFaculty.TabIndex = 0;
            this.tBoxFormAddFaculty.TextChanged += new System.EventHandler(this.TBoxFormAddFaculty_TextChanged_1);
            // 
            // bsFaculty
            // 
            this.bsFaculty.AllowNew = false;
            this.bsFaculty.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(144, 79);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationLectureSave.TabIndex = 32;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.BtnFormRegistrationLectureSave_Click);
            // 
            // gBoxFormAddUniversity
            // 
            this.gBoxFormAddUniversity.Controls.Add(this.cBoxFormAddFacultyUniversity);
            this.gBoxFormAddUniversity.Location = new System.Drawing.Point(190, 12);
            this.gBoxFormAddUniversity.Name = "gBoxFormAddUniversity";
            this.gBoxFormAddUniversity.Size = new System.Drawing.Size(185, 48);
            this.gBoxFormAddUniversity.TabIndex = 36;
            this.gBoxFormAddUniversity.TabStop = false;
            this.gBoxFormAddUniversity.Text = "Университет";
            // 
            // cBoxFormAddFacultyUniversity
            // 
            this.cBoxFormAddFacultyUniversity.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFormAddFacultyUniversity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tUniversityBindingSource, "Name", true));
            this.cBoxFormAddFacultyUniversity.FormattingEnabled = true;
            this.cBoxFormAddFacultyUniversity.Location = new System.Drawing.Point(6, 18);
            this.cBoxFormAddFacultyUniversity.Name = "cBoxFormAddFacultyUniversity";
            this.cBoxFormAddFacultyUniversity.Size = new System.Drawing.Size(171, 21);
            this.cBoxFormAddFacultyUniversity.TabIndex = 0;
            this.cBoxFormAddFacultyUniversity.SelectedIndexChanged += new System.EventHandler(this.CBoxFormAddFacultyUniversity_SelectedIndexChanged);
            // 
            // tUniversityBindingSource
            // 
            this.tUniversityBindingSource.DataSource = typeof(University12.Classes.TUniversity);
            // 
            // FormAddFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 124);
            this.Controls.Add(this.gBoxFormAddUniversity);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormAddFaculty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факултети";
            this.Load += new System.EventHandler(this.FormAddFaculty_Load);
            this.gBoxFormAddFaculty.ResumeLayout(false);
            this.gBoxFormAddFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaculty)).EndInit();
            this.gBoxFormAddUniversity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tUniversityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormAddFaculty;
        private System.Windows.Forms.TextBox tBoxFormAddFaculty;
        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        public System.Windows.Forms.BindingSource bsFaculty;
        private System.Windows.Forms.GroupBox gBoxFormAddUniversity;
        private System.Windows.Forms.ComboBox cBoxFormAddFacultyUniversity;
        private System.Windows.Forms.BindingSource tUniversityBindingSource;
    }
}