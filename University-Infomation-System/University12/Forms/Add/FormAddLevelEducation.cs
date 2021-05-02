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
    public partial class FormAddLevelEducation : Form
    {
        public TEducationLevel level { get; set; }
        public FormAddLevelEducation()
        {
            InitializeComponent();
        }
        public FormAddLevelEducation(TEducationLevel c)
        {
            InitializeComponent();
            level = c;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string sErr = level.Save();
            if (!string.IsNullOrEmpty(sErr)) { MessageBox.Show(sErr); }
            else MessageBox.Show("Данните са записани успешно!"); 
        }

        private void FormAddLevelEducation_Load(object sender, EventArgs e)
        {
            if (level == null) level = new TEducationLevel();
            bsLevelEducation.DataSource = level;
        }
    }
}
