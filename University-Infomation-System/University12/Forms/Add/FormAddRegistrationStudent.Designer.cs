namespace University12.Forms
{
    partial class FormAddRegistrationStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRegistrationStudent));
            this.gBoxFormRegistrationStudentFirstName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentFirstName = new System.Windows.Forms.TextBox();
            this.bsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFormRegistrationStudentMiddleName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentMiddleName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentLastName = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentLastName = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentEgn = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentPhone = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentPhone = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentEmail = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentEmail = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentCity = new System.Windows.Forms.GroupBox();
            this.tBoxFormRegistrationStudentCity = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentAddress = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentAddress = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale = new System.Windows.Forms.GroupBox();
            this.gBoxFormRegistrationStudentSchool = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentSchool = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentDateSave = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentSpeciality = new System.Windows.Forms.GroupBox();
            this.cbSpeciality = new System.Windows.Forms.ComboBox();
            this.gBoxFormRegistrationStudentFaculty = new System.Windows.Forms.GroupBox();
            this.tBoxFormRegistrationStudentFaculty = new System.Windows.Forms.TextBox();
            this.gBoxFormRegistrationStudentFacultyNumber = new System.Windows.Forms.GroupBox();
            this.txtBoxFormRegistrationStudentFacultyNumber = new System.Windows.Forms.TextBox();
            this.tStudentSpecialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFormRegistrationStudentExit = new System.Windows.Forms.Button();
            this.btnFormRegistrationStudentSave = new System.Windows.Forms.Button();
            this.btnEditPictureSt = new System.Windows.Forms.Button();
            this.pBStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnElectiveSubject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFormOfEdu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEEducationLvl = new System.Windows.Forms.ComboBox();
            this.gBoxFormRegistrationStudentFirstName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).BeginInit();
            this.gBoxFormRegistrationStudentMiddleName.SuspendLayout();
            this.gBoxFormRegistrationStudentLastName.SuspendLayout();
            this.gBoxFormRegistrationStudentEgn.SuspendLayout();
            this.gBoxFormRegistrationStudentPhone.SuspendLayout();
            this.gBoxFormRegistrationStudentEmail.SuspendLayout();
            this.gBoxFormRegistrationStudentCity.SuspendLayout();
            this.gBoxFormRegistrationStudentAddress.SuspendLayout();
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.SuspendLayout();
            this.gBoxFormRegistrationStudentSchool.SuspendLayout();
            this.gBoxFormRegistrationStudentDateSave.SuspendLayout();
            this.gBoxFormRegistrationStudentSpeciality.SuspendLayout();
            this.gBoxFormRegistrationStudentFaculty.SuspendLayout();
            this.gBoxFormRegistrationStudentFacultyNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tStudentSpecialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStudentPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxFormRegistrationStudentFirstName
            // 
            this.gBoxFormRegistrationStudentFirstName.Controls.Add(this.txtBoxFormRegistrationStudentFirstName);
            this.gBoxFormRegistrationStudentFirstName.Location = new System.Drawing.Point(374, 98);
            this.gBoxFormRegistrationStudentFirstName.Name = "gBoxFormRegistrationStudentFirstName";
            this.gBoxFormRegistrationStudentFirstName.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentFirstName.TabIndex = 0;
            this.gBoxFormRegistrationStudentFirstName.TabStop = false;
            this.gBoxFormRegistrationStudentFirstName.Text = "Име";
            // 
            // txtBoxFormRegistrationStudentFirstName
            // 
            this.txtBoxFormRegistrationStudentFirstName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "FirstName", true));
            this.txtBoxFormRegistrationStudentFirstName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentFirstName.Name = "txtBoxFormRegistrationStudentFirstName";
            this.txtBoxFormRegistrationStudentFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentFirstName.TabIndex = 0;
            this.txtBoxFormRegistrationStudentFirstName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // bsStudent
            // 
            this.bsStudent.AllowNew = false;
            this.bsStudent.DataSource = typeof(University12.Classes.TStudent);
            // 
            // gBoxFormRegistrationStudentMiddleName
            // 
            this.gBoxFormRegistrationStudentMiddleName.Controls.Add(this.txtBoxFormRegistrationStudentMiddleName);
            this.gBoxFormRegistrationStudentMiddleName.Location = new System.Drawing.Point(12, 152);
            this.gBoxFormRegistrationStudentMiddleName.Name = "gBoxFormRegistrationStudentMiddleName";
            this.gBoxFormRegistrationStudentMiddleName.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentMiddleName.TabIndex = 2;
            this.gBoxFormRegistrationStudentMiddleName.TabStop = false;
            this.gBoxFormRegistrationStudentMiddleName.Text = "Презиме";
            // 
            // txtBoxFormRegistrationStudentMiddleName
            // 
            this.txtBoxFormRegistrationStudentMiddleName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "MiddleName", true));
            this.txtBoxFormRegistrationStudentMiddleName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentMiddleName.Name = "txtBoxFormRegistrationStudentMiddleName";
            this.txtBoxFormRegistrationStudentMiddleName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentMiddleName.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentLastName
            // 
            this.gBoxFormRegistrationStudentLastName.Controls.Add(this.txtBoxFormRegistrationStudentLastName);
            this.gBoxFormRegistrationStudentLastName.Location = new System.Drawing.Point(196, 152);
            this.gBoxFormRegistrationStudentLastName.Name = "gBoxFormRegistrationStudentLastName";
            this.gBoxFormRegistrationStudentLastName.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentLastName.TabIndex = 1;
            this.gBoxFormRegistrationStudentLastName.TabStop = false;
            this.gBoxFormRegistrationStudentLastName.Text = "Фамилия";
            // 
            // txtBoxFormRegistrationStudentLastName
            // 
            this.txtBoxFormRegistrationStudentLastName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "LastName", true));
            this.txtBoxFormRegistrationStudentLastName.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentLastName.Name = "txtBoxFormRegistrationStudentLastName";
            this.txtBoxFormRegistrationStudentLastName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentLastName.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentEgn
            // 
            this.gBoxFormRegistrationStudentEgn.Controls.Add(this.txtBoxFormRegistrationStudentFirstDateOfEnrollment);
            this.gBoxFormRegistrationStudentEgn.Location = new System.Drawing.Point(374, 152);
            this.gBoxFormRegistrationStudentEgn.Name = "gBoxFormRegistrationStudentEgn";
            this.gBoxFormRegistrationStudentEgn.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentEgn.TabIndex = 3;
            this.gBoxFormRegistrationStudentEgn.TabStop = false;
            this.gBoxFormRegistrationStudentEgn.Text = "ЕГН";
            // 
            // txtBoxFormRegistrationStudentFirstDateOfEnrollment
            // 
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "EGN", true));
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.Name = "txtBoxFormRegistrationStudentFirstDateOfEnrollment";
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentFirstDateOfEnrollment.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentPhone
            // 
            this.gBoxFormRegistrationStudentPhone.Controls.Add(this.txtBoxFormRegistrationStudentPhone);
            this.gBoxFormRegistrationStudentPhone.Location = new System.Drawing.Point(12, 206);
            this.gBoxFormRegistrationStudentPhone.Name = "gBoxFormRegistrationStudentPhone";
            this.gBoxFormRegistrationStudentPhone.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentPhone.TabIndex = 4;
            this.gBoxFormRegistrationStudentPhone.TabStop = false;
            this.gBoxFormRegistrationStudentPhone.Text = "Телефон";
            // 
            // txtBoxFormRegistrationStudentPhone
            // 
            this.txtBoxFormRegistrationStudentPhone.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "Phone", true));
            this.txtBoxFormRegistrationStudentPhone.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentPhone.Name = "txtBoxFormRegistrationStudentPhone";
            this.txtBoxFormRegistrationStudentPhone.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentPhone.TabIndex = 0;
            this.txtBoxFormRegistrationStudentPhone.TextChanged += new System.EventHandler(this.TxtBoxFormRegistrationStudentPhone_TextChanged);
            // 
            // gBoxFormRegistrationStudentEmail
            // 
            this.gBoxFormRegistrationStudentEmail.Controls.Add(this.txtBoxFormRegistrationStudentEmail);
            this.gBoxFormRegistrationStudentEmail.Location = new System.Drawing.Point(195, 206);
            this.gBoxFormRegistrationStudentEmail.Name = "gBoxFormRegistrationStudentEmail";
            this.gBoxFormRegistrationStudentEmail.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentEmail.TabIndex = 5;
            this.gBoxFormRegistrationStudentEmail.TabStop = false;
            this.gBoxFormRegistrationStudentEmail.Text = "Имейл";
            // 
            // txtBoxFormRegistrationStudentEmail
            // 
            this.txtBoxFormRegistrationStudentEmail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "Email", true));
            this.txtBoxFormRegistrationStudentEmail.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentEmail.Name = "txtBoxFormRegistrationStudentEmail";
            this.txtBoxFormRegistrationStudentEmail.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentEmail.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentCity
            // 
            this.gBoxFormRegistrationStudentCity.Controls.Add(this.tBoxFormRegistrationStudentCity);
            this.gBoxFormRegistrationStudentCity.Location = new System.Drawing.Point(374, 206);
            this.gBoxFormRegistrationStudentCity.Name = "gBoxFormRegistrationStudentCity";
            this.gBoxFormRegistrationStudentCity.Size = new System.Drawing.Size(178, 48);
            this.gBoxFormRegistrationStudentCity.TabIndex = 6;
            this.gBoxFormRegistrationStudentCity.TabStop = false;
            this.gBoxFormRegistrationStudentCity.Text = "Град";
            // 
            // tBoxFormRegistrationStudentCity
            // 
            this.tBoxFormRegistrationStudentCity.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormRegistrationStudentCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "City", true));
            this.tBoxFormRegistrationStudentCity.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormRegistrationStudentCity.Name = "tBoxFormRegistrationStudentCity";
            this.tBoxFormRegistrationStudentCity.Size = new System.Drawing.Size(165, 20);
            this.tBoxFormRegistrationStudentCity.TabIndex = 1;
            // 
            // gBoxFormRegistrationStudentAddress
            // 
            this.gBoxFormRegistrationStudentAddress.Controls.Add(this.txtBoxFormRegistrationStudentAddress);
            this.gBoxFormRegistrationStudentAddress.Location = new System.Drawing.Point(12, 260);
            this.gBoxFormRegistrationStudentAddress.Name = "gBoxFormRegistrationStudentAddress";
            this.gBoxFormRegistrationStudentAddress.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentAddress.TabIndex = 7;
            this.gBoxFormRegistrationStudentAddress.TabStop = false;
            this.gBoxFormRegistrationStudentAddress.Text = "Адрес";
            // 
            // txtBoxFormRegistrationStudentAddress
            // 
            this.txtBoxFormRegistrationStudentAddress.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "Address", true));
            this.txtBoxFormRegistrationStudentAddress.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentAddress.Name = "txtBoxFormRegistrationStudentAddress";
            this.txtBoxFormRegistrationStudentAddress.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentAddress.TabIndex = 0;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(71, 19);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // gBoxFormRegistrationStudentsRadioButtonMaleFemale
            // 
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Controls.Add(this.radioButtonMale);
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Controls.Add(this.radioButtonFemale);
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Location = new System.Drawing.Point(18, 448);
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Name = "gBoxFormRegistrationStudentsRadioButtonMaleFemale";
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Size = new System.Drawing.Size(160, 48);
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.TabIndex = 10;
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.TabStop = false;
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.Text = "Пол";
            // 
            // gBoxFormRegistrationStudentSchool
            // 
            this.gBoxFormRegistrationStudentSchool.Controls.Add(this.txtBoxFormRegistrationStudentSchool);
            this.gBoxFormRegistrationStudentSchool.Location = new System.Drawing.Point(195, 260);
            this.gBoxFormRegistrationStudentSchool.Name = "gBoxFormRegistrationStudentSchool";
            this.gBoxFormRegistrationStudentSchool.Size = new System.Drawing.Size(173, 48);
            this.gBoxFormRegistrationStudentSchool.TabIndex = 11;
            this.gBoxFormRegistrationStudentSchool.TabStop = false;
            this.gBoxFormRegistrationStudentSchool.Text = "Завършил средно училище";
            // 
            // txtBoxFormRegistrationStudentSchool
            // 
            this.txtBoxFormRegistrationStudentSchool.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentSchool.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "GraduateSecondarySchool", true));
            this.txtBoxFormRegistrationStudentSchool.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentSchool.Name = "txtBoxFormRegistrationStudentSchool";
            this.txtBoxFormRegistrationStudentSchool.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentSchool.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentDateSave
            // 
            this.gBoxFormRegistrationStudentDateSave.Controls.Add(this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave);
            this.gBoxFormRegistrationStudentDateSave.Location = new System.Drawing.Point(374, 314);
            this.gBoxFormRegistrationStudentDateSave.Name = "gBoxFormRegistrationStudentDateSave";
            this.gBoxFormRegistrationStudentDateSave.Size = new System.Drawing.Size(189, 48);
            this.gBoxFormRegistrationStudentDateSave.TabIndex = 12;
            this.gBoxFormRegistrationStudentDateSave.TabStop = false;
            this.gBoxFormRegistrationStudentDateSave.Text = "Дата на записване в първи курс";
            // 
            // txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave
            // 
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStudentSpecialityBindingSource, "StartYear", true));
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.Name = "txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave";
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.Size = new System.Drawing.Size(166, 20);
            this.txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave.TabIndex = 1;
            // 
            // gBoxFormRegistrationStudentSpeciality
            // 
            this.gBoxFormRegistrationStudentSpeciality.Controls.Add(this.cbSpeciality);
            this.gBoxFormRegistrationStudentSpeciality.Location = new System.Drawing.Point(195, 314);
            this.gBoxFormRegistrationStudentSpeciality.Name = "gBoxFormRegistrationStudentSpeciality";
            this.gBoxFormRegistrationStudentSpeciality.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentSpeciality.TabIndex = 13;
            this.gBoxFormRegistrationStudentSpeciality.TabStop = false;
            this.gBoxFormRegistrationStudentSpeciality.Text = "Специалност";
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbSpeciality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(3, 16);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(166, 21);
            this.cbSpeciality.TabIndex = 0;
            // 
            // gBoxFormRegistrationStudentFaculty
            // 
            this.gBoxFormRegistrationStudentFaculty.Controls.Add(this.tBoxFormRegistrationStudentFaculty);
            this.gBoxFormRegistrationStudentFaculty.Location = new System.Drawing.Point(377, 260);
            this.gBoxFormRegistrationStudentFaculty.Name = "gBoxFormRegistrationStudentFaculty";
            this.gBoxFormRegistrationStudentFaculty.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentFaculty.TabIndex = 14;
            this.gBoxFormRegistrationStudentFaculty.TabStop = false;
            this.gBoxFormRegistrationStudentFaculty.Text = "Факултет";
            // 
            // tBoxFormRegistrationStudentFaculty
            // 
            this.tBoxFormRegistrationStudentFaculty.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tBoxFormRegistrationStudentFaculty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudent, "FacultyName", true));
            this.tBoxFormRegistrationStudentFaculty.Location = new System.Drawing.Point(6, 19);
            this.tBoxFormRegistrationStudentFaculty.Name = "tBoxFormRegistrationStudentFaculty";
            this.tBoxFormRegistrationStudentFaculty.Size = new System.Drawing.Size(160, 20);
            this.tBoxFormRegistrationStudentFaculty.TabIndex = 2;
            // 
            // gBoxFormRegistrationStudentFacultyNumber
            // 
            this.gBoxFormRegistrationStudentFacultyNumber.Controls.Add(this.txtBoxFormRegistrationStudentFacultyNumber);
            this.gBoxFormRegistrationStudentFacultyNumber.Location = new System.Drawing.Point(12, 314);
            this.gBoxFormRegistrationStudentFacultyNumber.Name = "gBoxFormRegistrationStudentFacultyNumber";
            this.gBoxFormRegistrationStudentFacultyNumber.Size = new System.Drawing.Size(172, 48);
            this.gBoxFormRegistrationStudentFacultyNumber.TabIndex = 15;
            this.gBoxFormRegistrationStudentFacultyNumber.TabStop = false;
            this.gBoxFormRegistrationStudentFacultyNumber.Text = "Фалкултетен номер";
            // 
            // txtBoxFormRegistrationStudentFacultyNumber
            // 
            this.txtBoxFormRegistrationStudentFacultyNumber.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtBoxFormRegistrationStudentFacultyNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStudentSpecialityBindingSource, "FacultyName", true));
            this.txtBoxFormRegistrationStudentFacultyNumber.Location = new System.Drawing.Point(6, 19);
            this.txtBoxFormRegistrationStudentFacultyNumber.Name = "txtBoxFormRegistrationStudentFacultyNumber";
            this.txtBoxFormRegistrationStudentFacultyNumber.Size = new System.Drawing.Size(160, 20);
            this.txtBoxFormRegistrationStudentFacultyNumber.TabIndex = 1;
            // 
            // tStudentSpecialityBindingSource
            // 
            this.tStudentSpecialityBindingSource.DataSource = typeof(University12.Classes.TStudentSpeciality);
            // 
            // btnFormRegistrationStudentExit
            // 
            this.btnFormRegistrationStudentExit.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationStudentExit.Location = new System.Drawing.Point(461, 467);
            this.btnFormRegistrationStudentExit.Name = "btnFormRegistrationStudentExit";
            this.btnFormRegistrationStudentExit.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationStudentExit.TabIndex = 33;
            this.btnFormRegistrationStudentExit.Text = "Отказ";
            this.btnFormRegistrationStudentExit.UseVisualStyleBackColor = false;
            this.btnFormRegistrationStudentExit.Click += new System.EventHandler(this.BtnFormRegistrationStudentExit_Click);
            // 
            // btnFormRegistrationStudentSave
            // 
            this.btnFormRegistrationStudentSave.BackColor = System.Drawing.Color.White;
            this.btnFormRegistrationStudentSave.Location = new System.Drawing.Point(364, 467);
            this.btnFormRegistrationStudentSave.Name = "btnFormRegistrationStudentSave";
            this.btnFormRegistrationStudentSave.Size = new System.Drawing.Size(91, 35);
            this.btnFormRegistrationStudentSave.TabIndex = 32;
            this.btnFormRegistrationStudentSave.Text = "Запис";
            this.btnFormRegistrationStudentSave.UseVisualStyleBackColor = false;
            this.btnFormRegistrationStudentSave.Click += new System.EventHandler(this.BtnFormRegistrationStudentSave_Click);
            // 
            // btnEditPictureSt
            // 
            this.btnEditPictureSt.Location = new System.Drawing.Point(195, 110);
            this.btnEditPictureSt.Name = "btnEditPictureSt";
            this.btnEditPictureSt.Size = new System.Drawing.Size(109, 27);
            this.btnEditPictureSt.TabIndex = 35;
            this.btnEditPictureSt.Text = "избери снимка";
            this.btnEditPictureSt.UseVisualStyleBackColor = true;
            this.btnEditPictureSt.Click += new System.EventHandler(this.BtnEditPictureSt_Click);
            // 
            // pBStudentPicture
            // 
            this.pBStudentPicture.Image = ((System.Drawing.Image)(resources.GetObject("pBStudentPicture.Image")));
            this.pBStudentPicture.Location = new System.Drawing.Point(30, 12);
            this.pBStudentPicture.Name = "pBStudentPicture";
            this.pBStudentPicture.Size = new System.Drawing.Size(148, 134);
            this.pBStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBStudentPicture.TabIndex = 34;
            this.pBStudentPicture.TabStop = false;
            // 
            // btnElectiveSubject
            // 
            this.btnElectiveSubject.BackColor = System.Drawing.Color.White;
            this.btnElectiveSubject.Location = new System.Drawing.Point(424, 26);
            this.btnElectiveSubject.Name = "btnElectiveSubject";
            this.btnElectiveSubject.Size = new System.Drawing.Size(91, 54);
            this.btnElectiveSubject.TabIndex = 38;
            this.btnElectiveSubject.Text = "Свободно избираеми дисциплини";
            this.btnElectiveSubject.UseVisualStyleBackColor = false;
            this.btnElectiveSubject.Click += new System.EventHandler(this.BtnElectiveSubject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFormOfEdu);
            this.groupBox1.Location = new System.Drawing.Point(12, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 48);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма на обучение";
            // 
            // cbFormOfEdu
            // 
            this.cbFormOfEdu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbFormOfEdu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFormOfEdu.FormattingEnabled = true;
            this.cbFormOfEdu.Location = new System.Drawing.Point(3, 16);
            this.cbFormOfEdu.Name = "cbFormOfEdu";
            this.cbFormOfEdu.Size = new System.Drawing.Size(166, 21);
            this.cbFormOfEdu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCourse);
            this.groupBox2.Location = new System.Drawing.Point(198, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Курс";
            // 
            // cbCourse
            // 
            this.cbCourse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(3, 16);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(166, 21);
            this.cbCourse.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEEducationLvl);
            this.groupBox3.Location = new System.Drawing.Point(377, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 48);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Образователна степен";
            // 
            // cbEEducationLvl
            // 
            this.cbEEducationLvl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbEEducationLvl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEEducationLvl.FormattingEnabled = true;
            this.cbEEducationLvl.Location = new System.Drawing.Point(3, 16);
            this.cbEEducationLvl.Name = "cbEEducationLvl";
            this.cbEEducationLvl.Size = new System.Drawing.Size(166, 21);
            this.cbEEducationLvl.TabIndex = 0;
            // 
            // FormAddRegistrationStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnElectiveSubject);
            this.Controls.Add(this.btnEditPictureSt);
            this.Controls.Add(this.pBStudentPicture);
            this.Controls.Add(this.btnFormRegistrationStudentExit);
            this.Controls.Add(this.btnFormRegistrationStudentSave);
            this.Controls.Add(this.gBoxFormRegistrationStudentFacultyNumber);
            this.Controls.Add(this.gBoxFormRegistrationStudentFaculty);
            this.Controls.Add(this.gBoxFormRegistrationStudentSpeciality);
            this.Controls.Add(this.gBoxFormRegistrationStudentDateSave);
            this.Controls.Add(this.gBoxFormRegistrationStudentSchool);
            this.Controls.Add(this.gBoxFormRegistrationStudentsRadioButtonMaleFemale);
            this.Controls.Add(this.gBoxFormRegistrationStudentAddress);
            this.Controls.Add(this.gBoxFormRegistrationStudentCity);
            this.Controls.Add(this.gBoxFormRegistrationStudentEmail);
            this.Controls.Add(this.gBoxFormRegistrationStudentPhone);
            this.Controls.Add(this.gBoxFormRegistrationStudentEgn);
            this.Controls.Add(this.gBoxFormRegistrationStudentLastName);
            this.Controls.Add(this.gBoxFormRegistrationStudentMiddleName);
            this.Controls.Add(this.gBoxFormRegistrationStudentFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddRegistrationStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрационна форма Студенти";
            this.Load += new System.EventHandler(this.FormAddRegistrationStudent_Load);
            this.gBoxFormRegistrationStudentFirstName.ResumeLayout(false);
            this.gBoxFormRegistrationStudentFirstName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).EndInit();
            this.gBoxFormRegistrationStudentMiddleName.ResumeLayout(false);
            this.gBoxFormRegistrationStudentMiddleName.PerformLayout();
            this.gBoxFormRegistrationStudentLastName.ResumeLayout(false);
            this.gBoxFormRegistrationStudentLastName.PerformLayout();
            this.gBoxFormRegistrationStudentEgn.ResumeLayout(false);
            this.gBoxFormRegistrationStudentEgn.PerformLayout();
            this.gBoxFormRegistrationStudentPhone.ResumeLayout(false);
            this.gBoxFormRegistrationStudentPhone.PerformLayout();
            this.gBoxFormRegistrationStudentEmail.ResumeLayout(false);
            this.gBoxFormRegistrationStudentEmail.PerformLayout();
            this.gBoxFormRegistrationStudentCity.ResumeLayout(false);
            this.gBoxFormRegistrationStudentCity.PerformLayout();
            this.gBoxFormRegistrationStudentAddress.ResumeLayout(false);
            this.gBoxFormRegistrationStudentAddress.PerformLayout();
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.ResumeLayout(false);
            this.gBoxFormRegistrationStudentsRadioButtonMaleFemale.PerformLayout();
            this.gBoxFormRegistrationStudentSchool.ResumeLayout(false);
            this.gBoxFormRegistrationStudentSchool.PerformLayout();
            this.gBoxFormRegistrationStudentDateSave.ResumeLayout(false);
            this.gBoxFormRegistrationStudentDateSave.PerformLayout();
            this.gBoxFormRegistrationStudentSpeciality.ResumeLayout(false);
            this.gBoxFormRegistrationStudentFaculty.ResumeLayout(false);
            this.gBoxFormRegistrationStudentFaculty.PerformLayout();
            this.gBoxFormRegistrationStudentFacultyNumber.ResumeLayout(false);
            this.gBoxFormRegistrationStudentFacultyNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tStudentSpecialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStudentPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentFirstName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentFirstName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentMiddleName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentMiddleName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentLastName;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentLastName;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentEgn;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentFirstDateOfEnrollment;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentPhone;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentPhone;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentEmail;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentEmail;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentCity;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentAddress;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentAddress;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentsRadioButtonMaleFemale;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentSchool;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentSchool;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentDateSave;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentSpeciality;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentFaculty;
        private System.Windows.Forms.GroupBox gBoxFormRegistrationStudentFacultyNumber;
        private System.Windows.Forms.Button btnFormRegistrationStudentExit;
        private System.Windows.Forms.Button btnFormRegistrationStudentSave;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentFacultyNumbertxtBoxFormRegistrationStudentDateSave;
        private System.Windows.Forms.TextBox txtBoxFormRegistrationStudentFacultyNumber;
        public System.Windows.Forms.BindingSource bsStudent;
        private System.Windows.Forms.TextBox tBoxFormRegistrationStudentCity;
        private System.Windows.Forms.TextBox tBoxFormRegistrationStudentFaculty;
        private System.Windows.Forms.Button btnEditPictureSt;
        private System.Windows.Forms.PictureBox pBStudentPicture;
        private System.Windows.Forms.Button btnElectiveSubject;
        private System.Windows.Forms.ComboBox cbSpeciality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFormOfEdu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbEEducationLvl;
        private System.Windows.Forms.BindingSource tStudentSpecialityBindingSource;
    }
}