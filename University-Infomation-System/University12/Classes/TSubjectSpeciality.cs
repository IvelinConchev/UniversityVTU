using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TSubjectSpeciality
    {
        public TSubjectSpeciality()
        {

        }
        public TSubjectSpeciality(SubjectSpeciality ss)
        {
           
            this.SpecialityID = ss.SpecialityID;
            this.SubjectID = ss.SubjectID;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    SubjectSpeciality subjectSpeciality = new SubjectSpeciality();
                    if (this.ID > 0)
                    {
                        subjectSpeciality = (from sub in db.SubjectSpecialities where sub.ID == this.ID select sub).FirstOrDefault();
                    }

                    subjectSpeciality.SubjectID = this.SubjectID;
                    subjectSpeciality.SpecialityID = this.SpecialityID;

                    if (this.ID == 0) db.SubjectSpecialities.InsertOnSubmit(subjectSpeciality);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TSubjectSpeciality>LoadData(out string error)
        {
            List<TSubjectSpeciality> SubjectSpecialities = new List<TSubjectSpeciality>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    SubjectSpecialities = (from ss in db.SubjectSpecialities select new TSubjectSpeciality(ss)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return SubjectSpecialities;
        }
        public int ID { get; set; }

        public int SubjectID { get; set; }

        public int SpecialityID { get; set; }
    }
}
