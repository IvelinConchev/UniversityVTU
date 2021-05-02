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
    public partial class FormАddRole : Form
    {
        List<TUsers> users = new List<TUsers>();
        public FormАddRole()
        {
            InitializeComponent();
        }

        public void LoadUser()
        {
            string error = string.Empty;
            this.users = TUsers.LoadData(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Грешка при зареждане от базата данни");
                return;
            }
            bSUser.DataSource = users;
        }
        private void BtnExamAdd_Click(object sender, EventArgs e)
        {
            FormLoginRegistration form = new FormLoginRegistration();
            form.ShowDialog();
        }

        private void FormАddRole_Load(object sender, EventArgs e)
        {
            this.LoadUser();
        }

        private void DataGridViewExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var x = (dataGridViewExam.Rows[e.RowIndex].DataBoundItem as TUsers);

            FormLoginRegistration reg = new FormLoginRegistration();
            reg.users = x;
            reg.ShowDialog();

        }
    }
}
