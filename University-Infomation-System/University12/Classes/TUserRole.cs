using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TUserRole
    {
        public TUserRole()
        {

        }

        public TUserRole(int RoleID)
        {
            this.RoleID = RoleID;
        }

        public TUserRole(UserRole ur)
        {
            this.ID = ur.ID;
            this.UserID = ur.UserID;
            this.RoleID = ur.RoleID;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    UserRole userRole = new UserRole();
                    if (this.ID > 0)
                    {
                        userRole = (from us in db.UserRoles where us.ID == this.ID select us).FirstOrDefault();
                    }

                    userRole.UserID = this.UserID;
                    userRole.RoleID = this.RoleID;

                    if (this.ID == 0) db.UserRoles.InsertOnSubmit(userRole);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public static List<TUserRole>LoadData(out string error)
        {
            List<TUserRole> UserRoles = new List<TUserRole>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    UserRoles = (from ur in db.UserRoles select new TUserRole(ur)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return UserRoles;
        }
        public int ID { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }
    }
}
