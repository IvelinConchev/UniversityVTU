namespace University12.Forms
{
    partial class FormSubjects
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
            this.gBoxSubjects = new System.Windows.Forms.GroupBox();
            this.dgSubjects = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compulsoryDisciplineDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facultativeDisciplineDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsSubjects = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxSubjectsFaculty = new System.Windows.Forms.GroupBox();
            this.cBoxSubjectsFaculty = new System.Windows.Forms.ComboBox();
            this.tFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxSubjectsDepartments = new System.Windows.Forms.GroupBox();
            this.cBoxSubjectsDeparments = new System.Windows.Forms.ComboBox();
            this.tDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubjectSearch = new System.Windows.Forms.Button();
            this.gBoxSubjectSearch = new System.Windows.Forms.GroupBox();
            this.txtBoxSubjectSearch = new System.Windows.Forms.TextBox();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjects)).BeginInit();
            this.gBoxSubjectsFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).BeginInit();
            this.gBoxSubjectsDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).BeginInit();
            this.gBoxSubjectSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSubjects
            // 
            this.gBoxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxSubjects.Controls.Add(this.dgSubjects);
            this.gBoxSubjects.Location = new System.Drawing.Point(2, 67);
            this.gBoxSubjects.Name = "gBoxSubjects";
            this.gBoxSubjects.Size = new System.Drawing.Size(943, 460);
            this.gBoxSubjects.TabIndex = 0;
            this.gBoxSubjects.TabStop = false;
            this.gBoxSubjects.Text = "Дисциплина";
            // 
            // dgSubjects
            // 
            this.dgSubjects.AllowUserToAddRows = false;
            this.dgSubjects.AllowUserToDeleteRows = false;
            this.dgSubjects.AutoGenerateColumns = false;
            this.dgSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.SubjectName,
            this.DepartmentsName,
            this.FacultyName,
            this.compulsoryDisciplineDataGridViewCheckBoxColumn,
            this.facultativeDisciplineDataGridViewCheckBoxColumn});
            this.dgSubjects.DataSource = this.bsSubjects;
            this.dgSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSubjects.Location = new System.Drawing.Point(3, 16);
            this.dgSubjects.Name = "dgSubjects";
            this.dgSubjects.ReadOnly = true;
            this.dgSubjects.RowHeadersWidth = 10;
            this.dgSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubjects.Size = new System.Drawing.Size(937, 441);
            this.dgSubjects.TabIndex = 0;
            this.dgSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgSubjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSubjects_CellDoubleClick);
            this.dgSubjects.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgSubjects_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Дисциплина";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // DepartmentsName
            // 
            this.DepartmentsName.DataPropertyName = "DepartmentsName";
            this.DepartmentsName.HeaderText = "Катедра";
            this.DepartmentsName.Name = "DepartmentsName";
            this.DepartmentsName.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "Факултет";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // compulsoryDisciplineDataGridViewCheckBoxColumn
            // 
            this.compulsoryDisciplineDataGridViewCheckBoxColumn.DataPropertyName = "CompulsoryDiscipline";
            this.compulsoryDisciplineDataGridViewCheckBoxColumn.HeaderText = "Задължителни дисциплини";
            this.compulsoryDisciplineDataGridViewCheckBoxColumn.Name = "compulsoryDisciplineDataGridViewCheckBoxColumn";
            this.compulsoryDisciplineDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // facultativeDisciplineDataGridViewCheckBoxColumn
            // 
            this.facultativeDisciplineDataGridViewCheckBoxColumn.DataPropertyName = "FacultativeDiscipline";
            this.facultativeDisciplineDataGridViewCheckBoxColumn.HeaderText = "Факултативни дисциплини";
            this.facultativeDisciplineDataGridViewCheckBoxColumn.Name = "facultativeDisciplineDataGridViewCheckBoxColumn";
            this.facultativeDisciplineDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bsSubjects
            // 
            this.bsSubjects.AllowNew = true;
            this.bsSubjects.DataSource = typeof(University12.Classes.TSubject);
            // 
            // gBoxSubjectsFaculty
            // 
            this.gBoxSubjectsFaculty.Controls.Add(this.cBoxSubjectsFaculty);
            this.gBoxSubjectsFaculty.Location = new System.Drawing.Point(5, 12);
            this.gBoxSubjectsFaculty.Name = "gBoxSubjectsFaculty";
            this.gBoxSubjectsFaculty.Size = new System.Drawing.Size(194, 49);
            this.gBoxSubjectsFaculty.TabIndex = 1;
            this.gBoxSubjectsFaculty.TabStop = false;
            this.gBoxSubjectsFaculty.Text = "Факултет";
            // 
            // cBoxSubjectsFaculty
            // 
            this.cBoxSubjectsFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSubjectsFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tFacultyBindingSource, "FacultyName", true));
            this.cBoxSubjectsFaculty.FormattingEnabled = true;
            this.cBoxSubjectsFaculty.Location = new System.Drawing.Point(16, 19);
            this.cBoxSubjectsFaculty.Name = "cBoxSubjectsFaculty";
            this.cBoxSubjectsFaculty.Size = new System.Drawing.Size(157, 21);
            this.cBoxSubjectsFaculty.TabIndex = 0;
            this.cBoxSubjectsFaculty.SelectedIndexChanged += new System.EventHandler(this.CBoxSubjectsFaculty_SelectedIndexChanged);
            // 
            // tFacultyBindingSource
            // 
            this.tFacultyBindingSource.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // gBoxSubjectsDepartments
            // 
            this.gBoxSubjectsDepartments.Controls.Add(this.cBoxSubjectsDeparments);
            this.gBoxSubjectsDepartments.Location = new System.Drawing.Point(202, 12);
            this.gBoxSubjectsDepartments.Name = "gBoxSubjectsDepartments";
            this.gBoxSubjectsDepartments.Size = new System.Drawing.Size(194, 49);
            this.gBoxSubjectsDepartments.TabIndex = 2;
            this.gBoxSubjectsDepartments.TabStop = false;
            this.gBoxSubjectsDepartments.Text = "Катедра";
            // 
            // cBoxSubjectsDeparments
            // 
            this.cBoxSubjectsDeparments.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSubjectsDeparments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDepartmentsBindingSource, "Name", true));
            this.cBoxSubjectsDeparments.FormattingEnabled = true;
            this.cBoxSubjectsDeparments.Location = new System.Drawing.Point(16, 19);
            this.cBoxSubjectsDeparments.Name = "cBoxSubjectsDeparments";
            this.cBoxSubjectsDeparments.Size = new System.Drawing.Size(157, 21);
            this.cBoxSubjectsDeparments.TabIndex = 0;
            this.cBoxSubjectsDeparments.SelectedIndexChanged += new System.EventHandler(this.CBoxSubjectsDeparments_SelectedIndexChanged);
            // 
            // tDepartmentsBindingSource
            // 
            this.tDepartmentsBindingSource.DataSource = typeof(University12.Classes.TDepartments);
            // 
            // btnSubjectSearch
            // 
            this.btnSubjectSearch.BackColor = System.Drawing.Color.White;
            this.btnSubjectSearch.Location = new System.Drawing.Point(630, 23);
            this.btnSubjectSearch.Name = "btnSubjectSearch";
            this.btnSubjectSearch.Size = new System.Drawing.Size(91, 35);
            this.btnSubjectSearch.TabIndex = 3;
            this.btnSubjectSearch.Text = "Търсене";
            this.btnSubjectSearch.UseVisualStyleBackColor = false;
            this.btnSubjectSearch.Click += new System.EventHandler(this.BtnSubjectSearch_Click);
            // 
            // gBoxSubjectSearch
            // 
            this.gBoxSubjectSearch.Controls.Add(this.txtBoxSubjectSearch);
            this.gBoxSubjectSearch.Location = new System.Drawing.Point(402, 12);
            this.gBoxSubjectSearch.Name = "gBoxSubjectSearch";
            this.gBoxSubjectSearch.Size = new System.Drawing.Size(222, 49);
            this.gBoxSubjectSearch.TabIndex = 4;
            this.gBoxSubjectSearch.TabStop = false;
            this.gBoxSubjectSearch.Text = "Търсене";
            // 
            // txtBoxSubjectSearch
            // 
            this.txtBoxSubjectSearch.Location = new System.Drawing.Point(6, 19);
            this.txtBoxSubjectSearch.Name = "txtBoxSubjectSearch";
            this.txtBoxSubjectSearch.Size = new System.Drawing.Size(210, 20);
            this.txtBoxSubjectSearch.TabIndex = 0;
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.BackColor = System.Drawing.Color.White;
            this.btnSubjectAdd.Location = new System.Drawing.Point(727, 23);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(91, 35);
            this.btnSubjectAdd.TabIndex = 5;
            this.btnSubjectAdd.Text = "Добавяне";
            this.btnSubjectAdd.UseVisualStyleBackColor = false;
            this.btnSubjectAdd.Click += new System.EventHandler(this.BtnSubjectAdd_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Faculty";
            this.dataGridViewTextBoxColumn1.HeaderText = "Факултет";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departments";
            this.dataGridViewTextBoxColumn2.FillWeight = 155.8442F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Катедра";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Faculty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Факултет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.btnSubjectAdd);
            this.Controls.Add(this.gBoxSubjectSearch);
            this.Controls.Add(this.btnSubjectSearch);
            this.Controls.Add(this.gBoxSubjectsDepartments);
            this.Controls.Add(this.gBoxSubjectsFaculty);
            this.Controls.Add(this.gBoxSubjects);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплини";
            this.Load += new System.EventHandler(this.FormSubjects_Load);
            this.gBoxSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjects)).EndInit();
            this.gBoxSubjectsFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tFacultyBindingSource)).EndInit();
            this.gBoxSubjectsDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).EndInit();
            this.gBoxSubjectSearch.ResumeLayout(false);
            this.gBoxSubjectSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSubjects;
        private System.Windows.Forms.DataGridView dgSubjects;
        private System.Windows.Forms.GroupBox gBoxSubjectsFaculty;
        private System.Windows.Forms.ComboBox cBoxSubjectsFaculty;
        private System.Windows.Forms.GroupBox gBoxSubjectsDepartments;
        private System.Windows.Forms.ComboBox cBoxSubjectsDeparments;
        private System.Windows.Forms.Button btnSubjectSearch;
        private System.Windows.Forms.GroupBox gBoxSubjectSearch;
        private System.Windows.Forms.TextBox txtBoxSubjectSearch;
        public System.Windows.Forms.BindingSource bsSubjects;
        private System.Windows.Forms.BindingSource tFacultyBindingSource;
        private System.Windows.Forms.BindingSource tDepartmentsBindingSource;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compulsoryDisciplineDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn facultativeDisciplineDataGridViewCheckBoxColumn;
    }
}