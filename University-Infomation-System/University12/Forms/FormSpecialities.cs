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
    public partial class FormSpecialities : Form
    {
        List<TSpeciality> Specialities = new List<TSpeciality>();

        public FormSpecialities()
        {
            InitializeComponent();
        }

        public void LoadSpeciality()
        {
            string error = string.Empty;
            this.Specialities = TSpeciality.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsSpecialities.DataSource = Specialities;
        }
        private void BtnSpecialitiesStudents_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var st = (dgSpecialities.Rows[e.RowIndex].DataBoundItem as TSpeciality);
            if (e.ColumnIndex == Column1.Index) return;

            FormАddSpecialities sc = new FormАddSpecialities();
            sc.speciality = st;
            sc.ShowDialog();
        }

        private void DgSpecialities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormSpecialities_Load(object sender, EventArgs e)
        {

            this.LoadSpeciality();
        }

        private void BtnFormSpecialityAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на специалности!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormАddSpecialities sp = new FormАddSpecialities();
            sp.ShowDialog();
        }

        public void DgSpecialities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var su = (dgSpecialities.Rows[e.RowIndex].DataBoundItem as TSpeciality);
            if (Column1.Index != e.ColumnIndex) return;

            FormAddSubjectCourse sub = new FormAddSubjectCourse();
            sub.speciality = su;
            sub.ShowDialog();
        }
    }
 
}
