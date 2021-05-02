using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TDepartmentLectrure
    {
        public TDepartmentLectrure()
        {

        }

        public TDepartmentLectrure(DepartmentLecture dl)
        {
            this.ID = dl.ID;
            this.LectureID = dl.LectureID;
            this.DepartmentID = dl.DepartmentID;
            this.StartDate = dl.StartDate;
            this.FinishDate = dl.FinishDate;
            this.SubjectID = dl.SubjectID;


        }

        public string Save()
        {
            string error = "";
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext())
                {
                    DepartmentLecture departmentLecture = new DepartmentLecture();
                    if (this.ID > 0)
                    {
                        departmentLecture = (from dl in db.DepartmentLectures where dl.ID == this.ID select dl).FirstOrDefault();
                    }
                    departmentLecture.LectureID = this.LectureID;
                    departmentLecture.DepartmentID = this.DepartmentID;
                    departmentLecture.StartDate = this.StartDate;
                    departmentLecture.FinishDate = this.FinishDate;
                    departmentLecture.SubjectID = this.SubjectID;

                    if (this.ID == 0) db.DepartmentLectures.InsertOnSubmit(departmentLecture);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TDepartmentLectrure>LoadData(out string error)
        {
            List<TDepartmentLectrure> Dlecture = new List<TDepartmentLectrure>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Dlecture = (from dl in db.DepartmentLectures select new TDepartmentLectrure(dl)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Dlecture;
        }

        public int ID { get; set; }

        public int LectureID { get; set; }

        public int DepartmentID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public int SubjectID { get; set; }
    }
}
