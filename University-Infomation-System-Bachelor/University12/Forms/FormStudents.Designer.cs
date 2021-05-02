namespace University12.Forms
{
    partial class FormStudents
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
            this.btnStudentsEvaluation = new System.Windows.Forms.Button();
            this.btnStudentsExam = new System.Windows.Forms.Button();
            this.btnStudentsSubject = new System.Windows.Forms.Button();
            this.gBoxLecturesGridLectures = new System.Windows.Forms.GroupBox();
            this.dataGridViewLectures = new System.Windows.Forms.DataGridView();
            this.btnStudentsSearch = new System.Windows.Forms.Button();
            this.gBoxStudentsSearch = new System.Windows.Forms.GroupBox();
            this.tBoxStudentsSearch = new System.Windows.Forms.TextBox();
            this.gBoxStudentsSpeciality = new System.Windows.Forms.GroupBox();
            this.cBoxStudentsSpeciality = new System.Windows.Forms.ComboBox();
            this.gBoxStudentsFaculty = new System.Windows.Forms.GroupBox();
            this.cBoxStudentsFaculty = new System.Windows.Forms.ComboBox();
            this.btnStudentsAdd = new System.Windows.Forms.Button();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.tSpecialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formOfEducationsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationLevelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEGNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGraduateSecondarySchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxLecturesGridLectures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLectures)).BeginInit();
            this.gBoxStudentsSearch.SuspendLayout();
            this.gBoxStudentsSpeciality.SuspendLayout();
            this.gBoxStudentsFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSpecialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentsEvaluation
            // 
            this.btnStudentsEvaluation.BackColor = System.Drawing.Color.White;
            this.btnStudentsEvaluation.Location = new System.Drawing.Point(206, 12);
            this.btnStudentsEvaluation.Name = "btnStudentsEvaluation";
            this.btnStudentsEvaluation.Size = new System.Drawing.Size(91, 35);
            this.btnStudentsEvaluation.TabIndex = 20;
            this.btnStudentsEvaluation.Text = "Оценки";
            this.btnStudentsEvaluation.UseVisualStyleBackColor = false;
            this.btnStudentsEvaluation.Click += new System.EventHandler(this.btnStudentsEvaluation_Click);
            // 
            // btnStudentsExam
            // 
            this.btnStudentsExam.BackColor = System.Drawing.Color.White;
            this.btnStudentsExam.Location = new System.Drawing.Point(109, 12);
            this.btnStudentsExam.Name = "btnStudentsExam";
            this.btnStudentsExam.Size = new System.Drawing.Size(91, 35);
            this.btnStudentsExam.TabIndex = 19;
            this.btnStudentsExam.Text = "Изпитни резултати";
            this.btnStudentsExam.UseVisualStyleBackColor = false;
            this.btnStudentsExam.Click += new System.EventHandler(this.btnStudentsExam_Click);
            // 
            // btnStudentsSubject
            // 
            this.btnStudentsSubject.BackColor = System.Drawing.Color.White;
            this.btnStudentsSubject.Location = new System.Drawing.Point(12, 12);
            this.btnStudentsSubject.Name = "btnStudentsSubject";
            this.btnStudentsSubject.Size = new System.Drawing.Size(91, 35);
            this.btnStudentsSubject.TabIndex = 18;
            this.btnStudentsSubject.Text = "Дисциплини";
            this.btnStudentsSubject.UseVisualStyleBackColor = false;
            this.btnStudentsSubject.Click += new System.EventHandler(this.btnStudentsSubject_Click);
            // 
            // gBoxLecturesGridLectures
            // 
            this.gBoxLecturesGridLectures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLecturesGridLectures.Controls.Add(this.dataGridViewLectures);
            this.gBoxLecturesGridLectures.Location = new System.Drawing.Point(12, 108);
            this.gBoxLecturesGridLectures.Name = "gBoxLecturesGridLectures";
            this.gBoxLecturesGridLectures.Size = new System.Drawing.Size(1271, 437);
            this.gBoxLecturesGridLectures.TabIndex = 16;
            this.gBoxLecturesGridLectures.TabStop = false;
            this.gBoxLecturesGridLectures.Text = "Студенти";
            // 
            // dataGridViewLectures
            // 
            this.dataGridViewLectures.AllowUserToAddRows = false;
            this.dataGridViewLectures.AllowUserToDeleteRows = false;
            this.dataGridViewLectures.AutoGenerateColumns = false;
            this.dataGridViewLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLectures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.facultyNameDataGridViewTextBoxColumn,
            this.specialityNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.formOfEducationsNameDataGridViewTextBoxColumn,
            this.facultyNumberDataGridViewTextBoxColumn,
            this.educationLevelNameDataGridViewTextBoxColumn,
            this.studentEGNDataGridViewTextBoxColumn,
            this.startYearDataGridViewTextBoxColumn,
            this.finishYearDataGridViewTextBoxColumn,
            this.StudentPhone,
            this.studentEmailDataGridViewTextBoxColumn,
            this.studentCityDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.StudentGraduateSecondarySchool,
            this.Credits});
            this.dataGridViewLectures.DataSource = this.bsStudents;
            this.dataGridViewLectures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLectures.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLectures.Name = "dataGridViewLectures";
            this.dataGridViewLectures.ReadOnly = true;
            this.dataGridViewLectures.RowHeadersWidth = 10;
            this.dataGridViewLectures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLectures.Size = new System.Drawing.Size(1265, 418);
            this.dataGridViewLectures.TabIndex = 4;
            this.dataGridViewLectures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLectures_CellContentClick);
            this.dataGridViewLectures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLectures_CellDoubleClick_1);
            // 
            // btnStudentsSearch
            // 
            this.btnStudentsSearch.BackColor = System.Drawing.Color.White;
            this.btnStudentsSearch.Location = new System.Drawing.Point(604, 64);
            this.btnStudentsSearch.Name = "btnStudentsSearch";
            this.btnStudentsSearch.Size = new System.Drawing.Size(91, 35);
            this.btnStudentsSearch.TabIndex = 15;
            this.btnStudentsSearch.Text = "Търсене";
            this.btnStudentsSearch.UseVisualStyleBackColor = false;
            this.btnStudentsSearch.Click += new System.EventHandler(this.BtnStudentsSearch_Click);
            // 
            // gBoxStudentsSearch
            // 
            this.gBoxStudentsSearch.Controls.Add(this.tBoxStudentsSearch);
            this.gBoxStudentsSearch.Location = new System.Drawing.Point(382, 54);
            this.gBoxStudentsSearch.Name = "gBoxStudentsSearch";
            this.gBoxStudentsSearch.Size = new System.Drawing.Size(216, 48);
            this.gBoxStudentsSearch.TabIndex = 14;
            this.gBoxStudentsSearch.TabStop = false;
            this.gBoxStudentsSearch.Text = "Търсене";
            // 
            // tBoxStudentsSearch
            // 
            this.tBoxStudentsSearch.Location = new System.Drawing.Point(6, 18);
            this.tBoxStudentsSearch.Name = "tBoxStudentsSearch";
            this.tBoxStudentsSearch.Size = new System.Drawing.Size(201, 20);
            this.tBoxStudentsSearch.TabIndex = 0;
            // 
            // gBoxStudentsSpeciality
            // 
            this.gBoxStudentsSpeciality.Controls.Add(this.cBoxStudentsSpeciality);
            this.gBoxStudentsSpeciality.Location = new System.Drawing.Point(197, 53);
            this.gBoxStudentsSpeciality.Name = "gBoxStudentsSpeciality";
            this.gBoxStudentsSpeciality.Size = new System.Drawing.Size(179, 49);
            this.gBoxStudentsSpeciality.TabIndex = 13;
            this.gBoxStudentsSpeciality.TabStop = false;
            this.gBoxStudentsSpeciality.Text = "Специалност";
            // 
            // cBoxStudentsSpeciality
            // 
            this.cBoxStudentsSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxStudentsSpeciality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tSpecialityBindingSource, "NameSpeciality", true));
            this.cBoxStudentsSpeciality.FormattingEnabled = true;
            this.cBoxStudentsSpeciality.Location = new System.Drawing.Point(8, 18);
            this.cBoxStudentsSpeciality.Name = "cBoxStudentsSpeciality";
            this.cBoxStudentsSpeciality.Size = new System.Drawing.Size(165, 21);
            this.cBoxStudentsSpeciality.TabIndex = 0;
            this.cBoxStudentsSpeciality.SelectedIndexChanged += new System.EventHandler(this.CBoxStudentsSpeciality_SelectedIndexChanged);
            // 
            // gBoxStudentsFaculty
            // 
            this.gBoxStudentsFaculty.Controls.Add(this.cBoxStudentsFaculty);
            this.gBoxStudentsFaculty.Location = new System.Drawing.Point(12, 53);
            this.gBoxStudentsFaculty.Name = "gBoxStudentsFaculty";
            this.gBoxStudentsFaculty.Size = new System.Drawing.Size(179, 49);
            this.gBoxStudentsFaculty.TabIndex = 12;
            this.gBoxStudentsFaculty.TabStop = false;
            this.gBoxStudentsFaculty.Text = "Факултет";
            // 
            // cBoxStudentsFaculty
            // 
            this.cBoxStudentsFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxStudentsFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tFacultyBindingSource, "FacultyName", true));
            this.cBoxStudentsFaculty.FormattingEnabled = true;
            this.cBoxStudentsFaculty.Location = new System.Drawing.Point(6, 19);
            this.cBoxStudentsFaculty.Name = "cBoxStudentsFaculty";
            this.cBoxStudentsFaculty.Size = new System.Drawing.Size(165, 21);
            this.cBoxStudentsFaculty.TabIndex = 0;
            this.cBoxStudentsFaculty.SelectedIndexChanged += new System.EventHandler(this.cBoxStudentsFaculty_SelectedIndexChanged);
            // 
            // btnStudentsAdd
            // 
            this.btnStudentsAdd.BackColor = System.Drawing.Color.White;
            this.btnStudentsAdd.Location = new System.Drawing.Point(303, 12);
            this.btnStudentsAdd.Name = "btnStudentsAdd";
            this.btnStudentsAdd.Size = new System.Drawing.Size(91, 35);
            this.btnStudentsAdd.TabIndex = 22;
            this.btnStudentsAdd.Text = "Добави";
            this.btnStudentsAdd.UseVisualStyleBackColor = false;
            this.btnStudentsAdd.Click += new System.EventHandler(this.BtnStudentsAdd_Click);
            // 
            // bsStudents
            // 
            this.bsStudents.AllowNew = false;
            this.bsStudents.DataSource = typeof(University12.Classes.TStudentSpeciality);
            // 
            // tSpecialityBindingSource
            // 
            this.tSpecialityBindingSource.DataSource = typeof(University12.Classes.TSpeciality);
            // 
            // tFacultyBindingSource
            // 
            this.tFacultyBindingSource.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // tCourseBindingSource
            // 
            this.tCourseBindingSource.DataSource = typeof(University12.Classes.TCourse);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facultyNameDataGridViewTextBoxColumn
            // 
            this.facultyNameDataGridViewTextBoxColumn.DataPropertyName = "FacultyName";
            this.facultyNameDataGridViewTextBoxColumn.HeaderText = "Факултет";
            this.facultyNameDataGridViewTextBoxColumn.Name = "facultyNameDataGridViewTextBoxColumn";
            this.facultyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // specialityNameDataGridViewTextBoxColumn
            // 
            this.specialityNameDataGridViewTextBoxColumn.DataPropertyName = "SpecialityName";
            this.specialityNameDataGridViewTextBoxColumn.HeaderText = "Специалност";
            this.specialityNameDataGridViewTextBoxColumn.Name = "specialityNameDataGridViewTextBoxColumn";
            this.specialityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // formOfEducationsNameDataGridViewTextBoxColumn
            // 
            this.formOfEducationsNameDataGridViewTextBoxColumn.DataPropertyName = "FormOfEducationsName";
            this.formOfEducationsNameDataGridViewTextBoxColumn.HeaderText = "Форма на обучение";
            this.formOfEducationsNameDataGridViewTextBoxColumn.Name = "formOfEducationsNameDataGridViewTextBoxColumn";
            this.formOfEducationsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.formOfEducationsNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // facultyNumberDataGridViewTextBoxColumn
            // 
            this.facultyNumberDataGridViewTextBoxColumn.DataPropertyName = "FacultyNumber";
            this.facultyNumberDataGridViewTextBoxColumn.HeaderText = "Факултетен номер";
            this.facultyNumberDataGridViewTextBoxColumn.Name = "facultyNumberDataGridViewTextBoxColumn";
            this.facultyNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyNumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // educationLevelNameDataGridViewTextBoxColumn
            // 
            this.educationLevelNameDataGridViewTextBoxColumn.DataPropertyName = "EducationLevelName";
            this.educationLevelNameDataGridViewTextBoxColumn.HeaderText = "Образователна степен";
            this.educationLevelNameDataGridViewTextBoxColumn.Name = "educationLevelNameDataGridViewTextBoxColumn";
            this.educationLevelNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.educationLevelNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // studentEGNDataGridViewTextBoxColumn
            // 
            this.studentEGNDataGridViewTextBoxColumn.DataPropertyName = "StudentEGN";
            this.studentEGNDataGridViewTextBoxColumn.HeaderText = "ЕГН";
            this.studentEGNDataGridViewTextBoxColumn.Name = "studentEGNDataGridViewTextBoxColumn";
            this.studentEGNDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentEGNDataGridViewTextBoxColumn.Width = 70;
            // 
            // startYearDataGridViewTextBoxColumn
            // 
            this.startYearDataGridViewTextBoxColumn.DataPropertyName = "StartYear";
            this.startYearDataGridViewTextBoxColumn.HeaderText = "Започнал";
            this.startYearDataGridViewTextBoxColumn.Name = "startYearDataGridViewTextBoxColumn";
            this.startYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.startYearDataGridViewTextBoxColumn.Width = 70;
            // 
            // finishYearDataGridViewTextBoxColumn
            // 
            this.finishYearDataGridViewTextBoxColumn.DataPropertyName = "FinishYear";
            this.finishYearDataGridViewTextBoxColumn.HeaderText = "Завършил";
            this.finishYearDataGridViewTextBoxColumn.Name = "finishYearDataGridViewTextBoxColumn";
            this.finishYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.finishYearDataGridViewTextBoxColumn.Width = 70;
            // 
            // StudentPhone
            // 
            this.StudentPhone.DataPropertyName = "StudentPhone";
            this.StudentPhone.HeaderText = "Телефон";
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.ReadOnly = true;
            this.StudentPhone.Width = 70;
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "StudentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "Имейл";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            this.studentEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCityDataGridViewTextBoxColumn
            // 
            this.studentCityDataGridViewTextBoxColumn.DataPropertyName = "StudentCity";
            this.studentCityDataGridViewTextBoxColumn.HeaderText = "Град";
            this.studentCityDataGridViewTextBoxColumn.Name = "studentCityDataGridViewTextBoxColumn";
            this.studentCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentCityDataGridViewTextBoxColumn.Width = 70;
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "StudentAddress";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            this.studentAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StudentGraduateSecondarySchool
            // 
            this.StudentGraduateSecondarySchool.DataPropertyName = "StudentGraduateSecondarySchool";
            this.StudentGraduateSecondarySchool.HeaderText = "Средно училище";
            this.StudentGraduateSecondarySchool.Name = "StudentGraduateSecondarySchool";
            this.StudentGraduateSecondarySchool.ReadOnly = true;
            // 
            // Credits
            // 
            this.Credits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Credits.DataPropertyName = "Credits";
            this.Credits.HeaderText = "Общо кредити";
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 553);
            this.Controls.Add(this.btnStudentsAdd);
            this.Controls.Add(this.btnStudentsEvaluation);
            this.Controls.Add(this.btnStudentsExam);
            this.Controls.Add(this.btnStudentsSubject);
            this.Controls.Add(this.gBoxLecturesGridLectures);
            this.Controls.Add(this.btnStudentsSearch);
            this.Controls.Add(this.gBoxStudentsSearch);
            this.Controls.Add(this.gBoxStudentsSpeciality);
            this.Controls.Add(this.gBoxStudentsFaculty);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "Faculty", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенти";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.gBoxLecturesGridLectures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLectures)).EndInit();
            this.gBoxStudentsSearch.ResumeLayout(false);
            this.gBoxStudentsSearch.PerformLayout();
            this.gBoxStudentsSpeciality.ResumeLayout(false);
            this.gBoxStudentsFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSpecialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentsEvaluation;
        private System.Windows.Forms.Button btnStudentsExam;
        private System.Windows.Forms.Button btnStudentsSubject;
        private System.Windows.Forms.GroupBox gBoxLecturesGridLectures;
        private System.Windows.Forms.DataGridView dataGridViewLectures;
        private System.Windows.Forms.Button btnStudentsSearch;
        private System.Windows.Forms.GroupBox gBoxStudentsSearch;
        private System.Windows.Forms.TextBox tBoxStudentsSearch;
        private System.Windows.Forms.GroupBox gBoxStudentsSpeciality;
        private System.Windows.Forms.ComboBox cBoxStudentsSpeciality;
        private System.Windows.Forms.GroupBox gBoxStudentsFaculty;
        private System.Windows.Forms.ComboBox cBoxStudentsFaculty;
        private System.Windows.Forms.Button btnStudentsAdd;
        public System.Windows.Forms.BindingSource bsStudents;
        private System.Windows.Forms.BindingSource tSpecialityBindingSource;
        private System.Windows.Forms.BindingSource tFacultyBindingSource;
        private System.Windows.Forms.BindingSource tCourseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formOfEducationsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationLevelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEGNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGraduateSecondarySchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
    }
}