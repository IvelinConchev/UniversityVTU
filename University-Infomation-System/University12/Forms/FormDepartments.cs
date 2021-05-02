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
    public partial class FormDepartments : Form
    {
        List<TDepartments> Departments = new List<TDepartments>();

        public FormDepartments()
        {
            InitializeComponent();
        }
        public void LoadDepartment()
        {
            string error = string.Empty;
            this.Departments = TDepartments.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsDepartments.DataSource = Departments;
        }

        private void BtnDepartmentsLecture_Click(object sender, EventArgs e)
        {
            FormLectures formLectures = new FormLectures();
            formLectures.ShowDialog();
        }

        private void DataGridViewFormDepartments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var d = (dgDepartments.Rows[e.RowIndex].DataBoundItem as TDepartments);

            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture) return;
            FormAddDepartment dep = new FormAddDepartment();
            dep.department = d;
            dep.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне на катедри!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddDepartment dp = new FormAddDepartment();
            dp.ShowDialog();
        }

        private void FormDepartments_Load(object sender, EventArgs e)
        {
            this.LoadDepartment();
        }

        private void dataGridViewFormDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var sut = (dgDepartments.Rows[e.RowIndex].DataBoundItem as TDepartments);
            if (Column1.Index != e.ColumnIndex) return;

            FormDepartmentInformation dep = new FormDepartmentInformation();
            dep.departments = sut;
            dep.ShowDialog();
        }
    }
}
