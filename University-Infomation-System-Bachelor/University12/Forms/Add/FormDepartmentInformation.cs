using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University12.Classes;

namespace University12.Forms.Add
{
    public partial class FormDepartmentInformation : Form
    {
        public TDepartments departments = null;
 
        public FormDepartmentInformation()
        {
            InitializeComponent();
        }

        private void rtDepInfo_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        bool saved = false;

        private void tStripFile_Click(object sender, EventArgs e)
        {
            saved = true;
            if (CurrentFile == "") saveAsToolStripMenuItem_Click(sender, e);
            else rtDepInfo.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText);
        }

        private void FormDepartmentInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
                if (MessageBox.Show("Не е направен запис", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
        }

        string CurrentFile = "";
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtDepInfo.Text != "")
            {
                if (((DialogResult.OK == MessageBox.Show("Съдържанието ще бъде загубено", "Продължаватели?", MessageBoxButtons.OKCancel))))
                {
                    rtDepInfo.Text = "";
                    CurrentFile = "";
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    CurrentFile = openFileDialog.FileName;
                    if (Path.GetExtension(CurrentFile) == ".txt" || Path.GetExtension(CurrentFile) == ".docx" || Path.GetExtension(CurrentFile) == ".cs") rtDepInfo.LoadFile(CurrentFile,
                        RichTextBoxStreamType.PlainText);
                    else rtDepInfo.LoadFile(CurrentFile);
                    this.Text = Path.GetFileName(CurrentFile) + " - Текстов редактор";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "")
            {
                saveFileDialog.FileName = "неименуван файл";
            }
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt" || Path.GetExtension(saveFileDialog.FileName) == ".docx" || Path.GetExtension(saveFileDialog.FileName) == ".cs")
                {
                    rtDepInfo.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                else rtDepInfo.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                CurrentFile = saveFileDialog.FileName;
                this.Text = Path.GetFileName(CurrentFile) + " - Текстов редактор";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(rtDepInfo.Text))
            //{
            //    MessageBox.Show("Моля, попълнете коректни данни");
            //    return;
            //}
            //OpenFileDialog openp = new OpenFileDialog();

            //openp.Filter = "Изберете снимка(*.txt;*.docx;*.cs;)|*.txt;*.docx;*.cs;";

            //if (openp.ShowDialog() == DialogResult.OK)

            //{
            //    departments.HeadОfDepartmentName.txt = openp.FileName;
            //    rtDepInfo.txt = Image.FromFile(openp.FileName);

            //}
        }

        private void FormDepartmentInformation_Load(object sender, EventArgs e)
        {
            //if (departments == null) departments = new TDepartments();
            //bsDepartments.DataSource = departments.HeadОfDepartmentName;
            //if (!string.IsNullOrEmpty(departments.HeadОfDepartmentName.Tx))
            //{
            //    pBStudentPicture.Image = Image.FromFile(departments.HeadОfDepartmentName.t);
            //    return;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "")
            {
                saveFileDialog.FileName = "неименуван файл";
            }
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt" || Path.GetExtension(saveFileDialog.FileName) == ".docx" || Path.GetExtension(saveFileDialog.FileName) == ".cs")
                {
                    rtDepInfo.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

    }
}
