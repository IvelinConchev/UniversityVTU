namespace University12.Forms
{
    partial class FormCoursес
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
            this.gBoxCoursesGridCourses = new System.Windows.Forms.GroupBox();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.btnCoursesAdd = new System.Windows.Forms.Button();
            this.nameCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCourse = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxCoursesGridCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxCoursesGridCourses
            // 
            this.gBoxCoursesGridCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxCoursesGridCourses.Controls.Add(this.dataGridViewCourses);
            this.gBoxCoursesGridCourses.Location = new System.Drawing.Point(1, 77);
            this.gBoxCoursesGridCourses.Name = "gBoxCoursesGridCourses";
            this.gBoxCoursesGridCourses.Size = new System.Drawing.Size(399, 342);
            this.gBoxCoursesGridCourses.TabIndex = 1;
            this.gBoxCoursesGridCourses.TabStop = false;
            this.gBoxCoursesGridCourses.Text = "Курс";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AllowUserToDeleteRows = false;
            this.dataGridViewCourses.AutoGenerateColumns = false;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCourseDataGridViewTextBoxColumn});
            this.dataGridViewCourses.DataSource = this.bsCourse;
            this.dataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCourses.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.RowHeadersWidth = 10;
            this.dataGridViewCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourses.Size = new System.Drawing.Size(393, 323);
            this.dataGridViewCourses.TabIndex = 0;
            this.dataGridViewCourses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellDoubleClick);
            // 
            // btnCoursesAdd
            // 
            this.btnCoursesAdd.BackColor = System.Drawing.Color.White;
            this.btnCoursesAdd.Location = new System.Drawing.Point(300, 28);
            this.btnCoursesAdd.Name = "btnCoursesAdd";
            this.btnCoursesAdd.Size = new System.Drawing.Size(91, 35);
            this.btnCoursesAdd.TabIndex = 3;
            this.btnCoursesAdd.Text = "Добави";
            this.btnCoursesAdd.UseVisualStyleBackColor = false;
            this.btnCoursesAdd.Click += new System.EventHandler(this.BtnCoursesAdd_Click);
            // 
            // nameCourseDataGridViewTextBoxColumn
            // 
            this.nameCourseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCourseDataGridViewTextBoxColumn.DataPropertyName = "NameCourse";
            this.nameCourseDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameCourseDataGridViewTextBoxColumn.Name = "nameCourseDataGridViewTextBoxColumn";
            this.nameCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCourse
            // 
            this.bsCourse.AllowNew = false;
            this.bsCourse.DataSource = typeof(University12.Classes.TCourse);
            // 
            // FormCoursес
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 421);
            this.Controls.Add(this.btnCoursesAdd);
            this.Controls.Add(this.gBoxCoursesGridCourses);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCoursес";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс";
            this.Load += new System.EventHandler(this.FormCoursес_Load);
            this.gBoxCoursesGridCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxCoursesGridCourses;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnCoursesAdd;
        public System.Windows.Forms.BindingSource bsCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCourseDataGridViewTextBoxColumn;
    }
}