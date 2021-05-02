using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TStudentCourse
    {
        public int ID { get; set; }

        public TStudent Student { get; set; }

        public int StudentsID { get { if (Student != null) return Student.ID; return 0; } }

        public string StudentName { get { if (Student != null) return string.Format("{0} {1}", Student.FirstName, Student.LastName); else return string.Empty; } }

        public TCourse Course { get; set; }

        public int CourseID { get { if (Course != null) return Course.ID; return 0; } }

        public string NameCourse { get { if (Course != null) return Course.NameCourse; else return string.Empty; } }

        public TSubject Subject { get; set; }

        public int SubjectsID { get { if (Subject != null) return Subject.ID; return 0; } }

        public string SubjectName { get { if (Subject != null) return Subject.SubjectName; else return string.Empty; } }

        public TSpeciality Speciality { get; set; }

        public int SpecialityID { get { if (Speciality != null) return Speciality.ID; return 0; } }

        public string NameSpeciality { get { if (Speciality != null) return Speciality.NameSpeciality; else return string.Empty; } }

        public bool Selected { get; set; }


        public TStudentCourse()
        {

        }

        public TStudentCourse(TSubject s, TCourse stc)
        {
            this.Subject = s;
            this.Course = stc;
            this.Selected = false;
        }

        public TStudentCourse(StudentCourse sc)
        {
            this.Speciality = new TSpeciality(sc.Speciality);
            this.ID = sc.ID;
            this.Student = new TStudent(sc.Student);
            this.Course = new TCourse(sc.Course);
            this.Subject = new TSubject(sc.Subject);
            this.Selected = true;


        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if ((this.Student == null || this.Speciality == null) && this.ID > 0)
                    {
                        var cc = (from sc in db.StudentCourses where sc.ID == this.ID select sc).FirstOrDefault();
                        db.StudentCourses.DeleteOnSubmit(cc);
                        db.SubmitChanges();
                        return string.Empty;
                    }
                    if ((this.Student == null || this.Speciality == null)) return string.Empty;

                    StudentCourse studentCourse = new StudentCourse();
                    if (this.ID > 0 && this.Selected == true) return error;
                    else if (this.ID > 0 && this.Selected == false)
                    {
                        studentCourse = (from sc in db.StudentCourses where sc.ID == this.ID select sc).FirstOrDefault();
                        db.StudentCourses.DeleteOnSubmit(studentCourse);
                    }
                    else if (this.ID == 0 && this.Selected == true)
                    {
                        db.StudentCourses.InsertOnSubmit(studentCourse);
                        studentCourse.SpecialityID = this.SpecialityID;
                        studentCourse.StudentsID = this.StudentsID;
                        studentCourse.CourseID = this.CourseID;
                        studentCourse.SubjectsID = this.SubjectsID;
                    }



                    if (this.ID == 0) db.StudentCourses.InsertOnSubmit(studentCourse);
                    db.SubmitChanges();
                }
            }

            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public static List<TStudentCourse> LoadData(int StudentID, TCourse course, out string error)
        {
            List<TStudentCourse> StudentCourses = new List<TStudentCourse>();
            List<TSubject> Subjects = new List<TSubject>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    StudentCourses = (from sc in db.StudentCourses where sc.StudentsID == StudentID select new TStudentCourse(sc)).ToList();
                    Subjects = (from s in db.Subjects where s.CompulsoryDiscipline == false select new TSubject(s)).ToList();

                    var ls = Subjects.Where(i => StudentCourses.Where(p => p.SubjectsID == i.ID).Count() == 0).ToList();

                    var subjCourse = db.SubjectCourses.Where(i => i.CourseiD == course.ID).ToList();
                    ls = ls.Where(i => subjCourse.Select(p => p.SubjectID).Contains(i.ID)).ToList();

                    var specialities = db.SubjectSpecialities.Where(i => ls.Select(k => k.ID).Contains(i.SubjectID)).ToList();
                    var studSpecs = db.StudentSpecialities.Where(i => i.CourseID == course.ID).ToList();

                    foreach (var l in ls)
                    {
                        var s = new TStudentCourse(l, course);
                        StudentCourses.Add(s);

                    }
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return StudentCourses;
        }
    }

}
