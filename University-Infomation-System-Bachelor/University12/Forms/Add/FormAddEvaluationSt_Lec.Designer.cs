namespace University12.Forms.Add
{
    partial class FormAddEvaluationSt_Lec
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
            this.gboxFirstName = new System.Windows.Forms.GroupBox();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.cbMiddleName = new System.Windows.Forms.ComboBox();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.gBoxStudent = new System.Windows.Forms.GroupBox();
            this.gbMiddleName = new System.Windows.Forms.GroupBox();
            this.gbLastName = new System.Windows.Forms.GroupBox();
            this.gbLecture = new System.Windows.Forms.GroupBox();
            this.gbLecLastName = new System.Windows.Forms.GroupBox();
            this.cbLecLastName = new System.Windows.Forms.ComboBox();
            this.gbLecMiddleName = new System.Windows.Forms.GroupBox();
            this.cbLecMiddleName = new System.Windows.Forms.ComboBox();
            this.gbLecFirstName = new System.Windows.Forms.GroupBox();
            this.cbLecFirstName = new System.Windows.Forms.ComboBox();
            this.gbSpeciality = new System.Windows.Forms.GroupBox();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gBoxNumber = new System.Windows.Forms.GroupBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.bsEvaluation = new System.Windows.Forms.BindingSource(this.components);
            this.gboxFirstName.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.gBoxStudent.SuspendLayout();
            this.gbMiddleName.SuspendLayout();
            this.gbLastName.SuspendLayout();
            this.gbLecture.SuspendLayout();
            this.gbLecLastName.SuspendLayout();
            this.gbLecMiddleName.SuspendLayout();
            this.gbLecFirstName.SuspendLayout();
            this.gbSpeciality.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.gBoxNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxFirstName
            // 
            this.gboxFirstName.Controls.Add(this.cbFirstName);
            this.gboxFirstName.Location = new System.Drawing.Point(6, 19);
            this.gboxFirstName.Name = "gboxFirstName";
            this.gboxFirstName.Size = new System.Drawing.Size(182, 56);
            this.gboxFirstName.TabIndex = 20;
            this.gboxFirstName.TabStop = false;
            this.gboxFirstName.Text = "Име";
            // 
            // cbFirstName
            // 
            this.cbFirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbFirstName.FormattingEnabled = true;
            this.cbFirstName.Location = new System.Drawing.Point(6, 19);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(165, 21);
            this.cbFirstName.TabIndex = 3;
            // 
            // cbMiddleName
            // 
            this.cbMiddleName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbMiddleName.FormattingEnabled = true;
            this.cbMiddleName.Location = new System.Drawing.Point(6, 19);
            this.cbMiddleName.Name = "cbMiddleName";
            this.cbMiddleName.Size = new System.Drawing.Size(165, 21);
            this.cbMiddleName.TabIndex = 4;
            // 
            // cBox2
            // 
            this.cBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Location = new System.Drawing.Point(6, 19);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(165, 21);
            this.cBox2.TabIndex = 5;
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.cbCourse);
            this.gbCourse.Location = new System.Drawing.Point(196, 223);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(176, 56);
            this.gbCourse.TabIndex = 21;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Курс";
            // 
            // cbCourse
            // 
            this.cbCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(6, 19);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(165, 21);
            this.cbCourse.TabIndex = 5;
            // 
            // gBoxStudent
            // 
            this.gBoxStudent.Controls.Add(this.gbLastName);
            this.gBoxStudent.Controls.Add(this.gbMiddleName);
            this.gBoxStudent.Controls.Add(this.gboxFirstName);
            this.gBoxStudent.Location = new System.Drawing.Point(2, 12);
            this.gBoxStudent.Name = "gBoxStudent";
            this.gBoxStudent.Size = new System.Drawing.Size(571, 87);
            this.gBoxStudent.TabIndex = 22;
            this.gBoxStudent.TabStop = false;
            this.gBoxStudent.Text = "Студент";
            // 
            // gbMiddleName
            // 
            this.gbMiddleName.Controls.Add(this.cbMiddleName);
            this.gbMiddleName.Location = new System.Drawing.Point(194, 19);
            this.gbMiddleName.Name = "gbMiddleName";
            this.gbMiddleName.Size = new System.Drawing.Size(180, 56);
            this.gbMiddleName.TabIndex = 21;
            this.gbMiddleName.TabStop = false;
            this.gbMiddleName.Text = "Презиме";
            // 
            // gbLastName
            // 
            this.gbLastName.Controls.Add(this.cBox2);
            this.gbLastName.Location = new System.Drawing.Point(380, 19);
            this.gbLastName.Name = "gbLastName";
            this.gbLastName.Size = new System.Drawing.Size(180, 56);
            this.gbLastName.TabIndex = 22;
            this.gbLastName.TabStop = false;
            this.gbLastName.Text = "Фамилия";
            // 
            // gbLecture
            // 
            this.gbLecture.Controls.Add(this.gbLecLastName);
            this.gbLecture.Controls.Add(this.gbLecMiddleName);
            this.gbLecture.Controls.Add(this.gbLecFirstName);
            this.gbLecture.Location = new System.Drawing.Point(2, 117);
            this.gbLecture.Name = "gbLecture";
            this.gbLecture.Size = new System.Drawing.Size(571, 87);
            this.gbLecture.TabIndex = 23;
            this.gbLecture.TabStop = false;
            this.gbLecture.Text = "Преподавател";
            // 
            // gbLecLastName
            // 
            this.gbLecLastName.Controls.Add(this.cbLecLastName);
            this.gbLecLastName.Location = new System.Drawing.Point(380, 19);
            this.gbLecLastName.Name = "gbLecLastName";
            this.gbLecLastName.Size = new System.Drawing.Size(180, 56);
            this.gbLecLastName.TabIndex = 22;
            this.gbLecLastName.TabStop = false;
            this.gbLecLastName.Text = "Фамилия";
            // 
            // cbLecLastName
            // 
            this.cbLecLastName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbLecLastName.FormattingEnabled = true;
            this.cbLecLastName.Location = new System.Drawing.Point(6, 19);
            this.cbLecLastName.Name = "cbLecLastName";
            this.cbLecLastName.Size = new System.Drawing.Size(165, 21);
            this.cbLecLastName.TabIndex = 5;
            // 
            // gbLecMiddleName
            // 
            this.gbLecMiddleName.Controls.Add(this.cbLecMiddleName);
            this.gbLecMiddleName.Location = new System.Drawing.Point(194, 19);
            this.gbLecMiddleName.Name = "gbLecMiddleName";
            this.gbLecMiddleName.Size = new System.Drawing.Size(180, 56);
            this.gbLecMiddleName.TabIndex = 21;
            this.gbLecMiddleName.TabStop = false;
            this.gbLecMiddleName.Text = "Презиме";
            // 
            // cbLecMiddleName
            // 
            this.cbLecMiddleName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbLecMiddleName.FormattingEnabled = true;
            this.cbLecMiddleName.Location = new System.Drawing.Point(6, 19);
            this.cbLecMiddleName.Name = "cbLecMiddleName";
            this.cbLecMiddleName.Size = new System.Drawing.Size(165, 21);
            this.cbLecMiddleName.TabIndex = 4;
            // 
            // gbLecFirstName
            // 
            this.gbLecFirstName.Controls.Add(this.cbLecFirstName);
            this.gbLecFirstName.Location = new System.Drawing.Point(6, 19);
            this.gbLecFirstName.Name = "gbLecFirstName";
            this.gbLecFirstName.Size = new System.Drawing.Size(182, 56);
            this.gbLecFirstName.TabIndex = 20;
            this.gbLecFirstName.TabStop = false;
            this.gbLecFirstName.Text = "Име";
            // 
            // cbLecFirstName
            // 
            this.cbLecFirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbLecFirstName.FormattingEnabled = true;
            this.cbLecFirstName.Location = new System.Drawing.Point(6, 19);
            this.cbLecFirstName.Name = "cbLecFirstName";
            this.cbLecFirstName.Size = new System.Drawing.Size(165, 21);
            this.cbLecFirstName.TabIndex = 3;
            // 
            // gbSpeciality
            // 
            this.gbSpeciality.Controls.Add(this.cbSpeciality);
            this.gbSpeciality.Location = new System.Drawing.Point(5, 223);
            this.gbSpeciality.Name = "gbSpeciality";
            this.gbSpeciality.Size = new System.Drawing.Size(176, 56);
            this.gbSpeciality.TabIndex = 25;
            this.gbSpeciality.TabStop = false;
            this.gbSpeciality.Text = "Специалност";
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(6, 19);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(165, 21);
            this.cbSpeciality.TabIndex = 5;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.cbSubject);
            this.gbSubject.Location = new System.Drawing.Point(388, 223);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(176, 56);
            this.gbSubject.TabIndex = 26;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Дисциплини";
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(6, 19);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(165, 21);
            this.cbSubject.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(453, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Запис";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gBoxNumber
            // 
            this.gBoxNumber.Controls.Add(this.tbNumber);
            this.gBoxNumber.Location = new System.Drawing.Point(8, 291);
            this.gBoxNumber.Name = "gBoxNumber";
            this.gBoxNumber.Size = new System.Drawing.Size(179, 49);
            this.gBoxNumber.TabIndex = 40;
            this.gBoxNumber.TabStop = false;
            this.gBoxNumber.Text = "Цифра";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbNumber.Location = new System.Drawing.Point(6, 19);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(167, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // FormAddEvaluationSt_Lec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBoxNumber);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbSpeciality);
            this.Controls.Add(this.gbLecture);
            this.Controls.Add(this.gBoxStudent);
            this.Controls.Add(this.gbCourse);
            this.Name = "FormAddEvaluationSt_Lec";
            this.Text = "FormAddEvaluationSt_Lec";
            this.Load += new System.EventHandler(this.FormAddEvaluationSt_Lec_Load);
            this.gboxFirstName.ResumeLayout(false);
            this.gbCourse.ResumeLayout(false);
            this.gBoxStudent.ResumeLayout(false);
            this.gbMiddleName.ResumeLayout(false);
            this.gbLastName.ResumeLayout(false);
            this.gbLecture.ResumeLayout(false);
            this.gbLecLastName.ResumeLayout(false);
            this.gbLecMiddleName.ResumeLayout(false);
            this.gbLecFirstName.ResumeLayout(false);
            this.gbSpeciality.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            this.gBoxNumber.ResumeLayout(false);
            this.gBoxNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvaluation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxFirstName;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.ComboBox cbMiddleName;
        private System.Windows.Forms.ComboBox cBox2;
        private System.Windows.Forms.GroupBox gbCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox gBoxStudent;
        private System.Windows.Forms.GroupBox gbLastName;
        private System.Windows.Forms.GroupBox gbMiddleName;
        private System.Windows.Forms.GroupBox gbLecture;
        private System.Windows.Forms.GroupBox gbLecLastName;
        private System.Windows.Forms.ComboBox cbLecLastName;
        private System.Windows.Forms.GroupBox gbLecMiddleName;
        private System.Windows.Forms.ComboBox cbLecMiddleName;
        private System.Windows.Forms.GroupBox gbLecFirstName;
        private System.Windows.Forms.ComboBox cbLecFirstName;
        private System.Windows.Forms.GroupBox gbSpeciality;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gBoxNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.BindingSource bsEvaluation;
    }
}