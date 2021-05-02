namespace University12.Forms
{
    partial class FormStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentInformation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gBoxStudentInformationSystem = new System.Windows.Forms.GroupBox();
            this.txtBoxStudentInformatonSystem = new System.Windows.Forms.TextBox();
            this.btnStudentInformationSystemFaculty = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemStudent = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemLecture = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemSpeciality = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemSubject = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemEvaluation = new System.Windows.Forms.Button();
            this.btnStudentInformationSystemExam = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gBoxStudentInformationSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(702, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // gBoxStudentInformationSystem
            // 
            this.gBoxStudentInformationSystem.Controls.Add(this.txtBoxStudentInformatonSystem);
            this.gBoxStudentInformationSystem.Location = new System.Drawing.Point(118, 12);
            this.gBoxStudentInformationSystem.Name = "gBoxStudentInformationSystem";
            this.gBoxStudentInformationSystem.Size = new System.Drawing.Size(563, 35);
            this.gBoxStudentInformationSystem.TabIndex = 3;
            this.gBoxStudentInformationSystem.TabStop = false;
            // 
            // txtBoxStudentInformatonSystem
            // 
            this.txtBoxStudentInformatonSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxStudentInformatonSystem.Location = new System.Drawing.Point(19, 9);
            this.txtBoxStudentInformatonSystem.Name = "txtBoxStudentInformatonSystem";
            this.txtBoxStudentInformatonSystem.Size = new System.Drawing.Size(535, 20);
            this.txtBoxStudentInformatonSystem.TabIndex = 0;
            this.txtBoxStudentInformatonSystem.Text = "СТУДЕНТСКА ИНФОРМАЦИОННА СИСТЕМА";
            this.txtBoxStudentInformatonSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudentInformationSystemFaculty
            // 
            this.btnStudentInformationSystemFaculty.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemFaculty.Location = new System.Drawing.Point(21, 90);
            this.btnStudentInformationSystemFaculty.Name = "btnStudentInformationSystemFaculty";
            this.btnStudentInformationSystemFaculty.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemFaculty.TabIndex = 5;
            this.btnStudentInformationSystemFaculty.Text = "Факултети";
            this.btnStudentInformationSystemFaculty.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemFaculty.Click += new System.EventHandler(this.BtnStudentInformationSystemFaculty_Click);
            // 
            // btnStudentInformationSystemStudent
            // 
            this.btnStudentInformationSystemStudent.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudentInformationSystemStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemStudent.Location = new System.Drawing.Point(21, 163);
            this.btnStudentInformationSystemStudent.Name = "btnStudentInformationSystemStudent";
            this.btnStudentInformationSystemStudent.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemStudent.TabIndex = 12;
            this.btnStudentInformationSystemStudent.Text = "Студенти";
            this.btnStudentInformationSystemStudent.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemStudent.Click += new System.EventHandler(this.BtnStudentInformationSystemStudent_Click);
            // 
            // btnStudentInformationSystemLecture
            // 
            this.btnStudentInformationSystemLecture.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemLecture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudentInformationSystemLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemLecture.Location = new System.Drawing.Point(21, 240);
            this.btnStudentInformationSystemLecture.Name = "btnStudentInformationSystemLecture";
            this.btnStudentInformationSystemLecture.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemLecture.TabIndex = 13;
            this.btnStudentInformationSystemLecture.Text = "Преподаватели";
            this.btnStudentInformationSystemLecture.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemLecture.Click += new System.EventHandler(this.BtnStudentInformationSystemLecture_Click);
            // 
            // btnStudentInformationSystemSpeciality
            // 
            this.btnStudentInformationSystemSpeciality.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemSpeciality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemSpeciality.Location = new System.Drawing.Point(21, 312);
            this.btnStudentInformationSystemSpeciality.Name = "btnStudentInformationSystemSpeciality";
            this.btnStudentInformationSystemSpeciality.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemSpeciality.TabIndex = 14;
            this.btnStudentInformationSystemSpeciality.Text = "Специалности";
            this.btnStudentInformationSystemSpeciality.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemSpeciality.Click += new System.EventHandler(this.BtnStudentInformationSystemSpeciality_Click);
            // 
            // btnStudentInformationSystemSubject
            // 
            this.btnStudentInformationSystemSubject.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemSubject.Location = new System.Drawing.Point(21, 387);
            this.btnStudentInformationSystemSubject.Name = "btnStudentInformationSystemSubject";
            this.btnStudentInformationSystemSubject.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemSubject.TabIndex = 15;
            this.btnStudentInformationSystemSubject.Text = "Дисциплини";
            this.btnStudentInformationSystemSubject.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemSubject.Click += new System.EventHandler(this.BtnStudentInformationSystemSubject_Click);
            // 
            // btnStudentInformationSystemEvaluation
            // 
            this.btnStudentInformationSystemEvaluation.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemEvaluation.Location = new System.Drawing.Point(702, 101);
            this.btnStudentInformationSystemEvaluation.Name = "btnStudentInformationSystemEvaluation";
            this.btnStudentInformationSystemEvaluation.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemEvaluation.TabIndex = 16;
            this.btnStudentInformationSystemEvaluation.Text = "Оценяване";
            this.btnStudentInformationSystemEvaluation.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemEvaluation.Click += new System.EventHandler(this.BtnStudentInformationSystemEvaluation_Click);
            // 
            // btnStudentInformationSystemExam
            // 
            this.btnStudentInformationSystemExam.BackColor = System.Drawing.Color.White;
            this.btnStudentInformationSystemExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentInformationSystemExam.Location = new System.Drawing.Point(701, 175);
            this.btnStudentInformationSystemExam.Name = "btnStudentInformationSystemExam";
            this.btnStudentInformationSystemExam.Size = new System.Drawing.Size(101, 56);
            this.btnStudentInformationSystemExam.TabIndex = 17;
            this.btnStudentInformationSystemExam.Text = "Изпитни резултати";
            this.btnStudentInformationSystemExam.UseVisualStyleBackColor = false;
            this.btnStudentInformationSystemExam.Click += new System.EventHandler(this.BtnStudentInformationSystemExam_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.White;
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperation.Location = new System.Drawing.Point(702, 378);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(101, 56);
            this.btnOperation.TabIndex = 18;
            this.btnOperation.Text = "Оператори";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // FormStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 463);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnStudentInformationSystemExam);
            this.Controls.Add(this.btnStudentInformationSystemEvaluation);
            this.Controls.Add(this.btnStudentInformationSystemSubject);
            this.Controls.Add(this.btnStudentInformationSystemSpeciality);
            this.Controls.Add(this.btnStudentInformationSystemLecture);
            this.Controls.Add(this.btnStudentInformationSystemStudent);
            this.Controls.Add(this.btnStudentInformationSystemFaculty);
            this.Controls.Add(this.gBoxStudentInformationSystem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студентска информационна система";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gBoxStudentInformationSystem.ResumeLayout(false);
            this.gBoxStudentInformationSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox gBoxStudentInformationSystem;
        private System.Windows.Forms.TextBox txtBoxStudentInformatonSystem;
        private System.Windows.Forms.Button btnStudentInformationSystemFaculty;
        private System.Windows.Forms.Button btnStudentInformationSystemStudent;
        private System.Windows.Forms.Button btnStudentInformationSystemLecture;
        private System.Windows.Forms.Button btnStudentInformationSystemSpeciality;
        private System.Windows.Forms.Button btnStudentInformationSystemSubject;
        private System.Windows.Forms.Button btnStudentInformationSystemEvaluation;
        private System.Windows.Forms.Button btnStudentInformationSystemExam;
        private System.Windows.Forms.Button btnOperation;
    }
}