using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TSubjectCourse
    {
        public int ID { get; set; }

        //public int SubjectID { get; set; }

        //public int CourseID { get; set; }

        //public int SemesterID { get; set; }
        public int SpecialityID { get; set; }

        public TSubject Subject { get; set; }

        public int SubjectID { get { if (Subject != null) return Subject.ID; return 0; } }

        public string SubjectName { get { if (Subject != null) return Subject.SubjectName; else return string.Empty; } }

        public TCourse Course { get; set; }

        public int CourseID { get { if (Course != null) return Course.ID; return 0; } }

        public string NameCourse { get { if (Course != null) return Course.NameCourse; else return string.Empty; } }

        
        public TSemester Semester { get; set; }

        public int SemesterID { get { if (Semester != null) return Semester.ID; return 0; } }

        public string NameSemester { get { if (Semester != null) return Semester.SummerWinter; else return string.Empty; } }


        public TSubjectCourse()
        {

        }

        public TSubjectCourse(SubjectCourse sc)
        {
            this.ID = sc.ID;
            this.Course = new TCourse(sc.Course);
            this.Subject = new TSubject(sc.Subject);
            this.Semester = new TSemester(sc.Semester);
            this.SpecialityID = sc.SpecialityID;

        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    SubjectCourse subjectCourse = new SubjectCourse();
                    if (this.ID > 0)
                    {
                        subjectCourse = (from sc in db.SubjectCourses where sc.ID == this.ID select sc).FirstOrDefault();
                    }

                    subjectCourse.SubjectID = this.SubjectID;
                    subjectCourse.CourseiD = this.CourseID;
                    subjectCourse.SemesterID = this.SemesterID;
                    subjectCourse.SpecialityID = this.SpecialityID;

                    if (this.ID == 0) db.SubjectCourses.InsertOnSubmit(subjectCourse);
                    db.SubmitChanges();
                }
            }

            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public static List<TSubjectCourse>LoadData(int specID ,out string error)
        {
            List<TSubjectCourse> SubjectCourses = new List<TSubjectCourse>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    //SubjectCourses = (from sc in db.SubjectCourses select new TSubjectCourse(sc)).ToList();
                    SubjectCourses = (from sca in db.SubjectCourses
                                       where sca.SpecialityID == specID
                                      select new TSubjectCourse(sca)).ToList();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return SubjectCourses;
        }
  

    }

}
