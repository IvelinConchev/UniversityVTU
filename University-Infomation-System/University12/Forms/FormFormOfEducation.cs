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

namespace University12.Forms.List
{
    public partial class FormFormOfEducation : Form
    {
        List<TFormOfEducation> FormOfEducations = new List<TFormOfEducation>();
      
        public FormFormOfEducation()
        {
            InitializeComponent();
        }

        public void LoadFormOfEducation()
        {
            string error = string.Empty;
            this.FormOfEducations = TFormOfEducation.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }

            bsFormOfEducation.DataSource = FormOfEducations;

        }
 
        private void FormFormOfEducation_Load(object sender, EventArgs e)
        {
            this.LoadFormOfEducation();
        }

        private void BtnFormOfEducation_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за добавяне във форма на обучение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddFormOfEducations educat = new FormAddFormOfEducations();
            educat.ShowDialog();
        }

        //public void LoadFormOfEducations()
        //{
        //    List<TFormOfEducation> formof = new List<TFormOfEducation>();
        //    string error = string.Empty;
        //    formof = TFormOfEducation.LoadData(out error);

        //    if (!string.IsNullOrEmpty(error))
        //    {
        //        MessageBox.Show("Грешка при зареждане на форма за обучение");
        //        return;
        //    }
            //TFormOfEducation forms = new TFormOfEducation();
            //forms.Name = "всички";
            //forms.ID = -1;

            //formof.Insert(0, forms);

            //cBoxFormOfEducation.DisplayMember = "Name";
            //cBoxFormOfEducation.ValueMember = "ID";
            //cBoxFormOfEducation.DataSource = formof;
        //}

        //private void cBoxFormAddFacultyUniversity_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cBoxFormOfEducation.SelectedItem != null)
        //    {
        //        TFormOfEducation f = cBoxFormOfEducation.SelectedItem as TFormOfEducation;
        //        if (f == null) return;
        //        this.formeduID = f.ID;
        //        Filter();
        //    }
        //}

        private void DwFormOfEducation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var f = (dwFormOfEducation.Rows[e.RowIndex].DataBoundItem as TFormOfEducation);
            if (Program.CurrentUser.IsStudent || Program.CurrentUser.IsLecture)
            {
                MessageBox.Show("Нямате права за редактиране във форма на обучение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormAddFormOfEducations forms = new FormAddFormOfEducations();
            forms.formOfEducation = f;
            forms.ShowDialog();
        }
    }
}
