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
    public partial class FormAddSubjects : Form
    {
        public TSubject subjects { get; set; }
        public FormAddSubjects()
        {
            InitializeComponent();
        }

        public FormAddSubjects(TSubject s)
        {
            InitializeComponent();
            subjects = s;
        }

        private void BtnFormRegistrationSubjectSave_Click(object sender, EventArgs e)
        {
            if (bsSubjects.Current == null) return;
            var sub = (bsSubjects.Current as TSubject);
            //if (cBoxFormAddSubjectDepartment.SelectedItem == null) return;

            //var x = (cBoxFormAddSubjectDepartment.SelectedItem as TDepartments);
            //sub.DeparmentsID = x.ID;

            if (string.IsNullOrEmpty(tBoxFormAddSubjects.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }


            if (bsSubjects.Current == null) return;
            var su = (bsSubjects.Current as TSubject);
            //if (cBoxFormAddSubjectFaculty.SelectedItem == null) return;

            //var f = (cBoxFormAddSubjectFaculty.SelectedItem as TFaculty);
            //su.FacultyID = f.ID;

            if (string.IsNullOrEmpty(tBoxFormAddSubjects.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
                string err = sub.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            
            if (string.IsNullOrEmpty(cBoxComsulsory.Text))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Успешно записахте дисциплината");
            this.Close();
            return;

            
        }

        public void LoadDepartment()
        {
            List<TDepartments> departments = new List<TDepartments>();
            string error = string.Empty;
            departments = TDepartments.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на дисциплини");
                return;
            }
            cBoxFormAddSubjectDepartment.DisplayMember = "Name";
            cBoxFormAddSubjectDepartment.ValueMember = "ID";
            cBoxFormAddSubjectDepartment.DataSource = departments;
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
            cBoxFormAddSubjectFaculty.DisplayMember = "FacultyName";
            cBoxFormAddSubjectFaculty.ValueMember = "ID";
            cBoxFormAddSubjectFaculty.DataSource = faculties;
        }


        private void FormAddSubjects_Load(object sender, EventArgs e)
        {
            this.LoadDepartment();
            this.LoadFaculty();
            


            if (subjects == null) subjects = new TSubject();
            bsSubjects.DataSource = subjects;
        }

        private void CBoxComsulsory_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CBoxFacultative_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
