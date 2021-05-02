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

namespace University12.Forms.Add
{
    public partial class FormAddDepartment : Form
    {
         
        public TDepartments department { get; set; }
        public FormAddDepartment()
        {
            InitializeComponent();
            department = new TDepartments();
        }

        public FormAddDepartment(TDepartments d)
        {
            InitializeComponent();
            department = d;
        }
        private void btnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        { 
            if (cbFaculty.SelectedItem == null) return;

            var x = (cbFaculty.SelectedItem as TFaculty);
            department.FacultyID = x.ID;

            if (string.IsNullOrEmpty(tbDepartament.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            string err = department.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }

            MessageBox.Show("Успешно записахте катедрата");
            this.Close();
            return;
        }

        public void LoadFaculty ()
        {
            List<TFaculty> faculties = new List<TFaculty>();
            string error = string.Empty;
            faculties = TFaculty.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на факултет");
                return;
            }

            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "ID";
            cbFaculty.DataSource = faculties;

        }
        private void FormAddDepartment_Load(object sender, EventArgs e)
        {
            if (department == null) department = new TDepartments();
            bsDepartament.DataSource = department;

            this.LoadFaculty();
        }
    }
}
