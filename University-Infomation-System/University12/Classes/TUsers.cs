using System;
using System.Collections.Generic;
using System.Linq;
using University12.DB;

namespace University12.Classes
{
    public class TUsers
    {
        public TUsers()
        {
            this.Roles = new List<TUserRole>();
        }

        public bool IsAdmin { get; set; }
        public bool IsLecture { get; set; }
        public bool IsStudent { get; set; }

        public TUsers(User us)
        {
            this.Roles = (from u in us.UserRoles select new TUserRole(u)).ToList();
            this.IsAdmin = this.Roles.Where(i => i.RoleID == 1).Count() > 0;
            this.IsLecture = this.Roles.Where(i => i.RoleID == 2).Count() > 0;
            this.IsStudent = this.Roles.Where(i => i.RoleID == 4).Count() > 0;

            this.ID = us.ID;
            this.FirstName = us.FirstName;
            this.LastName = us.LastName;
            this.Phone = us.Phone;
            this.Email = us.Email;
            this.Username = us.Username;
            this.Password = us.Password;
        }

        public static string CheckValidPassword(string username, string password)
        {
            string error = string.Empty;
            TUsers user = null;
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if (string.IsNullOrEmpty(username)) { return "Моля въведете правилно потребителско име"; }
                    if (string.IsNullOrEmpty(password)) { return "Моля въведете правилна парола"; }

                    var use = (from us in db.Users where us.Username.Equals(username) && us.Password.Equals(password) select us).FirstOrDefault();
                    if (use == null) return " Невалидно потребителско име";

                    user = new TUsers(use);
                }

                Program.CurrentUser = user;
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
                    User use = new User();
                    if (this.ID > 0)
                        use = (from us in db.Users where us.ID == this.ID select us).FirstOrDefault();

                    use.FirstName = this.FirstName;
                    use.LastName = this.LastName;
                    use.Phone = this.Phone;
                    use.Email = this.Email ?? string.Empty;
                    use.Username = this.Username;
                    use.Password = this.Password;

                    if (this.ID == 0) db.Users.InsertOnSubmit(use);

                    if (this.ID > 0)
                    {
                        var dbRoles = db.UserRoles.Where(i => i.UserID == this.ID).ToList();
                        db.UserRoles.DeleteAllOnSubmit(dbRoles);
                    }

                    db.SubmitChanges();
                    this.ID = use.ID;

                    foreach (var r in this.Roles)
                    {
                        var role = new UserRole();
                        role.UserID = this.ID;
                        role.RoleID = r.RoleID;
                        db.UserRoles.InsertOnSubmit(role);
                    }
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public TUsers LoadUser(int ID)
        {
            string error = "";
            var user = new TUsers();
            //TUsers user = new TUsers();
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if (this.ID > 0)
                    {
                        user = (from us in db.Users where us.ID == this.ID select new TUsers(us)).FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return user;
        }
        public static List<TUsers> LoadData(out string error)
        {
            List<TUsers> Users = new List<TUsers>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Users = (from us in db.Users select new TUsers(us)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Users;
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<TUserRole> Roles { get; set; }
    }
}
