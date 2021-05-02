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
    public partial class FormEducationLev : Form
    {
        List<TEducationLevel> FormOfEducations = new List<TEducationLevel>();
        public FormEducationLev()
        {
            InitializeComponent();
        }

        private void FormEducation_Load(object sender, EventArgs e)
        {
            this.LoadEducationLevel();
        }

        private void FormOfEducation()
        {
        }

        public void LoadEducationLevel()
        {
            string error = string.Empty;
            this.FormOfEducations = TEducationLevel.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }

            bsLevelEducation.DataSource = FormOfEducations;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEducationAdd_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на образователна степен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            FormAddLevelEducation form = new FormAddLevelEducation();
            form.ShowDialog();
            this.LoadEducationLevel();
        }

        private void DgLevelEducation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var c = dgLevelEducation.Rows[e.RowIndex].DataBoundItem as TEducationLevel;
            if (c == null) return;
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за редактиране на образователна степен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormAddLevelEducation form = new FormAddLevelEducation(c);
            form.ShowDialog();
        }
    }
}
