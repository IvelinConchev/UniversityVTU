namespace University12.Forms
{
    partial class FormLectures
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
            this.gBoxFormLecturesDepartments = new System.Windows.Forms.GroupBox();
            this.cBoxLecturesDepartments = new System.Windows.Forms.ComboBox();
            this.dgvLectures = new System.Windows.Forms.DataGridView();
            this.gBoxLecturesSearch = new System.Windows.Forms.GroupBox();
            this.tBoxLecturesSearch = new System.Windows.Forms.TextBox();
            this.btnLecturesSearch = new System.Windows.Forms.Button();
            this.gBoxLecturesGridLectures = new System.Windows.Forms.GroupBox();
            this.btnLectureSubject = new System.Windows.Forms.Button();
            this.btnLectureExam = new System.Windows.Forms.Button();
            this.btnLectureEvaluation = new System.Windows.Forms.Button();
            this.btnLecturesAdd = new System.Windows.Forms.Button();
            this.bsLecture = new System.Windows.Forms.BindingSource(this.components);
            this.tDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduateUniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxFormLecturesDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).BeginInit();
            this.gBoxLecturesSearch.SuspendLayout();
            this.gBoxLecturesGridLectures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFormLecturesDepartments
            // 
            this.gBoxFormLecturesDepartments.Controls.Add(this.cBoxLecturesDepartments);
            this.gBoxFormLecturesDepartments.Location = new System.Drawing.Point(12, 53);
            this.gBoxFormLecturesDepartments.Name = "gBoxFormLecturesDepartments";
            this.gBoxFormLecturesDepartments.Size = new System.Drawing.Size(232, 49);
            this.gBoxFormLecturesDepartments.TabIndex = 2;
            this.gBoxFormLecturesDepartments.TabStop = false;
            this.gBoxFormLecturesDepartments.Text = "Катедра";
            // 
            // cBoxLecturesDepartments
            // 
            this.cBoxLecturesDepartments.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxLecturesDepartments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDepartmentsBindingSource, "Name", true));
            this.cBoxLecturesDepartments.FormattingEnabled = true;
            this.cBoxLecturesDepartments.Location = new System.Drawing.Point(6, 19);
            this.cBoxLecturesDepartments.Name = "cBoxLecturesDepartments";
            this.cBoxLecturesDepartments.Size = new System.Drawing.Size(220, 21);
            this.cBoxLecturesDepartments.TabIndex = 0;
            this.cBoxLecturesDepartments.SelectedIndexChanged += new System.EventHandler(this.cBoxLecturesDepartments_SelectedIndexChanged);
            // 
            // dgvLectures
            // 
            this.dgvLectures.AllowUserToAddRows = false;
            this.dgvLectures.AllowUserToDeleteRows = false;
            this.dgvLectures.AutoGenerateColumns = false;
            this.dgvLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Department,
            this.FirstName,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.FacultyName,
            this.graduateUniversityDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgvLectures.DataSource = this.bsLecture;
            this.dgvLectures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLectures.Location = new System.Drawing.Point(3, 16);
            this.dgvLectures.Name = "dgvLectures";
            this.dgvLectures.ReadOnly = true;
            this.dgvLectures.RowHeadersWidth = 10;
            this.dgvLectures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLectures.Size = new System.Drawing.Size(620, 360);
            this.dgvLectures.TabIndex = 4;
            this.dgvLectures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLectures_CellContentClick);
            this.dgvLectures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLectures_CellDoubleClick);
            // 
            // gBoxLecturesSearch
            // 
            this.gBoxLecturesSearch.Controls.Add(this.tBoxLecturesSearch);
            this.gBoxLecturesSearch.Location = new System.Drawing.Point(250, 54);
            this.gBoxLecturesSearch.Name = "gBoxLecturesSearch";
            this.gBoxLecturesSearch.Size = new System.Drawing.Size(192, 48);
            this.gBoxLecturesSearch.TabIndex = 5;
            this.gBoxLecturesSearch.TabStop = false;
            this.gBoxLecturesSearch.Text = "Търсене";
            // 
            // tBoxLecturesSearch
            // 
            this.tBoxLecturesSearch.Location = new System.Drawing.Point(6, 19);
            this.tBoxLecturesSearch.Name = "tBoxLecturesSearch";
            this.tBoxLecturesSearch.Size = new System.Drawing.Size(180, 20);
            this.tBoxLecturesSearch.TabIndex = 0;
            // 
            // btnLecturesSearch
            // 
            this.btnLecturesSearch.BackColor = System.Drawing.Color.White;
            this.btnLecturesSearch.Location = new System.Drawing.Point(463, 65);
            this.btnLecturesSearch.Name = "btnLecturesSearch";
            this.btnLecturesSearch.Size = new System.Drawing.Size(95, 34);
            this.btnLecturesSearch.TabIndex = 6;
            this.btnLecturesSearch.Text = "Търсене";
            this.btnLecturesSearch.UseVisualStyleBackColor = false;
            this.btnLecturesSearch.Click += new System.EventHandler(this.BtnLecturesSearch_Click);
            // 
            // gBoxLecturesGridLectures
            // 
            this.gBoxLecturesGridLectures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLecturesGridLectures.Controls.Add(this.dgvLectures);
            this.gBoxLecturesGridLectures.Location = new System.Drawing.Point(-1, 108);
            this.gBoxLecturesGridLectures.Name = "gBoxLecturesGridLectures";
            this.gBoxLecturesGridLectures.Size = new System.Drawing.Size(626, 379);
            this.gBoxLecturesGridLectures.TabIndex = 7;
            this.gBoxLecturesGridLectures.TabStop = false;
            this.gBoxLecturesGridLectures.Text = "Преподаватели";
            // 
            // btnLectureSubject
            // 
            this.btnLectureSubject.BackColor = System.Drawing.Color.White;
            this.btnLectureSubject.Location = new System.Drawing.Point(12, 12);
            this.btnLectureSubject.Name = "btnLectureSubject";
            this.btnLectureSubject.Size = new System.Drawing.Size(91, 35);
            this.btnLectureSubject.TabIndex = 9;
            this.btnLectureSubject.Text = "Дисциплини";
            this.btnLectureSubject.UseVisualStyleBackColor = false;
            this.btnLectureSubject.Click += new System.EventHandler(this.BtnLectureSubject_Click);
            // 
            // btnLectureExam
            // 
            this.btnLectureExam.BackColor = System.Drawing.Color.White;
            this.btnLectureExam.Location = new System.Drawing.Point(109, 11);
            this.btnLectureExam.Name = "btnLectureExam";
            this.btnLectureExam.Size = new System.Drawing.Size(93, 35);
            this.btnLectureExam.TabIndex = 10;
            this.btnLectureExam.Text = "Изпити";
            this.btnLectureExam.UseVisualStyleBackColor = false;
            this.btnLectureExam.Click += new System.EventHandler(this.BtnLectureExam_Click);
            // 
            // btnLectureEvaluation
            // 
            this.btnLectureEvaluation.BackColor = System.Drawing.Color.White;
            this.btnLectureEvaluation.Location = new System.Drawing.Point(208, 11);
            this.btnLectureEvaluation.Name = "btnLectureEvaluation";
            this.btnLectureEvaluation.Size = new System.Drawing.Size(95, 34);
            this.btnLectureEvaluation.TabIndex = 11;
            this.btnLectureEvaluation.Text = "Оценки";
            this.btnLectureEvaluation.UseVisualStyleBackColor = false;
            this.btnLectureEvaluation.Click += new System.EventHandler(this.BtnLectureEvaluation_Click);
            // 
            // btnLecturesAdd
            // 
            this.btnLecturesAdd.BackColor = System.Drawing.Color.White;
            this.btnLecturesAdd.Location = new System.Drawing.Point(309, 12);
            this.btnLecturesAdd.Name = "btnLecturesAdd";
            this.btnLecturesAdd.Size = new System.Drawing.Size(91, 34);
            this.btnLecturesAdd.TabIndex = 23;
            this.btnLecturesAdd.Text = "Добави";
            this.btnLecturesAdd.UseVisualStyleBackColor = false;
            this.btnLecturesAdd.Click += new System.EventHandler(this.BtnLecturesAdd_Click);
            // 
            // bsLecture
            // 
            this.bsLecture.AllowNew = false;
            this.bsLecture.DataSource = typeof(University12.Classes.TLecture);
            // 
            // tDepartmentsBindingSource
            // 
            this.tDepartmentsBindingSource.AllowNew = false;
            this.tDepartmentsBindingSource.DataSource = typeof(University12.Classes.TDepartments);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "№";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "DepartmentName";
            this.Department.HeaderText = "Катедра";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Име";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 50;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Презиме";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Титла";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 60;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 40;
            // 
            // FacultyName
            // 
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "Факултет";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // graduateUniversityDataGridViewTextBoxColumn
            // 
            this.graduateUniversityDataGridViewTextBoxColumn.DataPropertyName = "GraduateUniversity";
            this.graduateUniversityDataGridViewTextBoxColumn.HeaderText = "Зав.Университет";
            this.graduateUniversityDataGridViewTextBoxColumn.Name = "graduateUniversityDataGridViewTextBoxColumn";
            this.graduateUniversityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Град";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 486);
            this.Controls.Add(this.btnLecturesAdd);
            this.Controls.Add(this.btnLectureEvaluation);
            this.Controls.Add(this.btnLectureExam);
            this.Controls.Add(this.btnLectureSubject);
            this.Controls.Add(this.gBoxLecturesGridLectures);
            this.Controls.Add(this.btnLecturesSearch);
            this.Controls.Add(this.gBoxLecturesSearch);
            this.Controls.Add(this.gBoxFormLecturesDepartments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLectures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватели";
            this.Load += new System.EventHandler(this.FormLectures_Load);
            this.DoubleClick += new System.EventHandler(this.FormLectures_DoubleClick);
            this.gBoxFormLecturesDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).EndInit();
            this.gBoxLecturesSearch.ResumeLayout(false);
            this.gBoxLecturesSearch.PerformLayout();
            this.gBoxLecturesGridLectures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxFormLecturesDepartments;
        private System.Windows.Forms.ComboBox cBoxLecturesDepartments;
        private System.Windows.Forms.DataGridView dgvLectures;
        private System.Windows.Forms.GroupBox gBoxLecturesSearch;
        private System.Windows.Forms.TextBox tBoxLecturesSearch;
        private System.Windows.Forms.Button btnLecturesSearch;
        private System.Windows.Forms.GroupBox gBoxLecturesGridLectures;
        private System.Windows.Forms.Button btnLectureSubject;
        private System.Windows.Forms.Button btnLectureExam;
        private System.Windows.Forms.Button btnLectureEvaluation;
        private System.Windows.Forms.Button btnLecturesAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departments;
        public System.Windows.Forms.BindingSource tDepartmentsBindingSource;
        public System.Windows.Forms.BindingSource bsLecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduateUniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}