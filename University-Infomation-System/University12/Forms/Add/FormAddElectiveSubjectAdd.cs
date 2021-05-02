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
    public partial class FormAddElectiveSubjectAdd : Form
    {
        public TStudentCourse studentcourse { get; set; }
        public FormAddElectiveSubjectAdd()
        {
            InitializeComponent();
        }
        public FormAddElectiveSubjectAdd(TStudentCourse s)
        {
            InitializeComponent();
            studentcourse = s;
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            if (bSStudentCourse.Current == null) return;
            var stu = (bSStudentCourse.Current as TStudentCourse);
            if (cBoxElectiveSubjectStudent.SelectedItem == null) return;
            var x = (cBoxElectiveSubjectStudent.SelectedItem as TStudent);
            studentcourse.ID = x.ID;
            
            
            if (string.IsNullOrEmpty(cBoxElectiveSubjectStudent.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }


            string err = stu.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            if (string.IsNullOrEmpty(cBoxElectiveSubject.Text))
            {
                MessageBox.Show(err);

            }
            MessageBox.Show("Успешно записахте дисциплината");
            this.Close();
            return;
        }

        public void LoadStudent()
        {
            List<TStudent> students = new List<TStudent>();
            string error = string.Empty;
            students = TStudent.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на студент");
                return;
            }
            cBoxElectiveSubjectStudent.DisplayMember = "FullName";
            cBoxElectiveSubjectStudent.ValueMember = "ID";
            cBoxElectiveSubjectStudent.DataSource = students;
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
            cBoxElectiveSubjectCourse.DisplayMember = "NameCourse";
            cBoxElectiveSubjectCourse.ValueMember = "ID";
            cBoxElectiveSubjectCourse.DataSource = courses;
        }

        public void LoadSubjects()
        {
            List<TSubject> subjects = new List<TSubject>();
            string error = string.Empty;
            subjects = TSubject.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на дисциплини");
                return;
            }

            cBoxElectiveSubjectSubject.DisplayMember = "SubjectName";
            cBoxElectiveSubjectSubject.ValueMember = "ID";
            cBoxElectiveSubjectSubject.DataSource = subjects;
        }

        private void FormAddElectiveSubjectAdd_Load(object sender, EventArgs e)
        {
            this.LoadSubjects();
            this.LoadCourse();
            this.LoadStudent();

            if (studentcourse == null) studentcourse = new TStudentCourse();
            bSStudentCourse.DataSource = studentcourse;
        }
    }
}

