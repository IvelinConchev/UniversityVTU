using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TUniversity
    {
        public TUniversity()
        {

        }

        public TUniversity(University un)
        {
            this.ID = un.ID;
            this.City = un.City;
            this.Name = un.Name;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    University university = new University();
                    if (this.ID > 0)
                    {
                        university = (from un in db.Universities where un.ID == this.ID select un).FirstOrDefault();
                    }

                    university.City = this.City;
                    university.Name = this.Name;

                    if (this.ID == 0) db.Universities.InsertOnSubmit(university);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TUniversity>LoadData(out string error)
        {
            List<TUniversity> Universities = new List<TUniversity>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Universities = (from un in db.Universities select new TUniversity(un)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Universities;
        }
        public int ID { get; set; }

        public string City { get; set; }

        public string Name { get; set; }
    }
}
