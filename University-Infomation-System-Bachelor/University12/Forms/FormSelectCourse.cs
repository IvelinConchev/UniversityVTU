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
    public partial class FormSelectCourse : Form
    {
        public TStudentSpeciality StudenSpec { get; set; }
        public TCourse course { get; set; }

        public FormSelectCourse()
        {
            InitializeComponent();
        }

        public FormSelectCourse(TStudentSpeciality st)
        {
            InitializeComponent();
            StudenSpec = st;
        }

        public void OpenSubjects()
        {
            FormAddElectiveSubject form = new FormAddElectiveSubject();
            form.student = StudenSpec;
            form.course = course;
            form.ShowDialog();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            course = new TCourse(1, "Първи");
            MessageBox.Show("За първи курс няма свободно избираеми дисциплини");
            return;
            OpenSubjects();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            course = new TCourse(2, "Втори");
            OpenSubjects();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            course = new TCourse(3, "Трети");
            OpenSubjects();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            course = new TCourse(4, "Четвърти");
            OpenSubjects();
        }
    }
}
