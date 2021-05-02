namespace University12.Forms.Add
{
    partial class FormAddSubjects
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
            this.btnFormRegistrationSubjectSave = new System.Windows.Forms.Button();
            this.gBoxFormAddCourse = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddSubjects = new System.Windows.Forms.TextBox();
            this.gBoxFormAddDepartment = new System.Windows.Forms.GroupBox();
            this.cBoxFormAddSubjectDepartment = new System.Windows.Forms.ComboBox();
            this.gBoxFormAddFaculty = new System.Windows.Forms.GroupBox();
            this.cBoxFormAddSubjectFaculty = new System.Windows.Forms.ComboBox();
            this.cBoxComsulsory = new System.Windows.Forms.CheckBox();
            this.cBoxFacultative = new System.Windows.Forms.CheckBox();
            this.bsSubjects = new System.Windows.Forms.BindingSource(this.components);
            this.tFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormAddCourse.SuspendLayout();
            this.gBoxFormAddDepartment.SuspendLayout();
            this.gBoxFormAddFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormRegistrationSubjectSave
            // 
            this.btnFormRegistrationSubjectSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationSubjectSave.Location = new System.Drawing.Point(233, 39);
            this.btnFormRegistrationSubjectSave.Name = "btnFormRegistrationSubjectSave";
            this.btnFormRegistrationSubjectSave.Size = new System.Drawing.Size(104, 39);
            this.btnFormRegistrationSubjectSave.TabIndex = 36;
            this.btnFormRegistrationSubjectSave.Text = "Запис";
            this.btnFormRegistrationSubjectSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationSubjectSave.Click += new System.EventHandler(this.BtnFormRegistrationSubjectSave_Click);
            // 
            // gBoxFormAddCourse
            // 
            this.gBoxFormAddCourse.Controls.Add(this.tBoxFormAddSubjects);
            this.gBoxFormAddCourse.Location = new System.Drawing.Point(12, 9);
            this.gBoxFormAddCourse.Name = "gBoxFormAddCourse";
            this.gBoxFormAddCourse.Size = new System.Drawing.Size(197, 48);
            this.gBoxFormAddCourse.TabIndex = 35;
            this.gBoxFormAddCourse.TabStop = false;
            this.gBoxFormAddCourse.Text = "Име на дисциплина";
            // 
            // tBoxFormAddSubjects
            // 
            this.tBoxFormAddSubjects.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddSubjects.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSubjects, "SubjectName", true));
            this.tBoxFormAddSubjects.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormAddSubjects.Name = "tBoxFormAddSubjects";
            this.tBoxFormAddSubjects.Size = new System.Drawing.Size(179, 20);
            this.tBoxFormAddSubjects.TabIndex = 0;
            // 
            // gBoxFormAddDepartment
            // 
            this.gBoxFormAddDepartment.Controls.Add(this.cBoxFormAddSubjectDepartment);
            this.gBoxFormAddDepartment.Location = new System.Drawing.Point(12, 63);
            this.gBoxFormAddDepartment.Name = "gBoxFormAddDepartment";
            this.gBoxFormAddDepartment.Size = new System.Drawing.Size(197, 48);
            this.gBoxFormAddDepartment.TabIndex = 37;
            this.gBoxFormAddDepartment.TabStop = false;
            this.gBoxFormAddDepartment.Text = "Катедра";
            // 
            // cBoxFormAddSubjectDepartment
            // 
            this.cBoxFormAddSubjectDepartment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFormAddSubjectDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDepartmentsBindingSource, "Name", true));
            this.cBoxFormAddSubjectDepartment.FormattingEnabled = true;
            this.cBoxFormAddSubjectDepartment.Location = new System.Drawing.Point(6, 18);
            this.cBoxFormAddSubjectDepartment.Name = "cBoxFormAddSubjectDepartment";
            this.cBoxFormAddSubjectDepartment.Size = new System.Drawing.Size(185, 21);
            this.cBoxFormAddSubjectDepartment.TabIndex = 0;
            // 
            // gBoxFormAddFaculty
            // 
            this.gBoxFormAddFaculty.Controls.Add(this.cBoxFormAddSubjectFaculty);
            this.gBoxFormAddFaculty.Location = new System.Drawing.Point(12, 117);
            this.gBoxFormAddFaculty.Name = "gBoxFormAddFaculty";
            this.gBoxFormAddFaculty.Size = new System.Drawing.Size(197, 48);
            this.gBoxFormAddFaculty.TabIndex = 38;
            this.gBoxFormAddFaculty.TabStop = false;
            this.gBoxFormAddFaculty.Text = "Факултет";
            // 
            // cBoxFormAddSubjectFaculty
            // 
            this.cBoxFormAddSubjectFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFormAddSubjectFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tFacultyBindingSource, "FacultyName", true));
            this.cBoxFormAddSubjectFaculty.FormattingEnabled = true;
            this.cBoxFormAddSubjectFaculty.Location = new System.Drawing.Point(6, 18);
            this.cBoxFormAddSubjectFaculty.Name = "cBoxFormAddSubjectFaculty";
            this.cBoxFormAddSubjectFaculty.Size = new System.Drawing.Size(185, 21);
            this.cBoxFormAddSubjectFaculty.TabIndex = 0;
            // 
            // cBoxComsulsory
            // 
            this.cBoxComsulsory.AutoSize = true;
            this.cBoxComsulsory.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsSubjects, "CompulsoryDiscipline", true));
            this.cBoxComsulsory.Location = new System.Drawing.Point(233, 103);
            this.cBoxComsulsory.Name = "cBoxComsulsory";
            this.cBoxComsulsory.Size = new System.Drawing.Size(101, 17);
            this.cBoxComsulsory.TabIndex = 39;
            this.cBoxComsulsory.Text = "Задължителна";
            this.cBoxComsulsory.UseVisualStyleBackColor = true;
            this.cBoxComsulsory.CheckedChanged += new System.EventHandler(this.CBoxComsulsory_CheckedChanged);
            // 
            // cBoxFacultative
            // 
            this.cBoxFacultative.AutoSize = true;
            this.cBoxFacultative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsSubjects, "FacultativeDiscipline", true));
            this.cBoxFacultative.Location = new System.Drawing.Point(233, 135);
            this.cBoxFacultative.Name = "cBoxFacultative";
            this.cBoxFacultative.Size = new System.Drawing.Size(100, 17);
            this.cBoxFacultative.TabIndex = 40;
            this.cBoxFacultative.Text = "Факултативна";
            this.cBoxFacultative.UseVisualStyleBackColor = true;
            this.cBoxFacultative.CheckedChanged += new System.EventHandler(this.CBoxFacultative_CheckedChanged);
            // 
            // bsSubjects
            // 
            this.bsSubjects.AllowNew = false;
            this.bsSubjects.DataSource = typeof(University12.Classes.TSubject);
            // 
            // tFacultyBindingSource
            // 
            this.tFacultyBindingSource.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // tDepartmentsBindingSource
            // 
            this.tDepartmentsBindingSource.DataSource = typeof(University12.Classes.TDepartments);
            // 
            // FormAddSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 188);
            this.Controls.Add(this.cBoxFacultative);
            this.Controls.Add(this.cBoxComsulsory);
            this.Controls.Add(this.gBoxFormAddFaculty);
            this.Controls.Add(this.gBoxFormAddDepartment);
            this.Controls.Add(this.btnFormRegistrationSubjectSave);
            this.Controls.Add(this.gBoxFormAddCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплини";
            this.Load += new System.EventHandler(this.FormAddSubjects_Load);
            this.gBoxFormAddCourse.ResumeLayout(false);
            this.gBoxFormAddCourse.PerformLayout();
            this.gBoxFormAddDepartment.ResumeLayout(false);
            this.gBoxFormAddFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormRegistrationSubjectSave;
        private System.Windows.Forms.GroupBox gBoxFormAddCourse;
        private System.Windows.Forms.TextBox tBoxFormAddSubjects;
        public System.Windows.Forms.BindingSource bsSubjects;
        private System.Windows.Forms.GroupBox gBoxFormAddDepartment;
        private System.Windows.Forms.ComboBox cBoxFormAddSubjectDepartment;
        private System.Windows.Forms.GroupBox gBoxFormAddFaculty;
        private System.Windows.Forms.ComboBox cBoxFormAddSubjectFaculty;
        private System.Windows.Forms.BindingSource tDepartmentsBindingSource;
        private System.Windows.Forms.BindingSource tFacultyBindingSource;
        private System.Windows.Forms.CheckBox cBoxComsulsory;
        private System.Windows.Forms.CheckBox cBoxFacultative;
    }
}