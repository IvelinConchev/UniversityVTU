using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University12.Forms
{
    
    public partial class FormExam : Form
    {
        public FormExam()
        {
            InitializeComponent();
        }

        private void BtnExamEvaluation_Click(object sender, EventArgs e)
        {
            FormЕvaluation formЕvaluation = new FormЕvaluation();
            formЕvaluation.ShowDialog();
        }

        private void DataGridViewExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExamAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
