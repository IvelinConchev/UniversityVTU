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
using University12.Forms.Add;
using University12.Forms.List;

namespace University12.Forms
{
    public partial class FormFaculties : Form
    {
        List<TFaculty> Faculties = new List<TFaculty>();
        public FormFaculties()
        {
            InitializeComponent();
        }

        public void LoadFaculty()
        {
            string error = string.Empty;
            this.Faculties = TFaculty.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsFaculties.DataSource = Faculties;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnFacultyhDepartments_Click(object sender, EventArgs e)
        {
            FormDepartments formDepartments = new FormDepartments();
            formDepartments.ShowDialog();
        }

        private void BtnFacultyLecture_Click(object sender, EventArgs e)
        {
            FormLectures formLectures = new FormLectures();
            formLectures.ShowDialog();
        }

        private void FormFaculties_Load(object sender, EventArgs e)
        {
            this.LoadFaculty();
        }

        private void BtnFacultyAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на факултети!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddFaculty fac = new FormAddFaculty();
            fac.ShowDialog();
        }

        private void DgFaculties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var xt = (dgFaculties.Rows[e.RowIndex].DataBoundItem as TFaculty);

            FormAddFaculty fc = new FormAddFaculty();
            fc.faculty = xt;
            fc.ShowDialog();
        }

        private void BtnEducationLevel_Click(object sender, EventArgs e)
        {
            FormFormOfEducation form = new FormFormOfEducation();
            form.ShowDialog();
        }

        private void BtnFormOfEducation_Click(object sender, EventArgs e)
        {
            FormFormOfEducation educa = new FormFormOfEducation();
            educa.ShowDialog();
        }

        private void BtnSpeciality_Click(object sender, EventArgs e)
        {
            FormSpecialities spec = new FormSpecialities();
            spec.ShowDialog();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            FormCoursес coursec = new FormCoursес();
            coursec.ShowDialog();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            FormStudents student = new FormStudents();
            student.ShowDialog();
        }

        private void BtnEvaluation_Click(object sender, EventArgs e)
        {
            FormЕvaluation eval = new FormЕvaluation();
            eval.ShowDialog();
        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            FormExam exam = new FormExam();
            exam.ShowDialog();
        }

        private void BtnSubject_Click(object sender, EventArgs e)
        {
            FormSubjects subj = new FormSubjects();
            subj.ShowDialog();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            FormDepartments departments = new FormDepartments();
            departments.ShowDialog();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormExam exam = new FormExam();
            exam.ShowDialog();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormDepartments department = new FormDepartments();
            department.ShowDialog();
        }

        private void TStripMenuCourse_Click(object sender, EventArgs e)
        {
            FormCoursес coursес = new FormCoursес();
            coursес.ShowDialog();
        }

        private void TStripMenuLecture_Click(object sender, EventArgs e)
        {
            FormLectures lectures = new FormLectures();
            lectures.ShowDialog();
        }

        private void TStripMenuIFaculty_Click(object sender, EventArgs e)
        {
            FormFaculties faculties = new FormFaculties();
            faculties.ShowDialog();
        }

        private void ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FormSubjects subjects = new FormSubjects();
            subjects.ShowDialog();
        }

        private void TStripMenuStudent_Click(object sender, EventArgs e)
        {
            FormStudents students = new FormStudents();
            students.ShowDialog();
        }

        private void TStripMenuSemester_Click(object sender, EventArgs e)
        {
            FormSpecialities sem = new FormSpecialities();
            sem.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormЕvaluation evaluation = new FormЕvaluation();
            evaluation.ShowDialog();
        }

        private void ToolStripComboBox2_Click(object sender, EventArgs e)
        {
            FormDepartments department = new FormDepartments();
            department.ShowDialog();
        }

        private void ФМИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaculties faculty = new FormFaculties();
            faculty.ShowDialog();
        }

        private void ToolStripComboBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void TStripMenuIDepartment_Click(object sender, EventArgs e)
        {
            FormDepartments departments = new FormDepartments();
            departments.ShowDialog();
        }

        private void TStripMenuIFaculty_Click_1(object sender, EventArgs e)
        {
            FormSubjects subjects = new FormSubjects();
            subjects.ShowDialog();
        }

        private void ToolStripMenuSpeciality_Click(object sender, EventArgs e)
        {
            FormSpecialities spec = new FormSpecialities();
            spec.ShowDialog();
        }

        private void ToolStripMenuFormEducation_Click(object sender, EventArgs e)
        {
            FormFormOfEducation educa = new FormFormOfEducation();
            educa.ShowDialog();
        }

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormEducationLev form = new FormEducationLev();
            form.ShowDialog();
        }
    }
}
