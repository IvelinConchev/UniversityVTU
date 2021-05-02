using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TRole
    {
        public TRole()
        {

        }
       

        public TRole(Role r)
        {
            this.ID = r.ID;
            this.Description = r.Description;
            this.Delete = r.Delete;

        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Role role = new Role();
                    if (this.ID > 0)
                    {
                        role = (from r in db.Roles where r.ID == this.ID select r).FirstOrDefault();
                    }

                    role.Description = this.Description;
                    role.Delete = this.Delete;

                    if (this.ID == 0) db.Roles.InsertOnSubmit(role);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TRole>LoadData(out string error)
        {
            List<TRole> Roles = new List<TRole>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Roles = (from r in db.Roles select new TRole(r)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Roles;
        }
        public int ID { get; set; }

        public string Description { get; set; }

        public bool Delete { get; set; }
    }
}
