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
    public partial class FormLoginRegistration : Form
    {
        public TUsers users { get; set; }
        public FormLoginRegistration()
        {
            InitializeComponent();

        }
        public FormLoginRegistration(TUsers u)
        {
            InitializeComponent();
            users = u;

        }

        private void FormLoginRegistration_Load(object sender, EventArgs e)
        {
            cBoxAdmin.CheckedChanged -= new EventHandler(CBoxAdmin_CheckedChanged);
            cBoxLecture.CheckedChanged -= new EventHandler(CBoxLecture_CheckedChanged);
            cBoxStudent.CheckedChanged -= new EventHandler(CBoxStudent_CheckedChanged); 

            if (users == null) users = new TUsers();
            bsUser.DataSource = users; 

            cBoxAdmin.CheckedChanged += new EventHandler(CBoxAdmin_CheckedChanged);
            cBoxLecture.CheckedChanged += new EventHandler(CBoxLecture_CheckedChanged);
            cBoxStudent.CheckedChanged += new EventHandler(CBoxStudent_CheckedChanged);
        }

        private void BtnFormRefistrationSignin_Click(object sender, EventArgs e)
        {
            if (bsUser.Current == null) return;
            var user = (bsUser.Current as TUsers);


            int val = 0;
            if (int.TryParse(txtBoxFormRegistrationPhone.Text, out val))
            {
                user.Phone = val;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationFirstName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationLastName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

            if (string.IsNullOrEmpty(txtBoxFormRegistrationUserName.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            if (string.IsNullOrEmpty(txtBoxFormRegistrationPhone.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }

             

            string err = user.Save();
             

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Записахте се успешно");
            this.Close();
            return;
        }

   

        private void BtnFormRefistrationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            var ch = ((sender) as CheckBox);
            if (users == null || users.Roles == null) return;
            if (ch.Checked)
            {
                var r = users.Roles.Where(i => i.RoleID == 1).FirstOrDefault();
                if (r == null) users.Roles.Add(new TUserRole(1));
            }
            else
            {
                var r = users.Roles.Where(i => i.RoleID == 1).FirstOrDefault();
                if (r != null) users.Roles.Remove(r);
            }


        }


        private void CBoxLecture_CheckedChanged(object sender, EventArgs e)
        {
            var ch = ((sender) as CheckBox);
            if (users == null || users.Roles == null) return;
            if (ch.Checked)
            {
                var r = users.Roles.Where(i => i.RoleID == 2).FirstOrDefault();
                if (r == null) users.Roles.Add(new TUserRole(2));
            }
            else
            {
                var r = users.Roles.Where(i => i.RoleID == 2).FirstOrDefault();
                if (r != null) users.Roles.Remove(r);
            }

        }


        private void CBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            var ch = ((sender) as CheckBox);
            if (users == null || users.Roles == null) return;
            if (ch.Checked)
            {
                var r = users.Roles.Where(i => i.RoleID == 4).FirstOrDefault();
                if (r == null) users.Roles.Add(new TUserRole(4));
            }
            else
            {
                var r = users.Roles.Where(i => i.RoleID == 4).FirstOrDefault();
                if (r != null) users.Roles.Remove(r);
            }

        }
    }
}


