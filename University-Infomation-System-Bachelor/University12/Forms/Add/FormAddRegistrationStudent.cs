using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University12.Classes;
using University12.DB;
using University12.Forms.Add;

namespace University12.Forms
{
    public partial class FormAddRegistrationStudent : Form
    {
        public TStudentSpeciality student {
            get;
            set;
        }
        public FormAddRegistrationStudent()
        {
            InitializeComponent();
        }
        public FormAddRegistrationStudent(TStudentSpeciality s)
        {
            InitializeComponent();
            student = s;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnFormRegistrationStudentSave_Click(object sender, EventArgs e)
        {
            //TStudent stu = new TStudent();
            if (bsStudent.Current == null) return;
            var stu = (bsStudent.Current as TStudent);

            if (radioButtonMale.Checked)
            {
                stu.Male = 1;
            }
            else
            {
                stu.Male = 2;
            }
            int val = 0;
            if (int.TryParse(txtBoxFormRegistrationStudentPhone.Text, out val))
            {
                stu.Phone = val;
            }

            int value = 0;
            if (int.TryParse(txtBoxFormRegistrationStudentFacultyNumber.Text, out value))
            {
                stu.FacultyNumber = value;
            }
            if (string.IsNullOrEmpty(stu.FirstName))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentMiddleName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentLastName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentFirstDateOfEnrollment.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentEmail.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(tBoxFormRegistrationStudentCity.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(tBoxFormRegistrationStudentFaculty.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            //if (string.IsNullOrEmpty(tBoxFormRegistrationStudentSpeciality.Text))
            //{
            //    MessageBox.Show("Моля, попълнете коректни данни");
            //    return;
            //}
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentFirstDateOfEnrollment.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationStudentAddress.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            string err = stu.Save();

            student.Speciality = cbSpeciality.SelectedItem as TSpeciality;
            student.Course = cbCourse.SelectedItem as TCourse;
            student.FormOfEducation = cbFormOfEdu.SelectedItem as TFormOfEducation;
            student.Student = stu;
            student.FacultyNumber = stu.FacultyNumber;
            student.EducationLevel = cbEEducationLvl.SelectedItem as TEducationLevel;
            student.StartYear = DateTime.Now;
            student.FinishYear = DateTime.Now;
            //student.date
            // student.StudentPhone = stu.Phone;

            err = student.Save();

            if (!string.IsNullOrEmpty(err))

            {
                MessageBox.Show(err);
                return;
            }
            //FileInfo file = new FileInfo(@"D:\University12(17)\lecture.png");
            //file.CopyTo(@"D:\University12(17)\University12\Images\lectur.png", true);

            MessageBox.Show("Успешно записахте студента");
            this.Close();
            return;
        }

        private void TxtBoxFormRegistrationStudentPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddRegistrationStudent_Load(object sender, EventArgs e)
        {
            if (student == null) student = new TStudentSpeciality();
            bsStudent.DataSource = student.Student;
            if (!string.IsNullOrEmpty(student.Student.Image))
            {
                pBStudentPicture.Image = Image.FromFile(student.Student.Image);
                return;
            }
            LoadSpeciality();
            LoadCourses();
            LoadEducationLvl();
            LoadFormOfEdu();
            LoadFN();
        }

        public void LoadSpeciality()
        {
            string err = string.Empty;
            List<TSpeciality> spec = new List<TSpeciality>();
            spec = TSpeciality.LoadData(out err);

            cbSpeciality.DisplayMember = "NameSpeciality";
            cbSpeciality.ValueMember = "ID";
            cbSpeciality.DataSource = spec;

            if (student != null && student.SpecialityID > 0)
                cbSpeciality.SelectedValue = student.SpecialityID;
        }

        public void LoadCourses()
        {
            string err = string.Empty;
            List<TCourse> course = new List<TCourse>();
            course = TCourse.LoadData(out err);

            cbCourse.DisplayMember = "NameCourse";
            cbCourse.ValueMember = "ID";
            cbCourse.DataSource = course;

            if (student != null && student.CourseID > 0)
                cbCourse.SelectedValue = student.CourseID;
        }

        public void LoadEducationLvl()
        {
            string err = string.Empty;
            List<TEducationLevel> el = new List<TEducationLevel>();
            el = TEducationLevel.LoadData(out err);

            cbEEducationLvl.DisplayMember = "LevelName";
            cbEEducationLvl.ValueMember = "ID";
            cbEEducationLvl.DataSource = el;

            if (student != null && student.EducationLevel != null && student.EducationLevel.ID > 0)
                cbEEducationLvl.SelectedValue = student.EducationLevel.ID;
        }
        public void LoadFormOfEdu()
        {
            string err = string.Empty;
            List<TFormOfEducation> el = new List<TFormOfEducation>();
            el = TFormOfEducation.LoadData(out err);

            cbFormOfEdu.DisplayMember = "Name";
            cbFormOfEdu.ValueMember = "ID";
            cbFormOfEdu.DataSource = el;

            if (student != null && student.FormOfEducationID > 0)
                cbFormOfEdu.SelectedValue = student.FormOfEducationID;
        }
        public void LoadFN()
        {
            txtBoxFormRegistrationStudentFacultyNumber.Text = student.FacultyNumber.ToString();
        }
        private void BtnFormRegistrationStudentExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnEditPictureSt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openp = new OpenFileDialog();

            openp.Filter = "Изберете снимка(*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            // DialogResult im = openp.ShowDialog();
            //if (im == DialogResult.Abort)
            //    return;
            //if (im == DialogResult.Cancel)
            //    return;
            if (openp.ShowDialog() == DialogResult.OK)

            {
                student.Student.Image = openp.FileName;
                pBStudentPicture.Image = Image.FromFile(openp.FileName);
            }
        }

        private void BtnElectiveSubject_Click(object sender, EventArgs e)
        {
            FormSelectCourse scf = new FormSelectCourse(student);
            scf.ShowDialog();
        }
    }
}


