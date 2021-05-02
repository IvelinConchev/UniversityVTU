using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TSpeciality
    {
        public int ID { get; set; }

        public string NameSpeciality { get; set; } 
        public TFaculty Faculty { get; set; }
        public int FacultyID { get { if (Faculty != null) return Faculty.ID; return 0; } }
        public TSpeciality()
        {

        }
        public TSpeciality(Speciality sp)
        {
            this.ID = sp.ID;
            this.NameSpeciality = sp.NameSpeciality;
            this.Faculty = new TFaculty(sp.Faculty);
        }

        public static string CheckValidSpeciality(string NameSpeciality)

        {
            string error = string.Empty;
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if (string.IsNullOrEmpty(NameSpeciality)) { return "Факултета съществува"; }

                    //var sp = (from sp in db.Faculties where sp.NameSpeciality.Equals(NameSpeciality select sp).FisrtOfDefault();
                    //if (sp == null) return;
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
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {

                    Speciality speciality = new Speciality();
                    if (this.ID > 0)
                    {
                        speciality = (from sp in db.Specialities where sp.ID == this.ID select sp).FirstOrDefault();

                    }

                    speciality.NameSpeciality = this.NameSpeciality;
                    speciality.FacultyID = this.FacultyID;

                    if (this.ID == 0) db.Specialities.InsertOnSubmit(speciality);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;

        }
        public static List<TSpeciality> LoadData(out string error)
        {
            List<TSpeciality> Specialities = new List<TSpeciality>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Specialities = (from sp in db.Specialities select new TSpeciality(sp)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Specialities;
        }
    }
}
