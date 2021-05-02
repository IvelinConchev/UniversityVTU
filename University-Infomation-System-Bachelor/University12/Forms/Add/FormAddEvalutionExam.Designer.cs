namespace University12.Forms.Add
{
    partial class FormAddEvalutionExam
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
            this.gBoxCourse = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cBoxCourse = new System.Windows.Forms.ComboBox();
            this.bsEvaluation = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gBoxSpeciality = new System.Windows.Forms.GroupBox();
            this.cBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.gBoxStudent = new System.Windows.Forms.GroupBox();
            this.cBoxStudent = new System.Windows.Forms.ComboBox();
            this.gBoxLecture = new System.Windows.Forms.GroupBox();
            this.cBoxLecture = new System.Windows.Forms.ComboBox();
            this.gBoxNumber = new System.Windows.Forms.GroupBox();
            this.tBoxFormAddEvaluation = new System.Windows.Forms.TextBox();
            this.gBoxSubject = new System.Windows.Forms.GroupBox();
            this.cBoxSubject = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gBoxCourse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gBoxSpeciality.SuspendLayout();
            this.gBoxStudent.SuspendLayout();
            this.gBoxLecture.SuspendLayout();
            this.gBoxNumber.SuspendLayout();
            this.gBoxSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCourse
            // 
            this.gBoxCourse.Controls.Add(this.groupBox1);
            this.gBoxCourse.Controls.Add(this.cBoxCourse);
            this.gBoxCourse.Controls.Add(this.groupBox2);
            this.gBoxCourse.Location = new System.Drawing.Point(263, 15);
            this.gBoxCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxCourse.Name = "gBoxCourse";
            this.gBoxCourse.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxCourse.Size = new System.Drawing.Size(239, 60);
            this.gBoxCourse.TabIndex = 17;
            this.gBoxCourse.TabStop = false;
            this.gBoxCourse.Text = "Курс";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(483, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(239, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курс";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // cBoxCourse
            // 
            this.cBoxCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "CourseName", true));
            this.cBoxCourse.FormattingEnabled = true;
            this.cBoxCourse.Location = new System.Drawing.Point(8, 23);
            this.cBoxCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxCourse.Name = "cBoxCourse";
            this.cBoxCourse.Size = new System.Drawing.Size(219, 24);
            this.cBoxCourse.TabIndex = 0;
            // 
            // bsEvaluation
            // 
            this.bsEvaluation.AllowNew = false;
            this.bsEvaluation.DataSource = typeof(University12.Classes.TEvaluation);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(236, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(239, 60);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Специалност";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // gBoxSpeciality
            // 
            this.gBoxSpeciality.Controls.Add(this.cBoxSpeciality);
            this.gBoxSpeciality.Location = new System.Drawing.Point(16, 15);
            this.gBoxSpeciality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSpeciality.Name = "gBoxSpeciality";
            this.gBoxSpeciality.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSpeciality.Size = new System.Drawing.Size(239, 60);
            this.gBoxSpeciality.TabIndex = 16;
            this.gBoxSpeciality.TabStop = false;
            this.gBoxSpeciality.Text = "Специалност";
            // 
            // cBoxSpeciality
            // 
            this.cBoxSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSpeciality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "NameSpecilaity", true));
            this.cBoxSpeciality.FormattingEnabled = true;
            this.cBoxSpeciality.Location = new System.Drawing.Point(8, 23);
            this.cBoxSpeciality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxSpeciality.Name = "cBoxSpeciality";
            this.cBoxSpeciality.Size = new System.Drawing.Size(219, 24);
            this.cBoxSpeciality.TabIndex = 0;
            // 
            // gBoxStudent
            // 
            this.gBoxStudent.Controls.Add(this.cBoxStudent);
            this.gBoxStudent.Location = new System.Drawing.Point(263, 82);
            this.gBoxStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxStudent.Name = "gBoxStudent";
            this.gBoxStudent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxStudent.Size = new System.Drawing.Size(239, 60);
            this.gBoxStudent.TabIndex = 19;
            this.gBoxStudent.TabStop = false;
            this.gBoxStudent.Text = "Студент";
            // 
            // cBoxStudent
            // 
            this.cBoxStudent.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "StudentName", true));
            this.cBoxStudent.FormattingEnabled = true;
            this.cBoxStudent.Location = new System.Drawing.Point(8, 23);
            this.cBoxStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxStudent.Name = "cBoxStudent";
            this.cBoxStudent.Size = new System.Drawing.Size(219, 24);
            this.cBoxStudent.TabIndex = 0;
            // 
            // gBoxLecture
            // 
            this.gBoxLecture.Controls.Add(this.cBoxLecture);
            this.gBoxLecture.Location = new System.Drawing.Point(16, 82);
            this.gBoxLecture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxLecture.Name = "gBoxLecture";
            this.gBoxLecture.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxLecture.Size = new System.Drawing.Size(239, 60);
            this.gBoxLecture.TabIndex = 18;
            this.gBoxLecture.TabStop = false;
            this.gBoxLecture.Text = "Преподавател";
            // 
            // cBoxLecture
            // 
            this.cBoxLecture.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxLecture.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "LectureName", true));
            this.cBoxLecture.FormattingEnabled = true;
            this.cBoxLecture.Location = new System.Drawing.Point(8, 23);
            this.cBoxLecture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxLecture.Name = "cBoxLecture";
            this.cBoxLecture.Size = new System.Drawing.Size(219, 24);
            this.cBoxLecture.TabIndex = 0;
            // 
            // gBoxNumber
            // 
            this.gBoxNumber.Controls.Add(this.tBoxFormAddEvaluation);
            this.gBoxNumber.Location = new System.Drawing.Point(263, 150);
            this.gBoxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxNumber.Name = "gBoxNumber";
            this.gBoxNumber.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxNumber.Size = new System.Drawing.Size(239, 60);
            this.gBoxNumber.TabIndex = 21;
            this.gBoxNumber.TabStop = false;
            this.gBoxNumber.Text = "Цифра";
            // 
            // tBoxFormAddEvaluation
            // 
            this.tBoxFormAddEvaluation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormAddEvaluation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "Number", true));
            this.tBoxFormAddEvaluation.Location = new System.Drawing.Point(8, 23);
            this.tBoxFormAddEvaluation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxFormAddEvaluation.Name = "tBoxFormAddEvaluation";
            this.tBoxFormAddEvaluation.Size = new System.Drawing.Size(221, 22);
            this.tBoxFormAddEvaluation.TabIndex = 1;
            // 
            // gBoxSubject
            // 
            this.gBoxSubject.Controls.Add(this.cBoxSubject);
            this.gBoxSubject.Location = new System.Drawing.Point(16, 150);
            this.gBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSubject.Name = "gBoxSubject";
            this.gBoxSubject.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSubject.Size = new System.Drawing.Size(239, 60);
            this.gBoxSubject.TabIndex = 20;
            this.gBoxSubject.TabStop = false;
            this.gBoxSubject.Text = "Предмет";
            // 
            // cBoxSubject
            // 
            this.cBoxSubject.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBoxSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEvaluation, "SubjectName", true));
            this.cBoxSubject.FormattingEnabled = true;
            this.cBoxSubject.Location = new System.Drawing.Point(8, 23);
            this.cBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxSubject.Name = "cBoxSubject";
            this.cBoxSubject.Size = new System.Drawing.Size(219, 24);
            this.cBoxSubject.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(192, 218);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 43);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Запис";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddEvalutionExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 266);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBoxNumber);
            this.Controls.Add(this.gBoxSubject);
            this.Controls.Add(this.gBoxStudent);
            this.Controls.Add(this.gBoxLecture);
            this.Controls.Add(this.gBoxCourse);
            this.Controls.Add(this.gBoxSpeciality);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEvalutionExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценяване";
            this.Load += new System.EventHandler(this.FormAddEvalutionExam_Load);
            this.gBoxCourse.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gBoxSpeciality.ResumeLayout(false);
            this.gBoxStudent.ResumeLayout(false);
            this.gBoxLecture.ResumeLayout(false);
            this.gBoxNumber.ResumeLayout(false);
            this.gBoxNumber.PerformLayout();
            this.gBoxSubject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCourse;
        private System.Windows.Forms.ComboBox cBoxCourse;
        private System.Windows.Forms.GroupBox gBoxSpeciality;
        private System.Windows.Forms.ComboBox cBoxSpeciality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gBoxStudent;
        private System.Windows.Forms.ComboBox cBoxStudent;
        private System.Windows.Forms.GroupBox gBoxLecture;
        private System.Windows.Forms.ComboBox cBoxLecture;
        private System.Windows.Forms.GroupBox gBoxNumber;
        private System.Windows.Forms.GroupBox gBoxSubject;
        private System.Windows.Forms.ComboBox cBoxSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBoxFormAddEvaluation;
        public System.Windows.Forms.BindingSource bsEvaluation;
    }
}