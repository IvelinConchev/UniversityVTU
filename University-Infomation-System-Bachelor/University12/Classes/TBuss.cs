using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TBuss
    {
        public List<TStudent> ListStudents { get; set; }

        public TBuss()
        {
            ListStudents = new List<TStudent>();
        }

        public void AddStudent(string FirstName, string MiddleName, string LastName, string EGN)
        {
            //Add Students
            TStudent obj = new TStudent();
            obj.FirstName = FirstName;
            obj.MiddleName = MiddleName;
            obj.LastName = LastName;
            obj.EGN = EGN;
            ListStudents.Add(obj);
        }

        public void RemoveStudent()
        {
            //Remove Students
            var itemToRemove = ListStudents.LastOrDefault();
            if (itemToRemove != null)
                ListStudents.Remove(itemToRemove);

        }

        public static List<TStudent>LoadStudents(out string error)
        {
            //Load Students
            List<TStudent>Students = new List<TStudent>();
            error = string.Empty;
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {

                    Students = (from st in db.Students select new TStudent(st)).ToList();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return Students;
        }

    }
}

