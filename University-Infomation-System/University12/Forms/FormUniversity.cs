using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University12.Forms
{
    public partial class FormUniversity : Form
    {
        public FormUniversity()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://veliko-tarnovo.net");
        }

        private void BtnUniversityFMI_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void BtnUniversityCarevec_Click(object sender, EventArgs e)
        {

            Process.Start("https://museumvt.com/bg/");

        }

        private void BtnUniversityVTU_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.uni-vt.bg/bul/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.uni-vt.bg/bul//");
        }
    }
}
