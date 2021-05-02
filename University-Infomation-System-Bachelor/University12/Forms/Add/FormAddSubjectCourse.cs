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
    public partial class FormAddSubjectCourse : Form
    {
        List<TSubjectCourse> SubjectCourses = new List<TSubjectCourse>();
        int courseID = -1;
        int semesterID = -1;
        public TSpeciality speciality = null;
        public FormAddSubjectCourse()
        {
            InitializeComponent();
        }

        public void LoadSubjectCourse()
        {
            if (speciality == null)
            {
                return;
            }
            string error = string.Empty;
            this.SubjectCourses = TSubjectCourse.LoadData(speciality.ID, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от от базата данни");
                return;
            }
            bSSubjectCourse.DataSource = SubjectCourses;
         
        }

        public void Filter ()
        {
            List<TSubjectCourse> SubC = new List<TSubjectCourse>();
            if (courseID > 0)
            {
                SubC = this.SubjectCourses.Where(s => s.CourseID == courseID).ToList();

            }
            else
            {
                SubC = this.SubjectCourses;
            }
            if (semesterID > 0)
            {
                SubC = SubC.Where(e => e.SemesterID == semesterID).ToList();
            }

            bSSubjectCourse.DataSource = SubC;
        }

        public void LoadCourse()
        {
            List<TCourse> Courses = new List<TCourse>();
            string error = string.Empty;
            Courses = TCourse.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на курс");
                return;
            }

            TCourse course = new TCourse();
            course.NameCourse = "Всички";
            course.ID = -1;

            Courses.Insert(0, course);
            cBoxSubjectCourse.DisplayMember = "NameCourse";
            cBoxSubjectCourse.ValueMember = "ID";
            cBoxSubjectCourse.DataSource = Courses;
        }

        public void LoadSemester()
        {
            List<TSemester> semesters = new List<TSemester>();
            string error = string.Empty;
            semesters = TSemester.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на семестър");
                return;
            }

            TSemester semester = new TSemester();
            semester.SummerWinter = "Всички";
            semester.ID = -1;

            semesters.Insert(0, semester);
            cBoxSubjecSemester.DisplayMember = "SummerWinter";
            cBoxSubjecSemester.ValueMember = "ID";
            cBoxSubjecSemester.DataSource = semesters;

        }

        
        private void FormAddSubjectCourse_Load(object sender, EventArgs e)
        {
            this.LoadSubjectCourse();
            this.LoadCourse();
            this.LoadSemester();
        }

        private void CBoxSubjecSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSubjecSemester.SelectedItem != null)
            {
                TSemester s = cBoxSubjecSemester.SelectedItem as TSemester;
                if (s == null) return;
                this.semesterID = s.ID;
                Filter();
            }
        }

        private void CBoxSubjectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSubjectCourse.SelectedItem != null)
            {
                TCourse c = cBoxSubjectCourse.SelectedItem as TCourse;
                if (c == null) return;
                this.courseID = c.ID;
                Filter();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormAddElectiveSubject ele = new FormAddElectiveSubject();
            ele.ShowDialog();
        }
    }
}
