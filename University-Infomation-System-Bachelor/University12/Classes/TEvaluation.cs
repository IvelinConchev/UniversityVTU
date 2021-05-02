using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{

    public class TEvaluation
    {
        public int ID { get; set; }

       // public int SubjectID { get; set; }

      //  public int StudentID { get; set; }

      //  public int SpecialityID { get; set; }

      //  public int LectureID { get; set; }

        public int Number { get; set; }
         

        public TStudent Student { get; set; }

        public TSubject Subject { get; set; }

        public TSpeciality Speciality { get; set; }

        public TLecture Lecture { get; set; }

        public TCourse Course { get; set; }

        public int CourseID { get { if (Course != null) return Course.ID; else return 0; } }
        public string CourseName { get { if (Course != null) return Course.NameCourse; else return string.Empty; } }

        public int SubjectID { get { if (Subject != null) return Subject.ID; else return 0;} }

        public string  SubjectName { get { if (Lecture != null) return Subject.SubjectName; else return string.Empty; } }

        public int SpecialityID { get { if (Speciality != null) return Speciality.ID; else return 0; } }

        public string NameSpecilaity { get { if (Speciality != null) return Speciality.NameSpeciality; else return string.Empty; } }

        public int LectureID {  get { if (Lecture != null) return Lecture.ID; else return 0; } }
         

        public string LectureName { get { if (Lecture != null) return string.Format("{0} {1}", Lecture.FirstName, Lecture.LastName); else return string.Empty; } }

        public int StudentID { get { if (Student != null) return Student.ID; else return 0; } }

        public string StudentName { get { if (Student != null) return string.Format("{0} {1}", Student.FirstName, Student.LastName); else return string.Empty; } }



        public TEvaluation()
        {

        }

        public TEvaluation(Evaluation ev)
        {
            this.ID = ev.ID;
           // this.LectureID = ev.LectureID;
            this.Number = ev.Number;
            this.Student = new TStudent(ev.Student);
            this.Subject = new TSubject(ev.Subject);
            this.Speciality = new TSpeciality(ev.Speciality);
            this.Lecture = new TLecture(ev.Lecture);
            this.Course = new TCourse(ev.Course);
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext())
                {
                    Evaluation evaluation = new Evaluation();
                    if (this.ID > 0)
                    {
                        evaluation = (from ev in db.Evaluations where ev.ID == this.ID select ev).FirstOrDefault();
                    }


                    evaluation.SubjectID = this.SubjectID;
                    evaluation.StudentID = this.StudentID;
                    evaluation.SpecialityID = this.SpecialityID;
                    evaluation.LectureID = this.LectureID;
                    evaluation.Number = this.Number;
                    evaluation.CourseID = this.CourseID;

                    if (this.ID == 0) db.Evaluations.InsertOnSubmit(evaluation);
                    db.SubmitChanges();
                }
            }

            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TEvaluation> LoadData(out string error)
        {
            List<TEvaluation> Evaluations = new List<TEvaluation>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Evaluations = (from ev in db.Evaluations select new TEvaluation(ev)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Evaluations;
        }

       
    }
}

/*
 
     SELECT 
  stud.ID AS StudentID,
  stud.FirstName as StudentName,
  subj.SubjectName as SubjectName,
  spec.NameSpeciality as NameSpeciality,
  lect.FirstName as LecturerName,  
  e.Number AS Eval   
  
  FROM Evaluation e
  INNER JOIN Students stud ON stud.ID = e.StudentID
  INNER JOIN Subjects subj ON subj.ID = e.SubjectID
  INNER JOIN Speciality spec ON spec.ID = e.SpecialityID
  INNER JOIN Lectures lect ON lect.ID = e.LectureID
  */
