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

namespace University12.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            FormLoginRegistration formLoginRegistration = new FormLoginRegistration();
            formLoginRegistration.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSighninAdmin_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoginSignin_Click(object sender, EventArgs e)
        {

            string err = TUsers.CheckValidPassword(tBoxLogin.Text, tBoxPassword.Text);
            if (string.IsNullOrEmpty(err))
            {
                this.Visible = false;
                this.Close();

                FormStudentInformation formStudent = new FormStudentInformation();
                formStudent.ShowDialog();

                return;
            }

            //    if (tBoxLogin.Text == "" && tBoxPassword.Text == "")
            //{
            //    MessageBox.Show("Unable to fill Username and Password", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else if (tBoxLogin.Text == "")
            //{
            //    MessageBox.Show("Unable to fill Username", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (tBoxLogin.Text == "")
            //{
            //    MessageBox.Show("Unable to fill Username", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            MessageBox.Show("Грешен потребител или парола");
            //        DialogResult result1 = MessageBox.Show("Грешен потребител или парола?",
            //"Important Question",
            //MessageBoxButtons.YesNo);
            //this.Close();
        }

        private void BtnFormLoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void BtnLoginRegistration_Click(object sender, EventArgs e)
        //{
        //    FormLoginRegistration reg = new FormLoginRegistration();
        //    reg.ShowDialog();
        //}
    }
}
