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
    public partial class FormAddEvaluationSt_Lec : Form
    {
        public TEvaluation evaluation { get; set; }
        public FormAddEvaluationSt_Lec()
        {
            InitializeComponent();
        }
        public FormAddEvaluationSt_Lec(TEvaluation e)
        {
            InitializeComponent();
            evaluation = e;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bsEvaluation.Current == null) return;
            var evaluation = (bsEvaluation.Current as TEvaluation);

            if (string.IsNullOrEmpty(cbFirstName.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cbLecMiddleName.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cbLecLastName.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cbSpeciality.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cbCourse.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(cbSubject.Text))
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }
            if (evaluation.Number < 2 || evaluation.Number > 6)
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }

            string err = evaluation.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }
            MessageBox.Show("Записахте успешно оценката");
            this.Close();
            return;
        }

        public void LoadSTudentFirstName()
        {
            List<TStudent> students = new List<TStudent>();
            string error = string.Empty;
            students = TStudent.LoadData(out error);
        

        if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на Име");
                return;
            }
            cbLecFirstName.DisplayMember = "FirstName";
            cbLecFirstName.ValueMember = "ID";
            cbLecFirstName.DataSource = students;
         }
        private void FormAddEvaluationSt_Lec_Load(object sender, EventArgs e)
        {
            if (evaluation == null) evaluation = new TEvaluation();
            bsEvaluation.DataSource = evaluation;

            this.LoadSTudentFirstName();
        }
    }
}
