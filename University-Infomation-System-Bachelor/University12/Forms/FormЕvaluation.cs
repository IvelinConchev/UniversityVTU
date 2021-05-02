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
    public partial class FormЕvaluation : Form
    {
        List<TEvaluation> Evaluations = new List<TEvaluation>();
        int specID = -1;
        int courseID = -1;
        public FormЕvaluation()
        {
            InitializeComponent();
        }

        public void LoadEvaluation()
        {
            string error = string.Empty;
            this.Evaluations = TEvaluation.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bsEvaluations.DataSource = Evaluations;
        }

        public void Filter()
        {
            List<TEvaluation> Eval = new List<TEvaluation>();
            if (specID > 0)
            {
                Eval = this.Evaluations.Where(s => s.SpecialityID == specID).ToList();
            }
            else
            {
                Eval = this.Evaluations;
            }
            if (courseID > 0)
            {
                Eval = Eval.Where(e => e.CourseID == courseID).ToList();
            }
  
            bsEvaluations.DataSource = Eval;
 
        }

        public void LoadSpeciality()
        {
            List<TSpeciality> specialities = new List<TSpeciality>();
            string error = string.Empty;
            specialities = TSpeciality.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на специалност");
                return;

            }

            TSpeciality speciality = new TSpeciality();
            speciality.NameSpeciality = "Всички";
            speciality.ID = -1;

            specialities.Insert(0, speciality);
            cBoxEvaluationSpeciality.DisplayMember = "NameSpeciality";
            cBoxEvaluationSpeciality.ValueMember = "ID";
            cBoxEvaluationSpeciality.DataSource = specialities;
        }

        public void LoadCourse()
        {
            List<TCourse> courses = new List<TCourse>();
            string error = string.Empty;
            courses = TCourse.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане на курс");
                return;
            }

            TCourse course = new TCourse();
            course.NameCourse = "Всички";
            course.ID = -1;

            courses.Insert(0, course);
            cBoxEvaluationCourse.DisplayMember = "NameCourse";
            cBoxEvaluationCourse.ValueMember = "ID";
            cBoxEvaluationCourse.DataSource = courses;
        }


        private void DataGridViewEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FormEvaluations_Load(object sender, EventArgs e)
        {
            this.LoadEvaluation();
            this.LoadSpeciality();
            this.LoadCourse();
        }

        private void btnFromEvaluationAdd_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewEvaluation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.CurrentUser.IsStudent)
            {
                MessageBox.Show("Нямате права за добавяне на оценки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if (e.RowIndex < 0) return;
            //var x = (dataGridViewEvaluation.Rows[e.RowIndex].DataBoundItem as TEvaluation);



            //FormAddEvaluation ev = new FormAddEvaluation();
            //ev.evaluation = x;
            //ev.ShowDialog();

            if (e.RowIndex < 0) return;
            var x = (dataGridViewEvaluation.Rows[e.RowIndex].DataBoundItem as TEvaluation);
            //if (x == null) return;

            {
                FormAddEvaluation lc = new FormAddEvaluation();
                //FormAddEvalutionExam lc = new FormAddEvalutionExam();
                //FormAddEvaluationSt_Lec lc = new FormAddEvaluationSt_Lec();
                lc.evaluation = x;
                lc.ShowDialog();
            }
        }

        private void CBoxEvaluationSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxEvaluationSpeciality.SelectedItem != null)
            {
                TSpeciality c = cBoxEvaluationSpeciality.SelectedItem as TSpeciality;
                if (c == null) return;
                this.specID = c.ID;
                Filter();
            }
        }

        private void CBoxEvaluationCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxEvaluationCourse.SelectedItem != null)
            {
                TCourse s = cBoxEvaluationCourse.SelectedItem as TCourse;
                if (s == null) return;
                this.courseID = s.ID;
                Filter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err;
            List<TEvaluationResult> res = TEvaluationResult.LoadEvaluation(out err); 

        }

        private void btnExamAdd_Click(object sender, EventArgs e)
        {
            FormAddEvalutionExam eval = new FormAddEvalutionExam();
            eval.ShowDialog();
        }
    }
}
