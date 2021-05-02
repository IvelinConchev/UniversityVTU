using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TSpecialityFaculty
    {
        public TSpecialityFaculty()
        {

        }

        public TSpecialityFaculty(SpecialityFaculty sf)
        {
            this.ID = sf.ID;
            this.SpecialityID = sf.SpecialityID;
            this.FacultyID = sf.FacultyID;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    SpecialityFaculty specialityFaculty = new SpecialityFaculty();
                    if (this.ID > 0)
                    {
                        specialityFaculty = (from sp in db.SpecialityFaculties where sp.ID == this.ID select sp).FirstOrDefault();
                    }

                    specialityFaculty.SpecialityID = this.SpecialityID;
                    specialityFaculty.FacultyID = this.FacultyID;

                    if (this.ID == 0) db.SpecialityFaculties.InsertOnSubmit(specialityFaculty);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TSpecialityFaculty>LoadData(out string error)
        {
            List<TSpecialityFaculty> SpecialityFaculties = new List<TSpecialityFaculty>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    SpecialityFaculties = (from sf in db.SpecialityFaculties select new TSpecialityFaculty(sf)).ToList();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return SpecialityFaculties;
        }
        public int ID { get; set; }

        public int SpecialityID { get; set; }

        public int FacultyID { get; set; }
    }
}
