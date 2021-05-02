using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University12.Classes;
using University12.DB;

namespace University12.Forms
{
    public partial class FormAddRegistrationLecture : Form
    {
        public TLecture lecture { get; set; }
        public FormAddRegistrationLecture()
        {
            InitializeComponent();

        }
        public FormAddRegistrationLecture(TLecture l)
        {
            InitializeComponent();
            lecture = l;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {


            //TLecture lect = new TLecture();
            if (bsLecture.Current == null) return;
            var lecture = (bsLecture.Current as TLecture);

            //lecture.FirstName = txtBoxFormRegistrationLectureFirstName.Text;
            //lecture.MiddleName = txtBoxFormRegistrationLectureMiddleName.Text;
            //lecture.LastName = txtBoxFormRegistrationLectureLastName.Text;
            //lecture.Title = comBoxFormRegistrationLectureTitle.Text;
            //lecture.Email = txtBoxFormRegistrationLectureEmail.Text;
            //lecture.Faculty = comBoxFormRegistrationLectureFaculty.Text;
            //lecture.GraduateUniversity = txtBoxFormRegistrationLectureGraduateUniversity.Text;
            //lecture.Department = comBoxFormRegistrationLectureDepartment.Text;
            //lecture.GraduateUniversity = txtBoxFormRegistrationLectureGraduateUniversity.Text;


            int val = 0;
            if (int.TryParse(txtBoxFormRegistrationLecturePhone.Text, out val))
            {
                lecture.Phone = val;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureFirstName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureMiddleName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureLastName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureEmail.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLecturePhone.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(tBoxFormRegistrationLectureDepartment.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureCity.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            if (string.IsNullOrEmpty(tBoxFormRegistrationLectureTitle.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            if (string.IsNullOrEmpty(tBoxFormRegistrationLectureFaculty.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxFormRegistrationLectureGraduateUniversity.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            string err = lecture.Save();
            //lect.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            //File.Copy(pBLecturePicture, Path.Combine(@"D:\University12(17)\University12\Images\", )

            MessageBox.Show("Записахте  успешно преподавателя");
            this.Close();
            return;

        }

        private void FormAddRegistrationLecture_Load(object sender, EventArgs e)
        {
            if (lecture == null) lecture = new TLecture();
            bsLecture.DataSource = lecture;

           if (!string.IsNullOrEmpty(lecture.Image))
            {
                pBLecturePicture.Image = Image.FromFile(lecture.Image);
            }
        }

        private void BtnFormRegistrationLectureExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openp = new OpenFileDialog();

            openp.Filter = "Изберете снимка(*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            //DialogResult im = openp.ShowDialog();
            //if (im == DialogResult.Abort)
            //    return;
            //if (im == DialogResult.Cancel)
            //    return;
            if (openp.ShowDialog() == DialogResult.OK)

            {
                lecture.Image = openp.FileName;
                pBLecturePicture.Image = Image.FromFile(openp.FileName);
                //File.Copy(pBLecturePicture, Path.Combine(@"D:\University12(17)\University12\Images\", )
            }
        }



    }
}
