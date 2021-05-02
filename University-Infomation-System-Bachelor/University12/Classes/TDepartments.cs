using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TDepartments
    {
        public TDepartments()
        {

        }
        public TDepartments(Department dep)
        {
            this.Txt = dep.Txt;
            this.ID = dep.ID;
            this.Name = dep.Name;
            this.FacultyID = dep.FacultyID;
            this.HeadОfDepartmentName = dep.HeadОfDepartmentID != null ? dep.Lecture.FirstName + " " + dep.Lecture.LastName : string.Empty;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Department department = new Department();
                    if (this.ID > 0)
                    {
                        department = (from dp in db.Departments where dp.ID == this.ID select dp).FirstOrDefault();
                    }

                    department.Txt = this.Txt;
                    department.Name = this.Name;
                    department.FacultyID = this.FacultyID;

                    if (this.ID == 0) db.Departments.InsertOnSubmit(department);
                    db.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TDepartments>LoadData(out string error)
        {
            List<TDepartments> Departments = new List<TDepartments>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Departments = (from dep in db.Departments select new TDepartments(dep)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Departments;
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public int FacultyID { get; set; }

        public string HeadОfDepartmentName { get; set; }

        public string  Txt { get; set; }
    }
}
