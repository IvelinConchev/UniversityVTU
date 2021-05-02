using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{

    public class TSemester
    {
        public int ID { get; set; }

        public string SummerWinter { get; set; }

        public TSemester()
        {

        }

        public TSemester(Semester ts)
        {
            this.ID = ts.ID;
            this.SummerWinter = ts.SummerWinter;
        }

        //public string Save()
        //{
        //    string error = "";

        //    try
        //    {
        //        using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
        //        {
        //            Semester sem = new Semester();
        //            if (this.ID > 0)
        //            {
        //                sem = (from sm in db.Semesters where sm.ID == this.ID select sm).FirstOrDefault();
        //            }

        //            sem.SummerWinter = this.SummerWinter;

        //            if (this.ID == 0) db.Semesters.InsertOnSubmit(sem);
        //            db.SubmitChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        error = ex.Message;
        //    }
        //    return error;
        //}
        public static List<TSemester> LoadData(out string error)
        {
            List<TSemester> Semester = new List<TSemester>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Semester = (from sr in db.Semesters select new TSemester(sr)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Semester;
        }
    }
 
}
