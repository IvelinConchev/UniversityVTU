namespace University12.Forms.Add
{
    partial class FormAddElectiveSubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGStudentsCourse = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudentSubjects = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.gBoxFormElectiveSubjects = new System.Windows.Forms.GroupBox();
            this.cBoxFormElectiveSubjects = new System.Windows.Forms.ComboBox();
            this.gBoxFormElectiveSubjectsSpeciality = new System.Windows.Forms.GroupBox();
            this.cBoxFormElectiveSubjectsSpeciality = new System.Windows.Forms.ComboBox();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameSpecialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGStudentsCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudentSubjects)).BeginInit();
            this.gBoxFormElectiveSubjects.SuspendLayout();
            this.gBoxFormElectiveSubjectsSpeciality.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dGStudentsCourse);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свободно избираеми дисциплини";
            // 
            // dGStudentsCourse
            // 
            this.dGStudentsCourse.AllowUserToAddRows = false;
            this.dGStudentsCourse.AllowUserToDeleteRows = false;
            this.dGStudentsCourse.AutoGenerateColumns = false;
            this.dGStudentsCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGStudentsCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameCourseDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.nameSpecialityDataGridViewTextBoxColumn,
            this.colSelected});
            this.dGStudentsCourse.DataSource = this.bsStudentSubjects;
            this.dGStudentsCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGStudentsCourse.Location = new System.Drawing.Point(3, 16);
            this.dGStudentsCourse.Name = "dGStudentsCourse";
            this.dGStudentsCourse.ReadOnly = true;
            this.dGStudentsCourse.RowHeadersWidth = 10;
            this.dGStudentsCourse.Size = new System.Drawing.Size(643, 386);
            this.dGStudentsCourse.TabIndex = 0;
            this.dGStudentsCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dGStudentsCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dGStudentsCourse.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGStudentsCourse_RowPostPaint);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // bsStudentSubjects
            // 
            this.bsStudentSubjects.AllowNew = false;
            this.bsStudentSubjects.DataSource = typeof(University12.Classes.TStudentCourse);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveSubject.Location = new System.Drawing.Point(564, 26);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(74, 29);
            this.btnSaveSubject.TabIndex = 2;
            this.btnSaveSubject.Text = "Запис";
            this.btnSaveSubject.UseVisualStyleBackColor = false;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // gBoxFormElectiveSubjects
            // 
            this.gBoxFormElectiveSubjects.Controls.Add(this.cBoxFormElectiveSubjects);
            this.gBoxFormElectiveSubjects.Location = new System.Drawing.Point(12, 12);
            this.gBoxFormElectiveSubjects.Name = "gBoxFormElectiveSubjects";
            this.gBoxFormElectiveSubjects.Size = new System.Drawing.Size(218, 49);
            this.gBoxFormElectiveSubjects.TabIndex = 3;
            this.gBoxFormElectiveSubjects.TabStop = false;
            this.gBoxFormElectiveSubjects.Text = "Курс";
            // 
            // cBoxFormElectiveSubjects
            // 
            this.cBoxFormElectiveSubjects.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFormElectiveSubjects.FormattingEnabled = true;
            this.cBoxFormElectiveSubjects.Location = new System.Drawing.Point(6, 19);
            this.cBoxFormElectiveSubjects.Name = "cBoxFormElectiveSubjects";
            this.cBoxFormElectiveSubjects.Size = new System.Drawing.Size(200, 21);
            this.cBoxFormElectiveSubjects.TabIndex = 0;
            this.cBoxFormElectiveSubjects.SelectedIndexChanged += new System.EventHandler(this.cBoxFormElectiveSubjects_SelectedIndexChanged);
            // 
            // gBoxFormElectiveSubjectsSpeciality
            // 
            this.gBoxFormElectiveSubjectsSpeciality.Controls.Add(this.cBoxFormElectiveSubjectsSpeciality);
            this.gBoxFormElectiveSubjectsSpeciality.Location = new System.Drawing.Point(236, 12);
            this.gBoxFormElectiveSubjectsSpeciality.Name = "gBoxFormElectiveSubjectsSpeciality";
            this.gBoxFormElectiveSubjectsSpeciality.Size = new System.Drawing.Size(222, 49);
            this.gBoxFormElectiveSubjectsSpeciality.TabIndex = 4;
            this.gBoxFormElectiveSubjectsSpeciality.TabStop = false;
            this.gBoxFormElectiveSubjectsSpeciality.Text = "Дисциплини";
            // 
            // cBoxFormElectiveSubjectsSpeciality
            // 
            this.cBoxFormElectiveSubjectsSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxFormElectiveSubjectsSpeciality.FormattingEnabled = true;
            this.cBoxFormElectiveSubjectsSpeciality.Location = new System.Drawing.Point(6, 19);
            this.cBoxFormElectiveSubjectsSpeciality.Name = "cBoxFormElectiveSubjectsSpeciality";
            this.cBoxFormElectiveSubjectsSpeciality.Size = new System.Drawing.Size(211, 21);
            this.cBoxFormElectiveSubjectsSpeciality.TabIndex = 0;
            this.cBoxFormElectiveSubjectsSpeciality.SelectedIndexChanged += new System.EventHandler(this.cBoxFormElectiveSubjectsSpeciality_SelectedIndexChanged);
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameCourseDataGridViewTextBoxColumn
            // 
            this.nameCourseDataGridViewTextBoxColumn.DataPropertyName = "NameCourse";
            this.nameCourseDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.nameCourseDataGridViewTextBoxColumn.Name = "nameCourseDataGridViewTextBoxColumn";
            this.nameCourseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameCourseDataGridViewTextBoxColumn.Width = 75;
            // 
            // colSelected
            // 
            this.colSelected.DataPropertyName = "Selected";
            this.colSelected.HeaderText = "Избор";
            this.colSelected.Name = "colSelected";
            this.colSelected.ReadOnly = true;
            this.colSelected.Width = 50;
            // 
            // nameSpecialityDataGridViewTextBoxColumn
            // 
            this.nameSpecialityDataGridViewTextBoxColumn.DataPropertyName = "NameSpeciality";
            this.nameSpecialityDataGridViewTextBoxColumn.HeaderText = "Специалност";
            this.nameSpecialityDataGridViewTextBoxColumn.Name = "nameSpecialityDataGridViewTextBoxColumn";
            this.nameSpecialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // FormAddElectiveSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.Controls.Add(this.gBoxFormElectiveSubjectsSpeciality);
            this.Controls.Add(this.gBoxFormElectiveSubjects);
            this.Controls.Add(this.btnSaveSubject);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddElectiveSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Свободно избираеми дисциплини";
            this.Load += new System.EventHandler(this.FormAddElectiveSubject_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGStudentsCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudentSubjects)).EndInit();
            this.gBoxFormElectiveSubjects.ResumeLayout(false);
            this.gBoxFormElectiveSubjectsSpeciality.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGStudentsCourse;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.GroupBox gBoxFormElectiveSubjects;
        private System.Windows.Forms.ComboBox cBoxFormElectiveSubjects;
        private System.Windows.Forms.GroupBox gBoxFormElectiveSubjectsSpeciality;
        private System.Windows.Forms.ComboBox cBoxFormElectiveSubjectsSpeciality;
        public System.Windows.Forms.BindingSource bsStudentSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSpecialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
    }
}