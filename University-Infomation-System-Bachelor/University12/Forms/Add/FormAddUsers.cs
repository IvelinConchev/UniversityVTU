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
    public partial class FormAddUsers : Form
    {
        public TUsers users { get; set; }
        public FormAddUsers()
        {
            InitializeComponent(); 
        }

        public FormAddUsers(TUsers u)
        {
            InitializeComponent();
            users = u;
        }

        private void btnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {
            if (bsUsers.Current == null) return;
            var us = (bsUsers.Current as TUsers);

            if (string.IsNullOrEmpty(tBoxFormAddUsers.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            string err = us.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Успешно записахте потребителя");
            this.Close();
            return;
                
        }

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            if (users == null) users = new TUsers();
            bsUsers.DataSource = users;
        }

        private void TBoxFormAddUsers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
