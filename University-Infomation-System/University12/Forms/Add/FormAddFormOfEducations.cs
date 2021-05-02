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
    public partial class FormAddFormOfEducations : Form
    {
        public TFormOfEducation formOfEducation { get; set; }
        public FormAddFormOfEducations()
        {
            InitializeComponent();
        }

        public FormAddFormOfEducations(TFormOfEducation f)
        {
            InitializeComponent();
            formOfEducation = f;
        }


        private void btnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {
            if (bsFormOfEducation.Current == null) return;
            var forms = (bsFormOfEducation.Current as TFormOfEducation);

            if (string.IsNullOrEmpty(tBoxFormAddEducations.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            string err = forms.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }

            MessageBox.Show("Успешно записахте формата за обучение");
            this.Close();
            return;
        }

        private void FormAddFormOfEducations_Load(object sender, EventArgs e)
        {
            if (formOfEducation == null) formOfEducation = new TFormOfEducation();
            bsFormOfEducation.DataSource = formOfEducation;
        }
    }
}
