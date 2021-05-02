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
    public partial class FormCoursес : Form
    {
        List<TCourse> Courses = new List<TCourse>();
        public FormCoursес()
        {
            InitializeComponent();
        }

        public void LoadCourse()
        {
            string error = string.Empty;
            this.Courses = TCourse.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                    return;
            }

            bsCourse.DataSource = Courses;
        }
        private void CBoxCoursesCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCoursesAdd_Click(object sender, EventArgs e)
        {

            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на курсове!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormCourceAdd co = new FormCourceAdd();
            co.ShowDialog();
        }

        private void FormCoursес_Load(object sender, EventArgs e)
        {
            this.LoadCourse();
        }

        private void dataGridViewCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var x = (dataGridViewCourses.Rows[e.RowIndex].DataBoundItem as TCourse);

            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture) return;
            FormCourceAdd course = new FormCourceAdd();
            course.course = x;
            course.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormAddElectiveSubject ele = new FormAddElectiveSubject();
            ele.ShowDialog();
        }
    }
}
