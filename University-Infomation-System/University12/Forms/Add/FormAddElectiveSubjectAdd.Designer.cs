namespace University12.Forms.Add
{
    partial class FormAddElectiveSubjectAdd
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
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.cBoxElectiveSubject = new System.Windows.Forms.CheckBox();
            this.gBoxElectiveSubjectSubject = new System.Windows.Forms.GroupBox();
            this.cBoxElectiveSubjectSubject = new System.Windows.Forms.ComboBox();
            this.gBoxElectiveSubjectCourse = new System.Windows.Forms.GroupBox();
            this.cBoxElectiveSubjectCourse = new System.Windows.Forms.ComboBox();
            this.gBoxElectiveSubjectStudent = new System.Windows.Forms.GroupBox();
            this.cBoxElectiveSubjectStudent = new System.Windows.Forms.ComboBox();
            this.bSStudentCourse = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxElectiveSubjectSubject.SuspendLayout();
            this.gBoxElectiveSubjectCourse.SuspendLayout();
            this.gBoxElectiveSubjectStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSStudentCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveSubject.Location = new System.Drawing.Point(277, 65);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(99, 40);
            this.btnSaveSubject.TabIndex = 3;
            this.btnSaveSubject.Text = "Запис";
            this.btnSaveSubject.UseVisualStyleBackColor = false;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // cBoxElectiveSubject
            // 
            this.cBoxElectiveSubject.AutoSize = true;
            this.cBoxElectiveSubject.Location = new System.Drawing.Point(233, 137);
            this.cBoxElectiveSubject.Name = "cBoxElectiveSubject";
            this.cBoxElectiveSubject.Size = new System.Drawing.Size(197, 17);
            this.cBoxElectiveSubject.TabIndex = 4;
            this.cBoxElectiveSubject.Text = "Свободно избираеми дисциплини";
            this.cBoxElectiveSubject.UseVisualStyleBackColor = true;
            // 
            // gBoxElectiveSubjectSubject
            // 
            this.gBoxElectiveSubjectSubject.Controls.Add(this.cBoxElectiveSubjectSubject);
            this.gBoxElectiveSubjectSubject.Location = new System.Drawing.Point(12, 130);
            this.gBoxElectiveSubjectSubject.Name = "gBoxElectiveSubjectSubject";
            this.gBoxElectiveSubjectSubject.Size = new System.Drawing.Size(197, 48);
            this.gBoxElectiveSubjectSubject.TabIndex = 41;
            this.gBoxElectiveSubjectSubject.TabStop = false;
            this.gBoxElectiveSubjectSubject.Text = "Дисциплина";
            // 
            // cBoxElectiveSubjectSubject
            // 
            this.cBoxElectiveSubjectSubject.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxElectiveSubjectSubject.FormattingEnabled = true;
            this.cBoxElectiveSubjectSubject.Location = new System.Drawing.Point(6, 18);
            this.cBoxElectiveSubjectSubject.Name = "cBoxElectiveSubjectSubject";
            this.cBoxElectiveSubjectSubject.Size = new System.Drawing.Size(185, 21);
            this.cBoxElectiveSubjectSubject.TabIndex = 0;
            // 
            // gBoxElectiveSubjectCourse
            // 
            this.gBoxElectiveSubjectCourse.Controls.Add(this.cBoxElectiveSubjectCourse);
            this.gBoxElectiveSubjectCourse.Location = new System.Drawing.Point(12, 76);
            this.gBoxElectiveSubjectCourse.Name = "gBoxElectiveSubjectCourse";
            this.gBoxElectiveSubjectCourse.Size = new System.Drawing.Size(197, 48);
            this.gBoxElectiveSubjectCourse.TabIndex = 40;
            this.gBoxElectiveSubjectCourse.TabStop = false;
            this.gBoxElectiveSubjectCourse.Text = "Курс";
            // 
            // cBoxElectiveSubjectCourse
            // 
            this.cBoxElectiveSubjectCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxElectiveSubjectCourse.FormattingEnabled = true;
            this.cBoxElectiveSubjectCourse.Location = new System.Drawing.Point(6, 18);
            this.cBoxElectiveSubjectCourse.Name = "cBoxElectiveSubjectCourse";
            this.cBoxElectiveSubjectCourse.Size = new System.Drawing.Size(185, 21);
            this.cBoxElectiveSubjectCourse.TabIndex = 0;
            // 
            // gBoxElectiveSubjectStudent
            // 
            this.gBoxElectiveSubjectStudent.Controls.Add(this.cBoxElectiveSubjectStudent);
            this.gBoxElectiveSubjectStudent.Location = new System.Drawing.Point(12, 22);
            this.gBoxElectiveSubjectStudent.Name = "gBoxElectiveSubjectStudent";
            this.gBoxElectiveSubjectStudent.Size = new System.Drawing.Size(197, 48);
            this.gBoxElectiveSubjectStudent.TabIndex = 39;
            this.gBoxElectiveSubjectStudent.TabStop = false;
            this.gBoxElectiveSubjectStudent.Text = "Студент";
            // 
            // cBoxElectiveSubjectStudent
            // 
            this.cBoxElectiveSubjectStudent.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxElectiveSubjectStudent.FormattingEnabled = true;
            this.cBoxElectiveSubjectStudent.Location = new System.Drawing.Point(6, 14);
            this.cBoxElectiveSubjectStudent.Name = "cBoxElectiveSubjectStudent";
            this.cBoxElectiveSubjectStudent.Size = new System.Drawing.Size(185, 21);
            this.cBoxElectiveSubjectStudent.TabIndex = 1;
            // 
            // bSStudentCourse
            // 
            this.bSStudentCourse.AllowNew = false;
            this.bSStudentCourse.DataSource = typeof(University12.Classes.TStudentCourse);
            // 
            // FormAddElectiveSubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 213);
            this.Controls.Add(this.gBoxElectiveSubjectSubject);
            this.Controls.Add(this.gBoxElectiveSubjectCourse);
            this.Controls.Add(this.gBoxElectiveSubjectStudent);
            this.Controls.Add(this.cBoxElectiveSubject);
            this.Controls.Add(this.btnSaveSubject);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddElectiveSubjectAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Свободно избираеми дисциплини";
            this.Load += new System.EventHandler(this.FormAddElectiveSubjectAdd_Load);
            this.gBoxElectiveSubjectSubject.ResumeLayout(false);
            this.gBoxElectiveSubjectCourse.ResumeLayout(false);
            this.gBoxElectiveSubjectStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSStudentCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.CheckBox cBoxElectiveSubject;
        private System.Windows.Forms.GroupBox gBoxElectiveSubjectSubject;
        private System.Windows.Forms.ComboBox cBoxElectiveSubjectSubject;
        private System.Windows.Forms.GroupBox gBoxElectiveSubjectCourse;
        private System.Windows.Forms.ComboBox cBoxElectiveSubjectCourse;
        private System.Windows.Forms.GroupBox gBoxElectiveSubjectStudent;
        private System.Windows.Forms.ComboBox cBoxElectiveSubjectStudent;
        public System.Windows.Forms.BindingSource bSStudentCourse;
    }
}