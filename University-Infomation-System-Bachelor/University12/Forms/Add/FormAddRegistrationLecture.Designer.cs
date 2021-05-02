namespace University12.Forms
{
    partial class FormAddRegistrationLecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRegistrationLecture));
            this.gBoxFormRegistrationLectureFaculty = new System.Windows.Forms.GroupBox();
            this.tBoxFormRegistrationLectureFaculty = new System.Windows.Forms.TextBox();
            this.bsLecture = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormRegistrationLectureCity = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureCity = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureEmail = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureEmail = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLecturePhone = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLecturePhone = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureLastName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureLastName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureMiddleName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureMiddleName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureFirstName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureFirstName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureDepartment = new System.Windows.Forms.GroupBox();
            this.tBoxFormRegistrationLectureDepartment = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureSchoolFMI = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationLectureGraduateUniversity = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationLectureTitle = new System.Windows.Forms.GroupBox();
            this.tBoxFormRegistrationLectureTitle = new System.Windows.Forms.TextBox();
            this.btnFormRegistrationLectureSave = new System.Windows.Forms.Button();
            this.btnFormRegistrationLectureExit = new System.Windows.Forms.Button();
            this.pBLecturePicture = new System.Windows.Forms.PictureBox();
            this.btnEditPicture = new System.Windows.Forms.Button();
            this.gBoxFormRegistrationLectureFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLecture)).BeginInit();
            this.gBoxFormRegistrationLectureCity.SuspendLayout();
            this.gBoxFormRegistrationLectureEmail.SuspendLayout();
            this.gBoxFormRegistrationLecturePhone.SuspendLayout();
            this.gBoxFormRegistrationLectureLastName.SuspendLayout();
            this.gBoxFormRegistrationLectureMiddleName.SuspendLayout();
            this.gBoxFormRegistrationLectureFirstName.SuspendLayout();
            this.gBoxFormRegistrationLectureDepartment.SuspendLayout();
            this.gBoxFormRegistrationLectureSchoolFMI.SuspendLayout();
            this.gBoxFormRegistrationLectureTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLecturePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFormRegistrationLectureFaculty
            // 
            this.gBoxFormRegistrationLectureFaculty.Controls.Add(this.tBoxFormRegistrationLectureFaculty);
            this.gBoxFormRegistrationLectureFaculty.Location = new System.Drawing.Point(19, 340);
            this.gBoxFormRegistrationLectureFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureFaculty.Name = "gBoxFormRegistrationLectureFaculty";
            this.gBoxFormRegistrationLectureFaculty.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureFaculty.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureFaculty.TabIndex = 27;
            this.gBoxFormRegistrationLectureFaculty.TabStop = false;
            this.gBoxFormRegistrationLectureFaculty.Text = "Факултет";
            // 
            // tBoxFormRegistrationLectureFaculty
            // 
            this.tBoxFormRegistrationLectureFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormRegistrationLectureFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "FacultyName", true));
            this.tBoxFormRegistrationLectureFaculty.Location = new System.Drawing.Point(8, 23);
            this.tBoxFormRegistrationLectureFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxFormRegistrationLectureFaculty.Name = "tBoxFormRegistrationLectureFaculty";
            this.tBoxFormRegistrationLectureFaculty.Size = new System.Drawing.Size(212, 22);
            this.tBoxFormRegistrationLectureFaculty.TabIndex = 2;
            // 
            // bsLecture
            // 
            this.bsLecture.DataSource = typeof(University12.Classes.TLecture);
            // 
            // gBoxFormRegistrationLectureCity
            // 
            this.gBoxFormRegistrationLectureCity.Controls.Add(this.txtBoxFormRegistrationLectureCity);
            this.gBoxFormRegistrationLectureCity.Location = new System.Drawing.Point(261, 268);
            this.gBoxFormRegistrationLectureCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureCity.Name = "gBoxFormRegistrationLectureCity";
            this.gBoxFormRegistrationLectureCity.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureCity.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureCity.TabIndex = 21;
            this.gBoxFormRegistrationLectureCity.TabStop = false;
            this.gBoxFormRegistrationLectureCity.Text = "Град";
            // 
            // txtBoxFormRegistrationLectureCity
            // 
            this.txtBoxFormRegistrationLectureCity.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "City", true));
            this.txtBoxFormRegistrationLectureCity.Location = new System.Drawing.Point(8, 17);
            this.txtBoxFormRegistrationLectureCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureCity.Name = "txtBoxFormRegistrationLectureCity";
            this.txtBoxFormRegistrationLectureCity.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureCity.TabIndex = 1;
            // 
            // gBoxFormRegistrationLectureEmail
            // 
            this.gBoxFormRegistrationLectureEmail.Controls.Add(this.txtBoxFormRegistrationLectureEmail);
            this.gBoxFormRegistrationLectureEmail.Location = new System.Drawing.Point(19, 268);
            this.gBoxFormRegistrationLectureEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureEmail.Name = "gBoxFormRegistrationLectureEmail";
            this.gBoxFormRegistrationLectureEmail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureEmail.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureEmail.TabIndex = 20;
            this.gBoxFormRegistrationLectureEmail.TabStop = false;
            this.gBoxFormRegistrationLectureEmail.Text = "Имейл";
            // 
            // txtBoxFormRegistrationLectureEmail
            // 
            this.txtBoxFormRegistrationLectureEmail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "Email", true));
            this.txtBoxFormRegistrationLectureEmail.Location = new System.Drawing.Point(8, 23);
            this.txtBoxFormRegistrationLectureEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureEmail.Name = "txtBoxFormRegistrationLectureEmail";
            this.txtBoxFormRegistrationLectureEmail.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureEmail.TabIndex = 0;
            // 
            // gBoxFormRegistrationLecturePhone
            // 
            this.gBoxFormRegistrationLecturePhone.Controls.Add(this.txtBoxFormRegistrationLecturePhone);
            this.gBoxFormRegistrationLecturePhone.Location = new System.Drawing.Point(503, 197);
            this.gBoxFormRegistrationLecturePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLecturePhone.Name = "gBoxFormRegistrationLecturePhone";
            this.gBoxFormRegistrationLecturePhone.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLecturePhone.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLecturePhone.TabIndex = 19;
            this.gBoxFormRegistrationLecturePhone.TabStop = false;
            this.gBoxFormRegistrationLecturePhone.Text = "Телефон";
            // 
            // txtBoxFormRegistrationLecturePhone
            // 
            this.txtBoxFormRegistrationLecturePhone.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLecturePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "Phone", true));
            this.txtBoxFormRegistrationLecturePhone.Location = new System.Drawing.Point(8, 27);
            this.txtBoxFormRegistrationLecturePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLecturePhone.Name = "txtBoxFormRegistrationLecturePhone";
            this.txtBoxFormRegistrationLecturePhone.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLecturePhone.TabIndex = 0;
            // 
            // gBoxFormRegistrationLectureLastName
            // 
            this.gBoxFormRegistrationLectureLastName.Controls.Add(this.txtBoxFormRegistrationLectureLastName);
            this.gBoxFormRegistrationLectureLastName.Location = new System.Drawing.Point(261, 202);
            this.gBoxFormRegistrationLectureLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureLastName.Name = "gBoxFormRegistrationLectureLastName";
            this.gBoxFormRegistrationLectureLastName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureLastName.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureLastName.TabIndex = 16;
            this.gBoxFormRegistrationLectureLastName.TabStop = false;
            this.gBoxFormRegistrationLectureLastName.Text = "Фамилия";
            // 
            // txtBoxFormRegistrationLectureLastName
            // 
            this.txtBoxFormRegistrationLectureLastName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "LastName", true));
            this.txtBoxFormRegistrationLectureLastName.Location = new System.Drawing.Point(8, 23);
            this.txtBoxFormRegistrationLectureLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureLastName.Name = "txtBoxFormRegistrationLectureLastName";
            this.txtBoxFormRegistrationLectureLastName.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureLastName.TabIndex = 0;
            // 
            // gBoxFormRegistrationLectureMiddleName
            // 
            this.gBoxFormRegistrationLectureMiddleName.Controls.Add(this.txtBoxFormRegistrationLectureMiddleName);
            this.gBoxFormRegistrationLectureMiddleName.Location = new System.Drawing.Point(16, 202);
            this.gBoxFormRegistrationLectureMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureMiddleName.Name = "gBoxFormRegistrationLectureMiddleName";
            this.gBoxFormRegistrationLectureMiddleName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureMiddleName.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureMiddleName.TabIndex = 17;
            this.gBoxFormRegistrationLectureMiddleName.TabStop = false;
            this.gBoxFormRegistrationLectureMiddleName.Text = "Презиме";
            // 
            // txtBoxFormRegistrationLectureMiddleName
            // 
            this.txtBoxFormRegistrationLectureMiddleName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "MiddleName", true));
            this.txtBoxFormRegistrationLectureMiddleName.Location = new System.Drawing.Point(8, 23);
            this.txtBoxFormRegistrationLectureMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureMiddleName.Name = "txtBoxFormRegistrationLectureMiddleName";
            this.txtBoxFormRegistrationLectureMiddleName.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureMiddleName.TabIndex = 0;
            // 
            // gBoxFormRegistrationLectureFirstName
            // 
            this.gBoxFormRegistrationLectureFirstName.Controls.Add(this.txtBoxFormRegistrationLectureFirstName);
            this.gBoxFormRegistrationLectureFirstName.Location = new System.Drawing.Point(503, 130);
            this.gBoxFormRegistrationLectureFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureFirstName.Name = "gBoxFormRegistrationLectureFirstName";
            this.gBoxFormRegistrationLectureFirstName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureFirstName.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureFirstName.TabIndex = 15;
            this.gBoxFormRegistrationLectureFirstName.TabStop = false;
            this.gBoxFormRegistrationLectureFirstName.Text = "Име";
            // 
            // txtBoxFormRegistrationLectureFirstName
            // 
            this.txtBoxFormRegistrationLectureFirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "FirstName", true));
            this.txtBoxFormRegistrationLectureFirstName.Location = new System.Drawing.Point(8, 23);
            this.txtBoxFormRegistrationLectureFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureFirstName.Name = "txtBoxFormRegistrationLectureFirstName";
            this.txtBoxFormRegistrationLectureFirstName.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureFirstName.TabIndex = 0;
            // 
            // gBoxFormRegistrationLectureDepartment
            // 
            this.gBoxFormRegistrationLectureDepartment.Controls.Add(this.tBoxFormRegistrationLectureDepartment);
            this.gBoxFormRegistrationLectureDepartment.Location = new System.Drawing.Point(503, 263);
            this.gBoxFormRegistrationLectureDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureDepartment.Name = "gBoxFormRegistrationLectureDepartment";
            this.gBoxFormRegistrationLectureDepartment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureDepartment.Size = new System.Drawing.Size(229, 59);
            this.gBoxFormRegistrationLectureDepartment.TabIndex = 25;
            this.gBoxFormRegistrationLectureDepartment.TabStop = false;
            this.gBoxFormRegistrationLectureDepartment.Text = "Катедра";
            // 
            // tBoxFormRegistrationLectureDepartment
            // 
            this.tBoxFormRegistrationLectureDepartment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormRegistrationLectureDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "DepartmentName", true));
            this.tBoxFormRegistrationLectureDepartment.Location = new System.Drawing.Point(8, 23);
            this.tBoxFormRegistrationLectureDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxFormRegistrationLectureDepartment.Name = "tBoxFormRegistrationLectureDepartment";
            this.tBoxFormRegistrationLectureDepartment.Size = new System.Drawing.Size(212, 22);
            this.tBoxFormRegistrationLectureDepartment.TabIndex = 1;
            // 
            // gBoxFormRegistrationLectureSchoolFMI
            // 
            this.gBoxFormRegistrationLectureSchoolFMI.Controls.Add(this.txtBoxFormRegistrationLectureGraduateUniversity);
            this.gBoxFormRegistrationLectureSchoolFMI.Location = new System.Drawing.Point(503, 335);
            this.gBoxFormRegistrationLectureSchoolFMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureSchoolFMI.Name = "gBoxFormRegistrationLectureSchoolFMI";
            this.gBoxFormRegistrationLectureSchoolFMI.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureSchoolFMI.Size = new System.Drawing.Size(241, 59);
            this.gBoxFormRegistrationLectureSchoolFMI.TabIndex = 28;
            this.gBoxFormRegistrationLectureSchoolFMI.TabStop = false;
            this.gBoxFormRegistrationLectureSchoolFMI.Text = "Завършил висше образование";
            // 
            // txtBoxFormRegistrationLectureGraduateUniversity
            // 
            this.txtBoxFormRegistrationLectureGraduateUniversity.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationLectureGraduateUniversity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "GraduateUniversity", true));
            this.txtBoxFormRegistrationLectureGraduateUniversity.Location = new System.Drawing.Point(8, 23);
            this.txtBoxFormRegistrationLectureGraduateUniversity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFormRegistrationLectureGraduateUniversity.Name = "txtBoxFormRegistrationLectureGraduateUniversity";
            this.txtBoxFormRegistrationLectureGraduateUniversity.Size = new System.Drawing.Size(212, 22);
            this.txtBoxFormRegistrationLectureGraduateUniversity.TabIndex = 0;
            this.txtBoxFormRegistrationLectureGraduateUniversity.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // gBoxFormRegistrationLectureTitle
            // 
            this.gBoxFormRegistrationLectureTitle.Controls.Add(this.tBoxFormRegistrationLectureTitle);
            this.gBoxFormRegistrationLectureTitle.Location = new System.Drawing.Point(261, 340);
            this.gBoxFormRegistrationLectureTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureTitle.Name = "gBoxFormRegistrationLectureTitle";
            this.gBoxFormRegistrationLectureTitle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxFormRegistrationLectureTitle.Size = new System.Drawing.Size(229, 54);
            this.gBoxFormRegistrationLectureTitle.TabIndex = 29;
            this.gBoxFormRegistrationLectureTitle.TabStop = false;
            this.gBoxFormRegistrationLectureTitle.Text = "Титла";
            // 
            // tBoxFormRegistrationLectureTitle
            // 
            this.tBoxFormRegistrationLectureTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormRegistrationLectureTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLecture, "Title", true));
            this.tBoxFormRegistrationLectureTitle.Location = new System.Drawing.Point(8, 22);
            this.tBoxFormRegistrationLectureTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxFormRegistrationLectureTitle.Name = "tBoxFormRegistrationLectureTitle";
            this.tBoxFormRegistrationLectureTitle.Size = new System.Drawing.Size(212, 22);
            this.tBoxFormRegistrationLectureTitle.TabIndex = 0;
            // 
            // btnFormRegistrationLectureSave
            // 
            this.btnFormRegistrationLectureSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureSave.Location = new System.Drawing.Point(503, 401);
            this.btnFormRegistrationLectureSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormRegistrationLectureSave.Name = "btnFormRegistrationLectureSave";
            this.btnFormRegistrationLectureSave.Size = new System.Drawing.Size(121, 43);
            this.btnFormRegistrationLectureSave.TabIndex = 30;
            this.btnFormRegistrationLectureSave.Text = "Запис";
            this.btnFormRegistrationLectureSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureSave.Click += new System.EventHandler(this.BtnFormRegistrationLectureSave_Click);
            // 
            // btnFormRegistrationLectureExit
            // 
            this.btnFormRegistrationLectureExit.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationLectureExit.Location = new System.Drawing.Point(632, 401);
            this.btnFormRegistrationLectureExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormRegistrationLectureExit.Name = "btnFormRegistrationLectureExit";
            this.btnFormRegistrationLectureExit.Size = new System.Drawing.Size(121, 43);
            this.btnFormRegistrationLectureExit.TabIndex = 31;
            this.btnFormRegistrationLectureExit.Text = "Отказ";
            this.btnFormRegistrationLectureExit.UseVisualStyleBackColor = false;
            this.btnFormRegistrationLectureExit.Click += new System.EventHandler(this.BtnFormRegistrationLectureExit_Click);
            // 
            // pBLecturePicture
            // 
            this.pBLecturePicture.Image = ((System.Drawing.Image)(resources.GetObject("pBLecturePicture.Image")));
            this.pBLecturePicture.Location = new System.Drawing.Point(21, 15);
            this.pBLecturePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBLecturePicture.Name = "pBLecturePicture";
            this.pBLecturePicture.Size = new System.Drawing.Size(197, 180);
            this.pBLecturePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLecturePicture.TabIndex = 32;
            this.pBLecturePicture.TabStop = false;
            // 
            // btnEditPicture
            // 
            this.btnEditPicture.Location = new System.Drawing.Point(261, 161);
            this.btnEditPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditPicture.Name = "btnEditPicture";
            this.btnEditPicture.Size = new System.Drawing.Size(145, 33);
            this.btnEditPicture.TabIndex = 33;
            this.btnEditPicture.Text = "избери снимка";
            this.btnEditPicture.UseVisualStyleBackColor = true;
            this.btnEditPicture.Click += new System.EventHandler(this.BtnEditPicture_Click);
            // 
            // FormAddRegistrationLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 457);
            this.Controls.Add(this.btnEditPicture);
            this.Controls.Add(this.pBLecturePicture);
            this.Controls.Add(this.btnFormRegistrationLectureExit);
            this.Controls.Add(this.btnFormRegistrationLectureSave);
            this.Controls.Add(this.gBoxFormRegistrationLectureTitle);
            this.Controls.Add(this.gBoxFormRegistrationLectureSchoolFMI);
            this.Controls.Add(this.gBoxFormRegistrationLectureFaculty);
            this.Controls.Add(this.gBoxFormRegistrationLectureDepartment);
            this.Controls.Add(this.gBoxFormRegistrationLectureCity);
            this.Controls.Add(this.gBoxFormRegistrationLectureEmail);
            this.Controls.Add(this.gBoxFormRegistrationLecturePhone);
            this.Controls.Add(this.gBoxFormRegistrationLectureLastName);
            this.Controls.Add(this.gBoxFormRegistrationLectureMiddleName);
            this.Controls.Add(this.gBoxFormRegistrationLectureFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddRegistrationLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрационна форма Преподаватели";
            this.Load += new System.EventHandler(this.FormAddRegistrationLecture_Load);
            this.gBoxFormRegistrationLectureFaculty.ResumeLayout(false);
            this.gBoxFormRegistrationLectureFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLecture)).EndInit();
            this.gBoxFormRegistrationLectureCity.ResumeLayout(false);
            this.gBoxFormRegistrationLectureCity.PerformLayout();
            this.gBoxFormRegistrationLectureEmail.ResumeLayout(false);
            this.gBoxFormRegistrationLectureEmail.PerformLayout();
            this.gBoxFormRegistrationLecturePhone.ResumeLayout(false);
            this.gBoxFormRegistrationLecturePhone.PerformLayout();
            this.gBoxFormRegistrationLectureLastName.ResumeLayout(false);
            this.gBoxFormRegistrationLectureLastName.PerformLayout();
            this.gBoxFormRegistrationLectureMiddleName.ResumeLayout(false);
            this.gBoxFormRegistrationLectureMiddleName.PerformLayout();
            this.gBoxFormRegistrationLectureFirstName.ResumeLayout(false);
            this.gBoxFormRegistrationLectureFirstName.PerformLayout();
            this.gBoxFormRegistrationLectureDepartment.ResumeLayout(false);
            this.gBoxFormRegistrationLectureDepartment.PerformLayout();
            this.gBoxFormRegistrationLectureSchoolFMI.ResumeLayout(false);
            this.gBoxFormRegistrationLectureSchoolFMI.PerformLayout();
            this.gBoxFormRegistrationLectureTitle.ResumeLayout(false);
            this.gBoxFormRegistrationLectureTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLecturePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureFaculty;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureCity;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureEmail;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureEmail;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLecturePhone;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLecturePhone;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureLastName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureLastName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureMiddleName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureMiddleName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureFirstName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureFirstName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureDepartment;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureSchoolFMI;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureGraduateUniversity;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationLectureTitle;
        private System.Windows.Forms.Button btnFormRegistrationLectureSave;
        private System.Windows.Forms.Button btnFormRegistrationLectureExit;
        public System.Windows.Forms.BindingSource bsLecture;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationLectureCity;
        private System.Windows.Forms.TextBox tBoxFormRegistrationLectureFaculty;
        private System.Windows.Forms.TextBox tBoxFormRegistrationLectureDepartment;
        private System.Windows.Forms.TextBox tBoxFormRegistrationLectureTitle;
        private System.Windows.Forms.PictureBox pBLecturePicture;
        private System.Windows.Forms.Button btnEditPicture;
    }
}