using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    class TEvaluationResult
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string  SubjectName { get; set; }
        public string NameSpeciality { get; set; }
        public string LecturerName { get; set; }
        public int Eval { get; set; }


        public static List<TEvaluationResult> LoadEvaluation(out string error)
        {
            List<TEvaluationResult> Evaluations = new List<TEvaluationResult>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Evaluations = (
                        from ev in db.Evaluations
                        join stud in db.Students on ev.StudentID equals stud.ID
                        join subj in db.Subjects on ev.SubjectID equals subj.ID
                        join spec in db.Specialities on ev.SpecialityID equals spec.ID
                        join lect in db.Lectures on ev.LectureID equals lect.ID

                        select new TEvaluationResult { StudentId = stud.ID, StudentName = stud.FirstName, NameSpeciality = spec.NameSpeciality, SubjectName=subj.SubjectName, LecturerName = lect.FirstName, Eval=ev.Number}
                        ).ToList();
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
