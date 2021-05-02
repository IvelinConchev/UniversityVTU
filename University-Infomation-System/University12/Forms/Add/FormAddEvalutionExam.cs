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

namespace University12.Forms.Add
{
    public partial class FormAddEvalutionExam : Form
    {
        public TEvaluation evaluation { get; set; }
        public FormAddEvalutionExam()
        {
            InitializeComponent();
        }
        public FormAddEvalutionExam(TEvaluation e)
        {
            InitializeComponent();
            evaluation = e;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bsEvaluation.Current == null) return;
            var evalution_ = (bsEvaluation.Current as TEvaluation);

            if (string.IsNullOrEmpty(cBoxSpeciality.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cBoxCourse.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cBoxLecture.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cBoxStudent.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cBoxSubject.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (evalution_.Number < 2 || evalution_.Number > 6)
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            //evaluation.CourseName = cBoxCourse.Text;


            string err = evaluation.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            MessageBox.Show("Записахте успешно оценката");
            this.Close();
            return;

        }

        public void LoadSpeciality()
        {
            List<TSpeciality> specialities = new List<TSpeciality>();
            string error = string.Empty;
            specialities = TSpeciality.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на специалност");
                return;
            }

            cBoxSpeciality.DisplayMember = "NameSpeciality";
            cBoxSpeciality.ValueMember = "ID";
            cBoxSpeciality.DataSource = specialities;
        }

        public void LoadLecture()
        {
            List<TEvaluation> lectures = new List<TEvaluation>();
            string error = string.Empty;
            lectures = TEvaluation.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на лектор");
                return;
            }

            cBoxLecture.DisplayMember = "LectureName";
            cBoxLecture.ValueMember = "ID";
            cBoxLecture.DataSource = lectures;
        }

        public void LoadStudent()
        {
            List<TEvaluation> students = new List<TEvaluation>();
            string error = string.Empty;
            students = TEvaluation.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на студент");
                return;
            }

            cBoxStudent.DisplayMember = "StudentName";
            cBoxStudent.ValueMember = "ID";
            cBoxStudent.DataSource = students;
        }

        public void LoadCourse()
        {
            List<TCourse> courses = new List<TCourse>();
            string error = string.Empty;
            courses = TCourse.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на курс");
                return;
            }

            cBoxCourse.DisplayMember = "NameCourse";
            cBoxCourse.ValueMember = "ID";
            cBoxCourse.DataSource = courses;
        }

        public void LoadSubject()
        {
            List<TSubject> subjects = new List<TSubject>();
            string error = string.Empty;
            subjects = TSubject.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на специалност");
                return;
            }

            cBoxSubject.DisplayMember = "SubjectName";
            cBoxSubject.ValueMember = "ID";
            cBoxSubject.DataSource = subjects;



        }


        private void FormAddEvalutionExam_Load(object sender, EventArgs e)
        {
            this.LoadSubject();
            this.LoadCourse();
            this.LoadStudent();
            this.LoadLecture();
            this.LoadSpeciality();
            if (evaluation == null) evaluation = new TEvaluation();
            bsEvaluation.DataSource = evaluation;


        }
    }
}
