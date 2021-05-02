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

namespace University12
{
    public partial class Form1 : Form
    {
        TBuss buss { get; set; }
        public Form1()
        {
            InitializeComponent();
            buss = new TBuss();
        }

        private void BtnFirstName_Click(object sender, EventArgs e)
        {
            string FirstName = txtBoxFirstName.Text;
            string MiddleName = txtBoxMiddleName.Text;
            string LastName = txtBoxLastName.Text;
            string EGN = txtBoxEGN.Text;

            TStudent student = new TStudent();

            student.FirstName = FirstName;
            student.MiddleName = MiddleName;
            student.LastName = LastName;
            student.EGN = EGN;
            student.Save();



            //buss.AddStudent(Firstname, MiddleName, LastName , EGN );


        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            //static method
            var data = TBuss.LoadStudents(out error);

            MessageBox.Show("Данните са добавени успешно!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<TStudent> Students = new List<TStudent>();
            TStudent obj = new TStudent();
            obj.FirstName = " ";
            obj.MiddleName = " ";
            obj.LastName = " ";
            obj.EGN = " ";
            Students.Add(obj);

            var itemToRemove = (from st in Students
                                where st.FirstName == " "
                                select st).FirstOrDefault();

            var R = Students.Where(st => st.FirstName == " ").FirstOrDefault();
            var R2 = Students.FirstOrDefault(st => st.FirstName == " ");


            if (itemToRemove != null)
                Students.Remove(itemToRemove);
            MessageBox.Show("OK!");
        }

        private void BtnNStudent_Click(object sender, EventArgs e)
        {
            string FirstName = txtBoxFirstName.Text;
            string MiddleName = txtBoxMiddleName.Text;
            string LastName = txtBoxLastName.Text;
            string EGN = txtBoxEGN.Text;

            TStudent obj = new TStudent();
            obj.FirstName = FirstName;
            obj.MiddleName = MiddleName;
            obj.LastName = LastName;
            obj.EGN = EGN;
            buss.ListStudents.Add(obj);

            var Student = buss.ListStudents.FirstOrDefault(st => st.LastName == "Ivanov");
    

            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //List<TSubject> subjects = new List<TSubject>();
            //TSubject sub = new TSubject();
            //sub.SName = "";
            //subjects.Add(sub);

            //var itemToRemove = (from s in subjects
            //                    where s.SName == " "
            //                    select s).LastOrDefault();

            //if (itemToRemove != null)
            //    subjects.Remove(itemToRemove);
            //MessageBox.Show("OK!");

            //string SName = txtBoxFirstName.Text;

            //TSubject su = new TSubject();
            //su.SName = SName;
            //buss.ListStudents.Add(su);

            //var Subject = buss.ListStudents.FirstOrDefault(sb => sb.FirstName == "Pashov");
        }
    }
}


