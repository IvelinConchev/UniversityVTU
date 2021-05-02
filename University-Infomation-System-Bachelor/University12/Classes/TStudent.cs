using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TStudent
    {
        public TStudent()
        {

        }
        public TStudent(Student st)
        {
            this.ID = st.ID;
            this.FirstName = st.FirstName;
            this.MiddleName = st.MiddleName;
            this.LastName = st.LastName;
            this.EGN = st.EGN;
            this.Phone = st.Phone;
            this.Email = st.Email;
            this.City = st.City;  
            this.GraduateSecondarySchool = st.GraduateSecondarySchool;
            this.DateOfEnrollmentInFirstCourse = st.DateOfEnrollmentInFirstCourse;
            this.Male = st.Male;
            this.Address = st.Address;
            this.Faculty = new TFaculty(st.Faculty);
            
            



            if (!string.IsNullOrEmpty(Image))
            {
                this.Image = st.Image.Trim();
            }
        }

        public static string CheckValidStudent(string Firstname, string MiddleName, string LastName, string EGN)

        {
            string error = string.Empty;
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if (string.IsNullOrEmpty(Firstname)) { return "Името съществува"; } //името съществува или е грешно
                    if (string.IsNullOrEmpty(MiddleName)) { return "Презимето съществува"; } //Презимето съществува или е грешно
                    if (string.IsNullOrEmpty(LastName)) { return "Фамилията съществува"; } //Фамилията съществува или е грешна
                    if (string.IsNullOrEmpty(EGN)) { return "EGN Съществува"; } // EGN същствува или е грешно

                    var use = (from us in db.Students where us.EGN.Equals(EGN) select us).FirstOrDefault();
                    if (use == null) return "Такъв потребител съществува моля въведете отново";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public string Save()
        {
            string err = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Student stu = new Student();
                    if (this.ID > 0)
                    {
                        stu = (from st in db.Students where st.ID == this.ID select st).FirstOrDefault();

                        //if (s.EGN != this.EGN) { err = ""; return err; }
                    }

                    stu.FirstName = this.FirstName;
                    stu.MiddleName = this.MiddleName;
                    stu.LastName = this.LastName;
                    stu.EGN = this.EGN;
                    stu.Phone = this.Phone;
                    stu.Email = this.Email;
                    stu.City = this.City; 
                    stu.GraduateSecondarySchool = this.GraduateSecondarySchool;
                    stu.DateOfEnrollmentInFirstCourse = this.DateOfEnrollmentInFirstCourse;
                    stu.Male = this.Male;
                    stu.Address = this.Address;
                    stu.Image = this.Image;
                    stu.FacultyID = this.FacultyID;


                    if (this.ID == 0) db.Students.InsertOnSubmit(stu);
                    db.SubmitChanges();
                    this.ID = stu.ID;

                    //TStudentSpeciality.Save(db, this);
                }
            }

            catch (Exception ex)
            {
                err = ex.Message;
            }
            return err;
        }

        public static List<TStudent> LoadData(out string error)
        {
            List<TStudent> Students = new List<TStudent>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext dc = new SQLDatabaseDataContext(Program.SqlConnection))
                {
                    Students = (from st in dc.Students select new TStudent(st)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return Students;
        }
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public int Phone { get; set; }

        public string Phone1 { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public int FacultyNumber { get; set; }

       //public string Faculty { get; set; }

        public string Speciality {get; set; }
             
        public string GraduateSecondarySchool { get; set; }

        public DateTime DateOfEnrollmentInFirstCourse { get; set; }

        public int Male { get; set; }

        public string Address { get; set; }
       
        public string Image { get; set; }

        public string FullName { get { return this.FirstName + " " + this.LastName; } }

        public TFaculty Faculty { get; set; }
        public int FacultyID { get { if (Faculty != null) return Faculty.ID; else return 0; } }
        public string FacultyName { get { if (Faculty != null) return Faculty.FacultyName; else return string.Empty; } }


    }
}
