namespace University12.Forms
{
    partial class FormFaculties
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
            this.dgFaculties = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFaculties = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFaculties = new System.Windows.Forms.GroupBox();
            this.btnFacultyAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tStripMenuIDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.tStripMenuLecture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox9 = new System.Windows.Forms.ToolStripComboBox();
            this.tStripMenuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox8 = new System.Windows.Forms.ToolStripComboBox();
            this.tStripMenuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.tStripMenuSemester = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox7 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuExam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox6 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuIEvaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuSpeciality = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox11 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuFormEducation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox12 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox13 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox10 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaculties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaculties)).BeginInit();
            this.gBoxFaculties.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFaculties
            // 
            this.dgFaculties.AllowUserToAddRows = false;
            this.dgFaculties.AllowUserToDeleteRows = false;
            this.dgFaculties.AutoGenerateColumns = false;
            this.dgFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaculties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.facultyNameDataGridViewTextBoxColumn,
            this.DeanName});
            this.dgFaculties.DataSource = this.bsFaculties;
            this.dgFaculties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFaculties.Location = new System.Drawing.Point(3, 16);
            this.dgFaculties.Name = "dgFaculties";
            this.dgFaculties.ReadOnly = true;
            this.dgFaculties.RowHeadersWidth = 10;
            this.dgFaculties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFaculties.Size = new System.Drawing.Size(1000, 491);
            this.dgFaculties.TabIndex = 2;
            this.dgFaculties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgFaculties.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgFaculties_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // facultyNameDataGridViewTextBoxColumn
            // 
            this.facultyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultyNameDataGridViewTextBoxColumn.DataPropertyName = "FacultyName";
            this.facultyNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.facultyNameDataGridViewTextBoxColumn.Name = "facultyNameDataGridViewTextBoxColumn";
            this.facultyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeanName
            // 
            this.DeanName.DataPropertyName = "DeanName";
            this.DeanName.HeaderText = "Декан";
            this.DeanName.Name = "DeanName";
            this.DeanName.ReadOnly = true;
            this.DeanName.Width = 120;
            // 
            // bsFaculties
            // 
            this.bsFaculties.AllowNew = false;
            this.bsFaculties.DataSource = typeof(University12.Classes.TFaculty);
            // 
            // gBoxFaculties
            // 
            this.gBoxFaculties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxFaculties.Controls.Add(this.dgFaculties);
            this.gBoxFaculties.Location = new System.Drawing.Point(6, 98);
            this.gBoxFaculties.Name = "gBoxFaculties";
            this.gBoxFaculties.Size = new System.Drawing.Size(1006, 510);
            this.gBoxFaculties.TabIndex = 5;
            this.gBoxFaculties.TabStop = false;
            this.gBoxFaculties.Text = "Факултети";
            // 
            // btnFacultyAdd
            // 
            this.btnFacultyAdd.BackColor = System.Drawing.Color.White;
            this.btnFacultyAdd.Location = new System.Drawing.Point(904, 57);
            this.btnFacultyAdd.Name = "btnFacultyAdd";
            this.btnFacultyAdd.Size = new System.Drawing.Size(91, 35);
            this.btnFacultyAdd.TabIndex = 8;
            this.btnFacultyAdd.Text = "Добавяне";
            this.btnFacultyAdd.UseVisualStyleBackColor = false;
            this.btnFacultyAdd.Click += new System.EventHandler(this.BtnFacultyAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuIDepartment,
            this.tStripMenuLecture,
            this.toolStripMenuItem2,
            this.tStripMenuStudent,
            this.tStripMenuCourse,
            this.tStripMenuSemester,
            this.toolStripMenuExam,
            this.toolStripMenuIEvaluation,
            this.toolStripMenuSpeciality,
            this.toolStripMenuFormEducation,
            this.toolStripMenuItem1,
            this.toolStripComboBox10});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tStripMenuIDepartment
            // 
            this.tStripMenuIDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.tStripMenuIDepartment.Name = "tStripMenuIDepartment";
            this.tStripMenuIDepartment.Size = new System.Drawing.Size(63, 23);
            this.tStripMenuIDepartment.Text = "Катедри";
            this.tStripMenuIDepartment.Click += new System.EventHandler(this.TStripMenuIDepartment_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.Click += new System.EventHandler(this.ToolStripComboBox2_Click_1);
            // 
            // tStripMenuLecture
            // 
            this.tStripMenuLecture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.tStripMenuLecture.Name = "tStripMenuLecture";
            this.tStripMenuLecture.Size = new System.Drawing.Size(104, 23);
            this.tStripMenuLecture.Text = "Преподаватели";
            this.tStripMenuLecture.Click += new System.EventHandler(this.TStripMenuLecture_Click);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox9});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(89, 23);
            this.toolStripMenuItem2.Text = "Дисциплини";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click_1);
            // 
            // toolStripComboBox9
            // 
            this.toolStripComboBox9.Name = "toolStripComboBox9";
            this.toolStripComboBox9.Size = new System.Drawing.Size(121, 23);
            // 
            // tStripMenuStudent
            // 
            this.tStripMenuStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox8});
            this.tStripMenuStudent.Name = "tStripMenuStudent";
            this.tStripMenuStudent.Size = new System.Drawing.Size(69, 23);
            this.tStripMenuStudent.Text = "Студенти";
            this.tStripMenuStudent.Click += new System.EventHandler(this.TStripMenuStudent_Click);
            // 
            // toolStripComboBox8
            // 
            this.toolStripComboBox8.Name = "toolStripComboBox8";
            this.toolStripComboBox8.Size = new System.Drawing.Size(121, 23);
            // 
            // tStripMenuCourse
            // 
            this.tStripMenuCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5});
            this.tStripMenuCourse.Name = "tStripMenuCourse";
            this.tStripMenuCourse.Size = new System.Drawing.Size(45, 23);
            this.tStripMenuCourse.Text = "Курс";
            this.tStripMenuCourse.Click += new System.EventHandler(this.TStripMenuCourse_Click);
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 23);
            // 
            // tStripMenuSemester
            // 
            this.tStripMenuSemester.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox7});
            this.tStripMenuSemester.Name = "tStripMenuSemester";
            this.tStripMenuSemester.Size = new System.Drawing.Size(73, 23);
            this.tStripMenuSemester.Text = "Семестър";
            this.tStripMenuSemester.Click += new System.EventHandler(this.TStripMenuSemester_Click);
            // 
            // toolStripComboBox7
            // 
            this.toolStripComboBox7.Name = "toolStripComboBox7";
            this.toolStripComboBox7.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuExam
            // 
            this.toolStripMenuExam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox6});
            this.toolStripMenuExam.Name = "toolStripMenuExam";
            this.toolStripMenuExam.Size = new System.Drawing.Size(123, 23);
            this.toolStripMenuExam.Text = "Изпитни резултати";
            this.toolStripMenuExam.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // toolStripComboBox6
            // 
            this.toolStripComboBox6.Name = "toolStripComboBox6";
            this.toolStripComboBox6.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuIEvaluation
            // 
            this.toolStripMenuIEvaluation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4});
            this.toolStripMenuIEvaluation.Name = "toolStripMenuIEvaluation";
            this.toolStripMenuIEvaluation.Size = new System.Drawing.Size(79, 23);
            this.toolStripMenuIEvaluation.Text = "Оценяване";
            this.toolStripMenuIEvaluation.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuSpeciality
            // 
            this.toolStripMenuSpeciality.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox11});
            this.toolStripMenuSpeciality.Name = "toolStripMenuSpeciality";
            this.toolStripMenuSpeciality.Size = new System.Drawing.Size(92, 23);
            this.toolStripMenuSpeciality.Text = "Специалност";
            this.toolStripMenuSpeciality.Click += new System.EventHandler(this.ToolStripMenuSpeciality_Click);
            // 
            // toolStripComboBox11
            // 
            this.toolStripComboBox11.Name = "toolStripComboBox11";
            this.toolStripComboBox11.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuFormEducation
            // 
            this.toolStripMenuFormEducation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox12});
            this.toolStripMenuFormEducation.Name = "toolStripMenuFormEducation";
            this.toolStripMenuFormEducation.Size = new System.Drawing.Size(129, 23);
            this.toolStripMenuFormEducation.Text = "Форма на обучение";
            this.toolStripMenuFormEducation.Click += new System.EventHandler(this.ToolStripMenuFormEducation_Click);
            // 
            // toolStripComboBox12
            // 
            this.toolStripComboBox12.Name = "toolStripComboBox12";
            this.toolStripComboBox12.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox13});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 23);
            this.toolStripMenuItem1.Text = "Образователна степен";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click_1);
            // 
            // toolStripComboBox13
            // 
            this.toolStripComboBox13.Name = "toolStripComboBox13";
            this.toolStripComboBox13.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripComboBox10
            // 
            this.toolStripComboBox10.Name = "toolStripComboBox10";
            this.toolStripComboBox10.Size = new System.Drawing.Size(121, 23);
            // 
            // FormFaculties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 611);
            this.Controls.Add(this.btnFacultyAdd);
            this.Controls.Add(this.gBoxFaculties);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFaculties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факултети";
            this.Load += new System.EventHandler(this.FormFaculties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFaculties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaculties)).EndInit();
            this.gBoxFaculties.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgFaculties;
        private System.Windows.Forms.GroupBox gBoxFaculties;
        private System.Windows.Forms.Button btnFacultyAdd;
        public System.Windows.Forms.BindingSource bsFaculties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuIDepartment;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuLecture;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuCourse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExam;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSemester;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox7;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuStudent;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIEvaluation;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSpeciality;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox11;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFormEducation;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox13;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeanName;
    }
}