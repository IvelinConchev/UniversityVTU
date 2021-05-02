using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{

    public class TLecture
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public TFaculty Faculty { get; set; }
        public int FacultyID { get { if (Faculty != null) return Faculty.ID; else return 0; } }
        public string FacultyName { get { if (Faculty != null) return Faculty.FacultyName; else return string.Empty; } }

        // public string Depatment { get; set; }

        public TDepartments Department { get; set; }

        public int DepartmentID { get { if (Department != null) return Department.ID; else return 0; } }

        public string DepartmentName { get { if (Department != null) return Department.Name; else return string.Empty; } }


        public string GraduateUniversity { get; set; }

        public string City { get; set; }

        public string Image { get; set; }
        public TLecture()
        {

        }

        public TLecture(Lecture lt)
        {
            this.ID = lt.ID;
            this.FirstName = lt.FirstName;
            this.MiddleName = lt.MiddleName;
            this.LastName = lt.LastName;
            this.Title = lt.Title;
            this.Phone = lt.Phone;
            this.Email = lt.Email;
            this.Faculty = new TFaculty(lt.Faculty);
            //this.Department = lt.Departmnet;
            this.GraduateUniversity = lt.GraduateUniversity;
            this.City = lt.City;
            this.Department = new TDepartments(lt.Department);
            //this.Image = lt.Image;

            if (!string.IsNullOrEmpty(Image))
            {
                this.Image = lt.Image.Trim();
            }
        }
        public static string CheckValidLecture(string Firstname, string MiddleName, string LastName, string Title, string Department)

        {
            string error = string.Empty;
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    if (string.IsNullOrEmpty(Firstname)) { return "Името съществува"; } //името съществува или е грешно
                    if (string.IsNullOrEmpty(MiddleName)) { return "През името съществува"; } //Презимето съществува или е грешно
                    if (string.IsNullOrEmpty(LastName)) { return "Фамилията съществува"; } //Фамилията съществува или е грешна
                    if (string.IsNullOrEmpty(Title)) { return "Титлата съществува"; } // Титлата същствува или е грешна
                    if (string.IsNullOrEmpty(Department)) { return "Катедрата Съществува"; } // Катедрата същствува или е грешна

                    var use = (from us in db.Lectures where us.LastName.Equals(LastName) && us.Title.Equals(Department) && us.Title.Equals(Title) select us).FirstOrDefault();
                    if (use == null) return "Такъв потребител съществува моля въведете отново";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }



        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Lecture lecture = new Lecture();
                    if (this.ID > 0)
                    {
                        lecture = (from le in db.Lectures where le.ID == this.ID select le).FirstOrDefault();
                    }

                    lecture.FirstName = this.FirstName;
                    lecture.LastName = this.LastName;
                    lecture.MiddleName = this.MiddleName;
                    lecture.Title = this.Title;
                    lecture.Phone = this.Phone;
                    lecture.Email = this.Email;
                    lecture.FacultyID = this.FacultyID;
                    //  lecture.Departmnet = this.Department;
                    lecture.GraduateUniversity = this.GraduateUniversity;
                    lecture.City = this.City;
                    lecture.Image = this.Image;

                    if (this.ID == 0) db.Lectures.InsertOnSubmit(lecture);
                    db.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static List<TLecture> LoadData(out string error)
        {
            List<TLecture> Lectures = new List<TLecture>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    Lectures = (from lt in db.Lectures select new TLecture(lt)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return Lectures;
        }

    }

}
