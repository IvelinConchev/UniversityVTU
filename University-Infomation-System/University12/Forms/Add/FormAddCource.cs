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
    public partial class FormCourceAdd : Form
    {
        public TCourse course { get; set; }
        public FormCourceAdd()
        {
            InitializeComponent();
        }

        public FormCourceAdd(TCourse c)
        {
            InitializeComponent();
            course = c;
        }

        private void btnFormRegistrationLectureSave_Click(object sender, EventArgs e)
        {
            if (bsCourse.Current == null) return;
            var co = (bsCourse.Current as TCourse);

            if (string.IsNullOrEmpty(tBoxFormAddCourse.Text))
            {
                MessageBox.Show("Моля, попълнете коректни данни");
                return;
            }
            string err = co.Save();

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }

            MessageBox.Show("Успешно записахте курса");
            this.Close();
            return;
        }

        
        private void FormAddCourse_Load(object sender, EventArgs e)
        {
            if (course == null) course = new TCourse();
            bsCourse.DataSource = course;
        }
    }
}
