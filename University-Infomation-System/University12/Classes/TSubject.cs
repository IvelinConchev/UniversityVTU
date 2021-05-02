using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TSubject
    {
        public TSubject()
        {

        }

        public TSubject(Subject s)
        {
            this.ID = s.ID;
            this.SubjectName = s.SubjectName;
            this.Faculty = new TFaculty(s.Faculty);
            this.Departments =  new TDepartments(s.Department);
            this.CompulsoryDiscipline = s.CompulsoryDiscipline;
            this.FacultativeDiscipline = s.FacultativeDiscipline;
            //this.Faculty = new TFaculty(s.Faculty);
            //this.Departments = new TDepartments(s.Department);

        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Subject subject = new Subject();
                    if (this.ID > 0)
                    {
                        subject = (from su in db.Subjects where su.ID == this.ID select su).FirstOrDefault();
                    }

                    subject.FacultyID = this.FacultyID;
                    subject.DepartmentsID = this.DeparmentsID;
                    subject.SubjectName = this.SubjectName;
                    subject.CompulsoryDiscipline = this.CompulsoryDiscipline;
                    subject.FacultativeDiscipline = this.FacultativeDiscipline;

                    if (this.ID == 0) db.Subjects.InsertOnSubmit(subject);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TSubject> LoadData(out string error)
        {
            List<TSubject> Subjects = new List<TSubject>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Subjects = (from s in db.Subjects select new TSubject(s)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Subjects;
        }
        public int ID { get; set; }

        public string SubjectName { get; set; }

       // public int DepartmentsID { get; set; }

       // public int FacultyID { get; set; }

        public TDepartments Departments { get; set; }

        public int DeparmentsID { get { if (Departments != null) return Departments.ID; return 0; } }

        public string DepartmentsName { get { if (Departments != null) return Departments.Name; else return string.Empty; } }

        public TFaculty Faculty { get; set; }

        public int FacultyID { get { if (Faculty != null) return Faculty.ID; else return 0; } }

        public string FacultyName { get { if (Faculty != null) return Faculty.FacultyName; else return string.Empty; } }

        
        public bool CompulsoryDiscipline { get; set; }

        public bool FacultativeDiscipline { get; set; }



    }
}

