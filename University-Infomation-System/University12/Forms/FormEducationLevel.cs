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
    public partial class FormEducationLevel : Form
    {
        List<TFormOfEducationLevel> FormOfEducationslevel = new List<TFormOfEducationLevel>();
        public FormEducationLevel()
        {
            InitializeComponent();
        }

        private void FormEducation_Load(object sender, EventArgs e)
        {
            this.LoadFormOfEducation();
        }

        private void FormOfEducation()
        {
            throw new NotImplementedException();
        }

        public void LoadFormOfEducation()
        {
            string error = string.Empty;
            this.FormOfEducationslevel = TFormOfEducationLevel.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }

           // bsFormEducationLevel.DataSource = FormOfEducationslevel;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEducationAdd_Click(object sender, EventArgs e)
        {
            //FormAddDepartment form = new FormAddDepartment();
            //form.ShowDialog();
            FormEducationLevel formEducationLevel = new FormEducationLevel();
            formEducationLevel.ShowDialog();
        }
    }
}
