using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TStudentSpeciality
    {
        public int ID { get; set; }
        public DateTime StartYear { get; set; }

        public DateTime FinishYear { get; set; }
        public TCourse Course { get; set; }
        public int Credits { get; set; }
        

        public int CourseID { get { if (Course != null) return Course.ID; else return 0; } }
        public string CourseName { get { if (Course != null) return Course.NameCourse; else return string.Empty; } }
        
        public TFormOfEducation FormOfEducation { get; set; }
        public int FormOfEducationID { get { if (FormOfEducation != null) return FormOfEducation.ID; return 0; } }
        public string FormOfEducationsName { get { if (FormOfEducation != null) return FormOfEducation.Name; else return string.Empty; } }

        public int FacultyNumber { get; set; }

        public TStudent Student { get; set; }
        public int StudentID { get { if (this.Student == null) return 0; else return this.Student.ID; } }
        public string StudentName { get { if (this.Student == null) return string.Empty; else return string.Format("{0} {1} {2}", this.Student.FirstName,this.Student.MiddleName, this.Student.LastName); } }
        public string StudentEGN { get { if (this.Student == null) return string.Empty; else return this.Student.EGN; } }
        public string StudentEmail { get { if (this.Student == null) return string.Empty; else return this.Student.Email; } }
        public string StudentCity { get { if (this.Student == null) return string.Empty; else return this.Student.City; } }
        public string StudentAddress { get { if (this.Student == null) return string.Empty; else return this.Student.Address; } }
        //public int StudentPhone { get { if (this.Student == null) return 0; else return this.Student.Phone; } }
        public int StudentPhone { get { if (this.Student == null) return 0; else return this.Student.Phone; } }
        //public int Phone { get; set; }
        public string StudentGraduateSecondarySchool { get { if (this.Student == null) return string.Empty; else return this.Student.GraduateSecondarySchool; } }

        public TSpeciality Speciality { get; set; }
        public int SpecialityID { get { if (this.Speciality == null) return 0; else return this.Speciality.ID; } }
        public string SpecialityName { get { if (this.Speciality == null) return string.Empty; else return this.Speciality.NameSpeciality; } }

        public TFaculty Faculty { get; set; }
        public string FacultyName { get { if (this.Faculty == null) return string.Empty; else return this.Faculty.FacultyName; } }
        public int FacultyID { get { if (this.Faculty == null) return 0; else return this.Faculty.ID; } }

        public TEducationLevel EducationLevel { get; set; }
        public int EducationLevelID { get { if (EducationLevel != null) return EducationLevel.ID; return 0; } }
        public string EducationLevelName { get { if (EducationLevel != null) return EducationLevel.LevelName; else return string.Empty; } }

        //public 

        public TStudentSpeciality()
        {
            this.Student = new TStudent();
        }

        public TStudentSpeciality(StudentSpeciality stsp)
        {
            this.Credits = stsp.Credits;
            this.StartYear = stsp.StartYear;
            this.FinishYear = stsp.FinishYear;
            this.Course = new TCourse(stsp.Course);
            this.FormOfEducation = new TFormOfEducation(stsp.FormOfEducation);
            this.FacultyNumber = stsp.FacultyNumber;
            this.Student = new TStudent(stsp.Student);
            this.Speciality = new TSpeciality(stsp.Speciality);
            this.Faculty = this.Speciality.Faculty;
            this.EducationLevel = new TEducationLevel(stsp.ЕducationaLevel);
            
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    StudentSpeciality studentSpeciality = new StudentSpeciality();
                    if (this.ID > 0)
                    {
                        studentSpeciality = (from sts in db.StudentSpecialities where sts.ID == this.ID select sts).FirstOrDefault();
                    }

                    studentSpeciality.Credits = this.Credits;
                    studentSpeciality.SpecialityID = this.SpecialityID;
                    studentSpeciality.StartYear = this.StartYear;
                    studentSpeciality.FinishYear = this.FinishYear;
                    studentSpeciality.CourseID = this.CourseID;
                    studentSpeciality.FormOfEducationID = this.FormOfEducationID;
                    studentSpeciality.StudentID = this.StudentID;
                    studentSpeciality.FacultyNumber = this.FacultyNumber;
                    studentSpeciality.EducationLevelID = this.EducationLevel.ID;
                    

                    if (this.ID == 0) db.StudentSpecialities.InsertOnSubmit(studentSpeciality);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }


        public static List<TStudentSpeciality> LoadData(out string error)
        {
            List<TStudentSpeciality> StudentSpecialities = new List<TStudentSpeciality>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    StudentSpecialities = (from stsp in db.StudentSpecialities select new TStudentSpeciality(stsp)).ToList();
                }
            }

            catch (Exception ex)
            {
                error = ex.Message;
            }
            return StudentSpecialities;
        }

    }
}
