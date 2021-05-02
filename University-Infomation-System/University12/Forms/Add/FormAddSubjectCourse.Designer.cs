namespace University12.Forms.Add
{
    partial class FormAddSubjectCourse
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
            this.gBoxEvaluationCourse = new System.Windows.Forms.GroupBox();
            this.cBoxSubjectCourse = new System.Windows.Forms.ComboBox();
            this.gBoxSpecialitiesCourseSemester = new System.Windows.Forms.GroupBox();
            this.cBoxSubjecSemester = new System.Windows.Forms.ComboBox();
            this.gBoxSpecialitiesCourse = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSSubjectCourse = new System.Windows.Forms.BindingSource(this.components);
            this.tCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxEvaluationCourse.SuspendLayout();
            this.gBoxSpecialitiesCourseSemester.SuspendLayout();
            this.gBoxSpecialitiesCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSSubjectCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxEvaluationCourse
            // 
            this.gBoxEvaluationCourse.Controls.Add(this.cBoxSubjectCourse);
            this.gBoxEvaluationCourse.Location = new System.Drawing.Point(7, 12);
            this.gBoxEvaluationCourse.Name = "gBoxEvaluationCourse";
            this.gBoxEvaluationCourse.Size = new System.Drawing.Size(179, 49);
            this.gBoxEvaluationCourse.TabIndex = 17;
            this.gBoxEvaluationCourse.TabStop = false;
            this.gBoxEvaluationCourse.Text = "Курс";
            // 
            // cBoxSubjectCourse
            // 
            this.cBoxSubjectCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSubjectCourse.FormattingEnabled = true;
            this.cBoxSubjectCourse.Location = new System.Drawing.Point(6, 19);
            this.cBoxSubjectCourse.Name = "cBoxSubjectCourse";
            this.cBoxSubjectCourse.Size = new System.Drawing.Size(165, 21);
            this.cBoxSubjectCourse.TabIndex = 0;
            this.cBoxSubjectCourse.SelectedIndexChanged += new System.EventHandler(this.CBoxSubjectCourse_SelectedIndexChanged);
            // 
            // gBoxSpecialitiesCourseSemester
            // 
            this.gBoxSpecialitiesCourseSemester.Controls.Add(this.cBoxSubjecSemester);
            this.gBoxSpecialitiesCourseSemester.Location = new System.Drawing.Point(199, 12);
            this.gBoxSpecialitiesCourseSemester.Name = "gBoxSpecialitiesCourseSemester";
            this.gBoxSpecialitiesCourseSemester.Size = new System.Drawing.Size(179, 49);
            this.gBoxSpecialitiesCourseSemester.TabIndex = 16;
            this.gBoxSpecialitiesCourseSemester.TabStop = false;
            this.gBoxSpecialitiesCourseSemester.Text = "Семестър";
            // 
            // cBoxSubjecSemester
            // 
            this.cBoxSubjecSemester.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSubjecSemester.FormattingEnabled = true;
            this.cBoxSubjecSemester.Location = new System.Drawing.Point(8, 19);
            this.cBoxSubjecSemester.Name = "cBoxSubjecSemester";
            this.cBoxSubjecSemester.Size = new System.Drawing.Size(165, 21);
            this.cBoxSubjecSemester.TabIndex = 0;
            this.cBoxSubjecSemester.SelectedIndexChanged += new System.EventHandler(this.CBoxSubjecSemester_SelectedIndexChanged);
            // 
            // gBoxSpecialitiesCourse
            // 
            this.gBoxSpecialitiesCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxSpecialitiesCourse.Controls.Add(this.dataGridView1);
            this.gBoxSpecialitiesCourse.Location = new System.Drawing.Point(2, 95);
            this.gBoxSpecialitiesCourse.Name = "gBoxSpecialitiesCourse";
            this.gBoxSpecialitiesCourse.Size = new System.Drawing.Size(519, 479);
            this.gBoxSpecialitiesCourse.TabIndex = 18;
            this.gBoxSpecialitiesCourse.TabStop = false;
            this.gBoxSpecialitiesCourse.Text = "Дисциплини";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.NameCourse,
            this.SubjectName,
            this.NameSemester});
            this.dataGridView1.DataSource = this.bSSubjectCourse;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(513, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameCourse
            // 
            this.NameCourse.DataPropertyName = "NameCourse";
            this.NameCourse.HeaderText = "Курс";
            this.NameCourse.Name = "NameCourse";
            this.NameCourse.ReadOnly = true;
            this.NameCourse.Width = 50;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Дисциплина";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // NameSemester
            // 
            this.NameSemester.DataPropertyName = "NameSemester";
            this.NameSemester.HeaderText = "Семестър";
            this.NameSemester.Name = "NameSemester";
            this.NameSemester.ReadOnly = true;
            this.NameSemester.Width = 60;
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.gBoxSpecialitiesCourseSemester);
            this.gBoxFilter.Controls.Add(this.gBoxEvaluationCourse);
            this.gBoxFilter.Location = new System.Drawing.Point(5, 12);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(384, 77);
            this.gBoxFilter.TabIndex = 19;
            this.gBoxFilter.TabStop = false;
            this.gBoxFilter.Text = "Филтри";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // bSSubjectCourse
            // 
            this.bSSubjectCourse.AllowNew = false;
            this.bSSubjectCourse.DataSource = typeof(University12.Classes.TSubjectCourse);
            // 
            // tCourseBindingSource
            // 
            this.tCourseBindingSource.DataSource = typeof(University12.Classes.TCourse);
            // 
            // FormAddSubjectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 578);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.gBoxSpecialitiesCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSubjectCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплини";
            this.Load += new System.EventHandler(this.FormAddSubjectCourse_Load);
            this.gBoxEvaluationCourse.ResumeLayout(false);
            this.gBoxSpecialitiesCourseSemester.ResumeLayout(false);
            this.gBoxSpecialitiesCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSSubjectCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxEvaluationCourse;
        private System.Windows.Forms.ComboBox cBoxSubjectCourse;
        private System.Windows.Forms.GroupBox gBoxSpecialitiesCourseSemester;
        private System.Windows.Forms.ComboBox cBoxSubjecSemester;
        private System.Windows.Forms.GroupBox gBoxSpecialitiesCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource bSSubjectCourse;
        private System.Windows.Forms.BindingSource tCourseBindingSource;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSemester;
    }
}