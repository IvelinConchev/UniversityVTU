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
    public partial class FormАddSpecialities : Form
    {
        public TSpeciality speciality { get; set; }

        public FormАddSpecialities()
        {
            InitializeComponent();
        }

        public FormАddSpecialities(TSpeciality s)
        {
            InitializeComponent();
            speciality = s;
        }
        private void BtnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {
            if (bsSpeciality.Current == null) return;
            var sp = (bsSpeciality.Current as TSpeciality);
            if (cBoxFaculty.SelectedItem == null) return;

            var x = (cBoxFaculty.SelectedItem as TFaculty);
            speciality.Faculty = x;

            if (string.IsNullOrEmpty(tBoxFormAddSpeciality.Text))
            {

                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            string err = sp.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Успешно записахте специалността");
            this.Close();
            return;
        }

        public void LoadFaculty()
        {
            List<TFaculty> faculties = new List<TFaculty>();
            string error = string.Empty;
            faculties = TFaculty.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на факултет");
                return;
            }

            cBoxFaculty.DisplayMember = "FacultyName";
            cBoxFaculty.ValueMember = "ID";
            cBoxFaculty.DataSource = faculties;
        }

        private void FormАddSpecialities_Load(object sender, EventArgs e)
        {
            this.LoadFaculty();
            if (speciality == null) speciality = new TSpeciality();
            bsSpeciality.DataSource = speciality;
        }
    }
}
