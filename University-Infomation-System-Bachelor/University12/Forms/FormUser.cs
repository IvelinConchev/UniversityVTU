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
    public partial class FormUser : Form
    {
        List<TUsers> Users = new List<TUsers>();

        public FormUser()
        {
            InitializeComponent();
        }

        
        public void LoadUser()
        {
            string error = string.Empty;
            this.Users = TUsers.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }

            bsUsers.DataSource = Users;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            FormAddUsers us = new FormAddUsers();
            us.ShowDialog();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.LoadUser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
