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
    public partial class FormAddElectiveSubject : Form
    {

        List<TStudentCourse> StudentSpecs { get; set; }
        int courseID = -1;
        int specID = -1;
        public TStudentSpeciality student { get; set; }
        public TCourse course { get; set; }
        public FormAddElectiveSubject()
        {
            InitializeComponent();
        }

        public void LoadStudent()
        {

            string error = string.Empty;
            this.StudentSpecs = TStudentCourse.LoadData(student.StudentID, course, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsStudentSubjects.DataSource = StudentSpecs;
        }

        public void Filter()
        {
            List<TStudentCourse> studentCourses = new List<TStudentCourse>();
            if (courseID > 0)
            {
                studentCourses = this.StudentSpecs.Where(s => s.CourseID == courseID).ToList();
            }
            else
            {
                studentCourses = this.StudentSpecs;
            }
            if (specID > 0)
            {
                studentCourses = studentCourses.Where(e => e.SpecialityID == specID).ToList();
            }
            bsStudentSubjects.DataSource = studentCourses;
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
            TCourse course = new TCourse();
            course.NameCourse = "Всички";
            course.ID = -1;

            courses.Insert(0, course);

            cBoxFormElectiveSubjects.DisplayMember = "NameCourse";
            cBoxFormElectiveSubjects.ValueMember = "ID";
            cBoxFormElectiveSubjects.DataSource = courses;
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
            TSpeciality speciality = new TSpeciality();
            speciality.NameSpeciality = "Всички";
            speciality.ID = -1;

            specialities.Insert(0, speciality);
            cBoxFormElectiveSubjectsSpeciality.DisplayMember = "NameSpeciality";
            cBoxFormElectiveSubjectsSpeciality.ValueMember = "ID";
            cBoxFormElectiveSubjectsSpeciality.DataSource = specialities;
        }

        private void FormAddElectiveSubject_Load(object sender, EventArgs e)
        {
            this.LoadStudent();
            this.LoadCourse();
            this.LoadSpeciality();
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            foreach (var st in StudentSpecs)
            {
                string sErr = st.Save();
                if (!string.IsNullOrEmpty(sErr)) { MessageBox.Show(sErr); return; }
            }
            MessageBox.Show("Данните са записани успешно!");
        }

        private void cBoxFormElectiveSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFormElectiveSubjects.SelectedItem != null)
            {
                TCourse c = cBoxFormElectiveSubjects.SelectedItem as TCourse;
                if (c == null) return;
                this.courseID = c.ID;
                Filter();
            }
        }

        private void cBoxFormElectiveSubjectsSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFormElectiveSubjectsSpeciality.SelectedItem != null)
            {
                TSpeciality s = cBoxFormElectiveSubjectsSpeciality.SelectedItem as TSpeciality;
                if (s == null) return;
                this.specID = s.ID;
                Filter();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colSelected.Index)
            {
                if (e.RowIndex < 0) return;
                var c = (dGStudentsCourse.Rows[e.RowIndex].DataBoundItem as TStudentCourse);

                if (c.StudentsID < 1 && !c.Selected) { c.Student = student.Student; c.Speciality = student.Speciality; c.Selected = true; }
                else if (c.Selected) { c.Student = null; c.Speciality = null; c.Selected = false; }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var c = (dGStudentsCourse.Rows[e.RowIndex].DataBoundItem as TStudentCourse);

            FormAddElectiveSubjectAdd fm = new FormAddElectiveSubjectAdd();
            fm.ShowDialog();
        }

        private void DGStudentsCourse_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var x = (dGStudentsCourse.Rows[e.RowIndex].DataBoundItem as TStudentCourse);
            if (x == null) return;
            dGStudentsCourse.Rows[e.RowIndex].DefaultCellStyle.BackColor = x.Selected ? Color.LightGreen : Color.White;

        }

    }
}
