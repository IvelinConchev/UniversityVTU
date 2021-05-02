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
    public partial class FormStudents : Form
    {
        List<TStudentSpeciality> Students = new List<TStudentSpeciality>();
        public TFaculty facult { get; set; }
        public TSpeciality specName { get; set; }

        public FormStudents()
        {
            InitializeComponent();
        }

        public void LoadStudent()
        {
            string error = string.Empty;
            this.Students = TStudentSpeciality.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsStudents.DataSource = Students;
        }


        public void Filter()
        {
            List<TStudentSpeciality> Stud = new List<TStudentSpeciality>();
            if (facult.ID > 0)
            {
                Stud = this.Students.Where(fc => fc.FacultyID == facult.ID).ToList();
            }
            else
            {
                Stud = this.Students;
            }


            if (specName != null && specName.ID > 0)
            {
                Stud = Students.Where(stu => stu.Speciality.ID == specName.ID).ToList();
            }

            bsStudents.DataSource = Stud;
        }
        public void LoadFaculty()
        {
            List<TFaculty> faculties = new List<TFaculty>();
            string error = string.Empty;
            faculties = TFaculty.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на факултети");
                return;
            }

            TFaculty f = new TFaculty();
            f.FacultyName = "всички";
            f.ID = -1;

            faculties.Insert(0, f);
            cBoxStudentsFaculty.DisplayMember = "FacultyName";
            cBoxStudentsFaculty.ValueMember = "ID";
            cBoxStudentsFaculty.DataSource = faculties;
        }

        public void LoadSpeciality()
        {
            List<TSpeciality> specialities = new List<TSpeciality>();
            string error = string.Empty;
            specialities = TSpeciality.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на специалности");
                return;
            }
            TSpeciality s = new TSpeciality();
            s.NameSpeciality = "всички";
            s.ID = -1;

            specialities.Insert(0, s);

            cBoxStudentsSpeciality.DisplayMember = "NameSpeciality";
            cBoxStudentsSpeciality.ValueMember = "ID";
            //Изключване на събитие
            cBoxStudentsSpeciality.SelectedIndexChanged -= new EventHandler(CBoxStudentsSpeciality_SelectedIndexChanged);
            cBoxStudentsSpeciality.DataSource = specialities;
            //Включване на събитие
            cBoxStudentsSpeciality.SelectedIndexChanged += new EventHandler(CBoxStudentsSpeciality_SelectedIndexChanged);
        }


        private void DataGridViewLectures_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var x = (dataGridViewLectures.Rows[e.RowIndex].DataBoundItem as TStudentSpeciality);

            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture == true)
            {
                MessageBox.Show("Нямате права за редактиране на студенти!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if ((Program.CurrentUser.IsStudent && Program.CurrentUser.FirstName.ToLower() == x.Student.FirstName.ToLower()
                && Program.CurrentUser.LastName.ToLower() == x.Student.LastName.ToLower()) || Program.CurrentUser.IsAdmin)
            {
                FormAddRegistrationStudent st = new FormAddRegistrationStudent();
                st.student = x;
                st.ShowDialog();
            }
        }

        private void BtnStudentsAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на студенти!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddRegistrationStudent st = new FormAddRegistrationStudent();
            st.ShowDialog();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            this.LoadStudent();
            this.LoadFaculty();
            this.LoadSpeciality();
            this.Text = "Студенти";

        }

        private void DataGridViewLectures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStudentsSubject_Click(object sender, EventArgs e)
        {
            FormSubjects sub = new FormSubjects();
            sub.ShowDialog();
        }

        private void btnStudentsExam_Click(object sender, EventArgs e)
        {
            FormЕvaluation formЕvaluation = new FormЕvaluation();
            formЕvaluation.ShowDialog();
        }

        private void btnStudentsEvaluation_Click(object sender, EventArgs e)
        {
            FormЕvaluation ev = new FormЕvaluation();
            ev.ShowDialog();
        }

        private void cBoxStudentsFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxStudentsFaculty.SelectedItem != null)
            {
                TFaculty f = cBoxStudentsFaculty.SelectedItem as TFaculty;
                if (f == null) return;
                this.facult = f;
                Filter();
            }
        }


        private void CBoxStudentsSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxStudentsSpeciality.SelectedItem != null)
            {
                TSpeciality s = cBoxStudentsSpeciality.SelectedItem as TSpeciality;
                if (s == null) return;
                this.specName = s;
                Filter();
            }
        }

        private void BtnStudentsSearch_Click(object sender, EventArgs e)
        {
            List<TStudentSpeciality> students = new List<TStudentSpeciality>();

            string str = tBoxStudentsSearch.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(str))
            {
                students = Students;
                //MessageBox.Show("Моля попълнете символ за търсене");
                //return;
            }
            else
            {

                students = Students.Where(st => st.Student != null && ( st.Student.FirstName.ToLower().Trim().Contains(str)
                || st.Student.MiddleName.ToLower().Trim().Contains(str)
                || st.Student.LastName.ToLower().Trim().Contains(str)
                || st.Student.City.ToLower().Trim().Contains(str)
                || st.SpecialityName.ToLower().Trim().Contains(str)
                || st.CourseName.ToLower().Trim().Contains(str)
                || st.FormOfEducation.Name.Trim().Contains(str)
                || st.Student.EGN.ToLower().Trim().Contains(str)
                || (st.Student.Email != null && st.Student.Email.ToLower().Trim().Contains(str))
                || st.Student.Phone.ToString().Contains(str)
                || st.FacultyNumber.ToString().Contains(str)
                || st.Faculty.FacultyName.ToLower().Trim().Contains(str)
                || (st.Student.Address != null && st.Student.Address.ToLower().Trim().Contains(str))
                || st.Student.GraduateSecondarySchool.ToLower().Trim().Contains(str)
                || st.Speciality.NameSpeciality.ToLower().Trim().Contains(str))).ToList();

            }
            bsStudents.DataSource = students;

        }

    }
}

