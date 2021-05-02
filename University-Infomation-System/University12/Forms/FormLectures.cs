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

namespace University12.Forms
{
    public partial class FormLectures : Form
    {
        List<TLecture> Lectures = new List<TLecture>();
        int departmentID = -1;
        public FormLectures()
        {
            InitializeComponent();
        }

        public void LoadLecture()
        {
            string error = string.Empty;
            this.Lectures = TLecture.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }

            bsLecture.DataSource = Lectures;
        }
        public void Filter()
        {
            List<TLecture> lectures = new List<TLecture>();
            if (departmentID > 0)
            {
                lectures = this.Lectures.Where(d => d.DepartmentID == departmentID).ToList();
            }
            else
            {
                lectures = this.Lectures;
            }
            bsLecture.DataSource = lectures;

        }

        private void BtnLectureStudent_Click(object sender, EventArgs e)
        {
            FormStudents formStudents = new FormStudents();
            formStudents.ShowDialog();
        }

        public void LoadDepartment()
        {
            List<TDepartments> departments = new List<TDepartments>();
            string error = string.Empty;
            departments = TDepartments.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на катедра");
                return;
            }
            TDepartments depart = new TDepartments();
            depart.Name = "всички";
            depart.ID = -1;

            departments.Insert(0, depart);

            cBoxLecturesDepartments.DisplayMember = "Name";
            cBoxLecturesDepartments.ValueMember = "ID";
            cBoxLecturesDepartments.DataSource = departments;
        }
        private void BtnLectureSubject_Click(object sender, EventArgs e)
        {
            FormSubjects formSubjects = new FormSubjects();
            formSubjects.ShowDialog();
        }

        private void BtnLectureExam_Click(object sender, EventArgs e)
        {
            FormExam formЕxam = new FormExam();
            formЕxam.ShowDialog();

        }

        private void BtnLectureEvaluation_Click(object sender, EventArgs e)
        {
            FormЕvaluation formЕvaluation = new FormЕvaluation();
            formЕvaluation.ShowDialog();
        }

        private void DataGridViewLectures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var xt = (dgvLectures.Rows[e.RowIndex].DataBoundItem as TLecture);
            if (xt == null) return;

            if (Program.CurrentUser.IsStudent)
            {
                MessageBox.Show("Нямате права за редактиране на преподаватели!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if ((Program.CurrentUser.IsLecture && xt.FirstName.ToLower() == Program.CurrentUser.FirstName.ToLower() 
                && xt.LastName.ToLower() == Program.CurrentUser.LastName.ToLower()) || Program.CurrentUser.IsAdmin)
            {
                FormAddRegistrationLecture lc = new FormAddRegistrationLecture();
                lc.lecture = xt;
                lc.ShowDialog();
            }
        }

        private void FormLectures_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BtnLecturesAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent )
            {
                MessageBox.Show("Нямате права за добавяне на преподаватели!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddRegistrationLecture lc = new FormAddRegistrationLecture();
            lc.ShowDialog();
        }

        private void DataGridViewLectures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLectures_Load(object sender, EventArgs e)
        {
            this.LoadLecture();
            this.LoadDepartment();
        }

        private void cBoxLecturesDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxLecturesDepartments.SelectedItem != null)
            {
                TDepartments d = cBoxLecturesDepartments.SelectedItem as TDepartments;
                if (d == null) return;
                this.departmentID = d.ID;
                Filter();
            }
        }

        private void BtnLecturesSearch_Click(object sender, EventArgs e)
        {
            List<TLecture> lectures = new List<TLecture>();

            string lec = tBoxLecturesSearch.Text;
            lec = lec.ToLower().Trim();

            if (string.IsNullOrEmpty(lec))
            {
                lectures = Lectures;
            }
            else
            {
                lectures = Lectures.Where(lect => lect.FirstName.ToLower().Trim().Contains(lec)
             || lect.MiddleName.ToLower().Trim().Contains(lec)
             || lect.LastName.ToLower().Trim().Contains(lec)
             || lect.Title.ToLower().Trim().Contains(lec)
             || (lect.Phone.ToString().Contains(lec))
             || lect.Email.ToLower().Trim().Contains(lec)
            // || lect.Faculty.ToLower().Trim().Contains(lec)
             || lect.Faculty.ToString().Contains(lec)
             || lect.GraduateUniversity.ToLower().Trim().Contains(lec)
             || lect.City.ToLower().Trim().Contains(lec)).ToList();
            }

            bsLecture.DataSource = lectures;

        }
    }
}