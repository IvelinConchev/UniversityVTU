using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University12.DB;
using University12.Forms.Add;

namespace University12.Forms
{
    public partial class FormStudentInformation : Form
    {
        public FormStudentInformation()
        {
            InitializeComponent();
        }

        public void BtnStudentInformationSystemFaculty_Click(object sender, EventArgs e)
        {
            FormFaculties faculty = new FormFaculties();
            faculty.ShowDialog();
            
         
        }

        private void BtnStudentInformationSystemStudent_Click(object sender, EventArgs e)
        {
            FormStudents formStudents = new FormStudents();
            formStudents.ShowDialog();
          
        }

        private void BtnStudentInformationSystemLecture_Click(object sender, EventArgs e)
        {
            FormLectures lecture = new FormLectures();
            lecture.ShowDialog();
           
        }

        private void BtnStudentInformationSystemSpeciality_Click(object sender, EventArgs e)
        {
            FormSpecialities speciality = new FormSpecialities();
            speciality.ShowDialog();


        }

        private void BtnStudentInformationSystemSubject_Click(object sender, EventArgs e)
        {
            FormSubjects subject = new FormSubjects();
            subject.ShowDialog();
            
        }

        private void BtnStudentInformationSystemEvaluation_Click(object sender, EventArgs e)
        {
            FormЕvaluation evaluation = new FormЕvaluation();
            evaluation.ShowDialog();
           
        }

        private void BtnStudentInformationSystemExam_Click(object sender, EventArgs e)
        {
            FormExam formExam = new FormExam();
            formExam.ShowDialog();


        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на оператори!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormАddRole form = new FormАddRole();
            form.ShowDialog();
        }
    }
}
