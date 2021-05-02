using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TFaculty
    {
        public TFaculty()
        {

        }

        public TFaculty(Faculty fa)
        {
            this.ID = fa.ID;
            this.FacultyName = fa.FacultyName;
            this.UniversityID = fa.UniversityID;
            // this.SpecialityID = fa.SpecialityID;
            this.DeanName = fa.DeanID != null ? fa.Lecture.FirstName + " " + fa.Lecture.LastName : string.Empty;

        }

        public string Save()
        {
            string error = "";
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext())
                {
                    Faculty faculty = new Faculty();
                    if (this.ID > 0)
                    {
                        faculty = (from fa in db.Faculties where fa.ID == this.ID select fa).FirstOrDefault();

                    }

                    faculty.FacultyName = this.FacultyName;
                    faculty.UniversityID = this.UniversityID;
                    //faculty.SpecialityID = this.SpecialityID;

                    if (this.ID == 0) db.Faculties.InsertOnSubmit(faculty);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TFaculty> LoadData(out string error)
        {
            List<TFaculty> Faculties = new List<TFaculty>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Faculties = (from fa in db.Faculties select new TFaculty(fa)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Faculties;
        }

        public int ID { get; set; }

        public string FacultyName { get; set; }

        public int UniversityID { get; set; }

        public string DeanName { get; set; }

        //public int SpecialityID { get; set; }

    }
}
