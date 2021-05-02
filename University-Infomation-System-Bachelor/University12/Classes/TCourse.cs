using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TCourse
    {
        public TCourse()
        {

        }
        public TCourse(int id, string str)
        {
            this.ID = id;
            this.NameCourse = str;

        }

        public TCourse(Course co)
        {
            this.ID = co.ID;
            this.NameCourse = co.NameCourse;
        }

        public string Save()
        {
            //List<TCourse>Courses = new List<TCourse>();
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Course course = new Course();
                    if (this.ID > 0)
                    {
                        course = (from co in db.Courses where co.ID == this.ID select co).FirstOrDefault();
                    }

                     course.NameCourse = this.NameCourse;

                    if (this.ID == 0) db.Courses.InsertOnSubmit(course);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;

        }

        public static List<TCourse>LoadData(out string error)
        {
            List<TCourse> Courses = new List<TCourse>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Courses = (from co in db.Courses select new TCourse(co)).ToList();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Courses;
        }
        public int ID { get; set; }

        public string NameCourse { get; set; }
    }
}
