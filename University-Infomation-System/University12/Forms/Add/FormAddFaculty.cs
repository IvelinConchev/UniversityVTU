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
    public partial class FormAddFaculty : Form
    {
        public TFaculty faculty { get; set; }
        public FormAddFaculty()
        {
            InitializeComponent();
        }
        public FormAddFaculty(TFaculty f)
        {
            InitializeComponent();
            faculty = f;
        }
        private void BtnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {
            if (bsFaculty.Current == null) return;
            var fac = (bsFaculty.Current as TFaculty);
            if (cBoxFormAddFacultyUniversity.SelectedItem == null) return;

            var x = (cBoxFormAddFacultyUniversity.SelectedItem as TUniversity);
            fac.UniversityID = x.ID;

            if (string.IsNullOrEmpty(tBoxFormAddFaculty.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            string err = fac.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Успешно записахте Факултета");
            this.Close();
            return;
        }

        public void LoadUniversity()
        {
            List<TUniversity> universities = new List<TUniversity>();
            string error = string.Empty;
            universities = TUniversity.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на факултети");
                return;
                
            }
            cBoxFormAddFacultyUniversity.DisplayMember = "Name";
            cBoxFormAddFacultyUniversity.ValueMember = "ID";
            cBoxFormAddFacultyUniversity.DataSource = universities;


        }
        private void TBoxFormAddFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddFaculty_Load(object sender, EventArgs e)
        {
            this.LoadUniversity();
            if (faculty == null) faculty = new TFaculty();
            bsFaculty.DataSource = faculty;
        }

        private void TBoxFormAddFaculty_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TBoxFormAddFaculty1233_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBoxFormAddFacultyUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
