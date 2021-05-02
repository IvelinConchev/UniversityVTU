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
    public partial class FormAddEvaluation : Form
    {
        
        public TEvaluation evaluation { get; set; }
        public FormAddEvaluation()
        {
            InitializeComponent();
        }

        public FormAddEvaluation(TEvaluation e)
        {
            InitializeComponent();
            evaluation = e;
        }
        private void btnFormRegistrationLectureSave_Click(object sender, EventArgs e)
         {
            if (bsEvaluation.Current == null) return;
            var ev = (bsEvaluation.Current as TEvaluation);
             
            //if (BoxFormAddStudent.SelectedItem == null) return;

            //var x = (cBoxFormAddStudent.SelectedItem as TSubject);
            //ev.SubjectID = x.ID;

            if (string.IsNullOrEmpty(tBoxFormAddEvaluation.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            string err = ev.Save();
             
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                
            }
            if (evaluation.Number < 2 || evaluation.Number > 6)
            {
                MessageBox.Show("Моля попълнете коректни данни");
                return;
            }

            MessageBox.Show("Успешно записахте оценките");
            this.Close();
            return;
        }
 
        public void LoadLecture()
        {
           //List<TLecture>
        }
        private void FormAddEvaluation_Load(object sender, EventArgs e)
        {
     
            if (evaluation == null) evaluation = new TEvaluation();
            bsEvaluation.DataSource = evaluation;
        }
    }
}
