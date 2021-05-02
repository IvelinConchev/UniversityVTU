namespace University12.Forms
{
    partial class FormЕvaluation
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
            this.gBoxEvaluation = new System.Windows.Forms.GroupBox();
            this.dataGridViewEvaluation = new System.Windows.Forms.DataGridView();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxEvaluationSpeciality = new System.Windows.Forms.GroupBox();
            this.cBoxEvaluationSpeciality = new System.Windows.Forms.ComboBox();
            this.gBoxEvaluationCourse = new System.Windows.Forms.GroupBox();
            this.cBoxEvaluationCourse = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExamAdd = new System.Windows.Forms.Button();
            this.tCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSpecialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEvaluations = new System.Windows.Forms.BindingSource(this.components);
            this.tSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvaluation)).BeginInit();
            this.gBoxEvaluationSpeciality.SuspendLayout();
            this.gBoxEvaluationCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSpecialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxEvaluation
            // 
            this.gBoxEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxEvaluation.Controls.Add(this.dataGridViewEvaluation);
            this.gBoxEvaluation.Location = new System.Drawing.Point(5, 122);
            this.gBoxEvaluation.Name = "gBoxEvaluation";
            this.gBoxEvaluation.Size = new System.Drawing.Size(555, 344);
            this.gBoxEvaluation.TabIndex = 0;
            this.gBoxEvaluation.TabStop = false;
            this.gBoxEvaluation.Text = "Оценяване";
            // 
            // dataGridViewEvaluation
            // 
            this.dataGridViewEvaluation.AllowUserToAddRows = false;
            this.dataGridViewEvaluation.AllowUserToDeleteRows = false;
            this.dataGridViewEvaluation.AutoGenerateColumns = false;
            this.dataGridViewEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Speciality,
            this.Course,
            this.dataGridViewTextBoxColumn1,
            this.Student,
            this.Subject,
            this.Number});
            this.dataGridViewEvaluation.DataSource = this.bsEvaluations;
            this.dataGridViewEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvaluation.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewEvaluation.Name = "dataGridViewEvaluation";
            this.dataGridViewEvaluation.ReadOnly = true;
            this.dataGridViewEvaluation.RowHeadersWidth = 10;
            this.dataGridViewEvaluation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvaluation.Size = new System.Drawing.Size(549, 325);
            this.dataGridViewEvaluation.TabIndex = 0;
            this.dataGridViewEvaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEvaluation_CellContentClick);
            this.dataGridViewEvaluation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEvaluation_CellDoubleClick);
            // 
            // Speciality
            // 
            this.Speciality.DataPropertyName = "NameSpecilaity";
            this.Speciality.HeaderText = "Специалност";
            this.Speciality.Name = "Speciality";
            this.Speciality.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "CourseName";
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LectureName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Преподавател";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "StudentName";
            this.Student.HeaderText = "Студент";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "SubjectName";
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Цифра";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // gBoxEvaluationSpeciality
            // 
            this.gBoxEvaluationSpeciality.Controls.Add(this.cBoxEvaluationSpeciality);
            this.gBoxEvaluationSpeciality.Location = new System.Drawing.Point(5, 31);
            this.gBoxEvaluationSpeciality.Name = "gBoxEvaluationSpeciality";
            this.gBoxEvaluationSpeciality.Size = new System.Drawing.Size(179, 49);
            this.gBoxEvaluationSpeciality.TabIndex = 14;
            this.gBoxEvaluationSpeciality.TabStop = false;
            this.gBoxEvaluationSpeciality.Text = "Специалност";
            // 
            // cBoxEvaluationSpeciality
            // 
            this.cBoxEvaluationSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxEvaluationSpeciality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tSpecialityBindingSource, "NameSpeciality", true));
            this.cBoxEvaluationSpeciality.FormattingEnabled = true;
            this.cBoxEvaluationSpeciality.Location = new System.Drawing.Point(6, 19);
            this.cBoxEvaluationSpeciality.Name = "cBoxEvaluationSpeciality";
            this.cBoxEvaluationSpeciality.Size = new System.Drawing.Size(165, 21);
            this.cBoxEvaluationSpeciality.TabIndex = 0;
            this.cBoxEvaluationSpeciality.SelectedIndexChanged += new System.EventHandler(this.CBoxEvaluationSpeciality_SelectedIndexChanged);
            // 
            // gBoxEvaluationCourse
            // 
            this.gBoxEvaluationCourse.Controls.Add(this.cBoxEvaluationCourse);
            this.gBoxEvaluationCourse.Location = new System.Drawing.Point(190, 31);
            this.gBoxEvaluationCourse.Name = "gBoxEvaluationCourse";
            this.gBoxEvaluationCourse.Size = new System.Drawing.Size(179, 49);
            this.gBoxEvaluationCourse.TabIndex = 15;
            this.gBoxEvaluationCourse.TabStop = false;
            this.gBoxEvaluationCourse.Text = "Курс";
            // 
            // cBoxEvaluationCourse
            // 
            this.cBoxEvaluationCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxEvaluationCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCourseBindingSource, "NameCourse", true));
            this.cBoxEvaluationCourse.FormattingEnabled = true;
            this.cBoxEvaluationCourse.Location = new System.Drawing.Point(6, 19);
            this.cBoxEvaluationCourse.Name = "cBoxEvaluationCourse";
            this.cBoxEvaluationCourse.Size = new System.Drawing.Size(165, 21);
            this.cBoxEvaluationCourse.TabIndex = 0;
            this.cBoxEvaluationCourse.SelectedIndexChanged += new System.EventHandler(this.CBoxEvaluationCourse_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Speciality";
            this.dataGridViewTextBoxColumn3.HeaderText = "Speciality";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn4.HeaderText = "Course";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Speciality";
            this.dataGridViewComboBoxColumn1.HeaderText = "Speciality";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn5.HeaderText = "Course";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Speciality";
            this.dataGridViewComboBoxColumn2.HeaderText = "Speciality";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn6.HeaderText = "Course";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Course";
            this.dataGridViewComboBoxColumn3.HeaderText = "Course";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.ReadOnly = true;
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn7.HeaderText = "Course";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Speciality";
            this.dataGridViewTextBoxColumn8.HeaderText = "Speciality";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn9.HeaderText = "Course";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // btnExamAdd
            // 
            this.btnExamAdd.BackColor = System.Drawing.Color.White;
            this.btnExamAdd.Location = new System.Drawing.Point(432, 45);
            this.btnExamAdd.Name = "btnExamAdd";
            this.btnExamAdd.Size = new System.Drawing.Size(91, 35);
            this.btnExamAdd.TabIndex = 16;
            this.btnExamAdd.Text = "Добави";
            this.btnExamAdd.UseVisualStyleBackColor = false;
            this.btnExamAdd.Click += new System.EventHandler(this.btnExamAdd_Click);
            // 
            // tCourseBindingSource
            // 
            this.tCourseBindingSource.DataSource = typeof(University12.Classes.TCourse);
            // 
            // tSpecialityBindingSource
            // 
            this.tSpecialityBindingSource.DataSource = typeof(University12.Classes.TSpeciality);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // bsEvaluations
            // 
            this.bsEvaluations.AllowNew = false;
            this.bsEvaluations.DataSource = typeof(University12.Classes.TEvaluation);
            // 
            // tSubjectBindingSource
            // 
            this.tSubjectBindingSource.DataSource = typeof(University12.Classes.TSubject);
            // 
            // tFacultyBindingSource
            // 
            this.tFacultyBindingSource.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // FormЕvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 468);
            this.Controls.Add(this.btnExamAdd);
            this.Controls.Add(this.gBoxEvaluationCourse);
            this.Controls.Add(this.gBoxEvaluationSpeciality);
            this.Controls.Add(this.gBoxEvaluation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormЕvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценяване";
            this.Load += new System.EventHandler(this.FormEvaluations_Load);
            this.gBoxEvaluation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvaluation)).EndInit();
            this.gBoxEvaluationSpeciality.ResumeLayout(false);
            this.gBoxEvaluationCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSpecialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxEvaluation;
        private System.Windows.Forms.DataGridView dataGridViewEvaluation;
        public System.Windows.Forms.BindingSource bsEvaluations;
        private System.Windows.Forms.GroupBox gBoxEvaluationSpeciality;
        private System.Windows.Forms.ComboBox cBoxEvaluationSpeciality;
        private System.Windows.Forms.GroupBox gBoxEvaluationCourse;
        private System.Windows.Forms.ComboBox cBoxEvaluationCourse;
        private System.Windows.Forms.BindingSource tFacultyBindingSource;
        private System.Windows.Forms.BindingSource tSpecialityBindingSource;
        private System.Windows.Forms.BindingSource tCourseBindingSource;
        private System.Windows.Forms.BindingSource tSubjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Button btnExamAdd;
    }
}