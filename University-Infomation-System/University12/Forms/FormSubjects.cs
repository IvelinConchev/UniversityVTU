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
using University12.Forms.Add;

namespace University12.Forms
{
    public partial class FormSubjects : Form
    {
        List<TSubject> Subjects = new List<TSubject>();
        int facultyID = -1;
        int DeparmentID = -1;


        public FormSubjects()
        {
            InitializeComponent();
        }

        public void LoadSubject()
        {
            string error = string.Empty;
            this.Subjects = TSubject.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsSubjects.DataSource = Subjects;
        }

        public void Filter()
        {
            List<TSubject> Sub = new List<TSubject>();
            if (facultyID > 0)
            {
                Sub = this.Subjects.Where(s => s.FacultyID == facultyID).ToList();
            }
            else
            {
                Sub = this.Subjects;
            }
            if (DeparmentID > 0)
            {
                Sub = Sub.Where(d => d.DeparmentsID == DeparmentID).ToList();
            }

            bsSubjects.DataSource = Sub;
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

            TFaculty faculty = new TFaculty();
            faculty.FacultyName = "всички";
            faculty.ID = -1;

            faculties.Insert(0, faculty);

            cBoxSubjectsFaculty.DisplayMember = "FacultyName";
            cBoxSubjectsFaculty.ValueMember = "ID";
            cBoxSubjectsFaculty.DataSource = faculties;
        }

        public void LoadDepartment()
        {
            List<TDepartments> departments = new List<TDepartments>();
            string error = string.Empty;
            departments = TDepartments.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на Катедра");
                return;
            }

            TDepartments depar = new TDepartments();
            depar.Name = "всички";
            depar.ID = -1;

            departments.Insert(0, depar);

            cBoxSubjectsDeparments.DisplayMember = "Name";
            cBoxSubjectsDeparments.ValueMember = "ID";
            cBoxSubjectsDeparments.DataSource = departments;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.LoadSubject();
        }

        private void FormSubjects_Load(object sender, EventArgs e)
        {
            this.LoadSubject();
            this.LoadFaculty();
            this.LoadDepartment();
        }

        private void CBoxSubjectsFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSubjectsFaculty.SelectedItem != null)
            {
                TFaculty f = cBoxSubjectsFaculty.SelectedItem as TFaculty;
                if (f == null) return;
                this.facultyID = f.ID;
                Filter();

            }
        }

        private void CBoxSubjectsDeparments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSubjectsDeparments.SelectedItem != null)
            {
                TDepartments d = cBoxSubjectsDeparments.SelectedItem as TDepartments;
                if (d == null) return;
                this.DeparmentID = d.ID;
                Filter();
            }
        }

        private void BtnSubjectAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на дисциплини!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddSubjects sub = new FormAddSubjects();
            sub.ShowDialog();
        }

        private void DgSubjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на дисциплини!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (e.RowIndex < 0) return;
            var sub = (dgSubjects.Rows[e.RowIndex].DataBoundItem as TSubject);

            FormAddSubjects fr = new FormAddSubjects();
            fr.subjects = sub;
            fr.ShowDialog();
        }

        private void BtnSubjectSearch_Click(object sender, EventArgs e)
        {
            List<TSubject> subjects = new List<TSubject>();

            string sub = txtBoxSubjectSearch.Text;
            sub = sub.ToLower().Trim();

            if (string.IsNullOrEmpty(sub))
            {
                subjects = Subjects;
            }
            else
            {
                subjects = Subjects.Where(s => s.SubjectName.ToLower().Trim().Contains(sub)
                || s.DeparmentsID.ToString().Contains(sub)
                || s.FacultyID.ToString().Contains(sub)).ToList();
            }
            bsSubjects.DataSource = subjects;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddElectiveSubject formAddElectiveSubject = new FormAddElectiveSubject();
            formAddElectiveSubject.ShowDialog();

        }

        private void DgSubjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var x = dgSubjects.Rows[e.RowIndex].DataBoundItem as TSubject;
            if (x == null) return;
            if (x.CompulsoryDiscipline == false)
            {
                dgSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                dgSubjects.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
