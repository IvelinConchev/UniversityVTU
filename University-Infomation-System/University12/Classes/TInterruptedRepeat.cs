using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TInterruptedRepeat
    {
        public TInterruptedRepeat()
        {

        }

        public TInterruptedRepeat(InterruptedRepeat inr)
        {
            this.ID = inr.ID;
            this.RepeastYear = inr.RepeastYear;
            this.StudentID = inr.StudentID;
            this.SpecialityID = inr.SpecialityID;
            this.CourseID = inr.CourseID;
        }

        public string Save()
        {
            string error = "";
            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    InterruptedRepeat interruptedRepeat = new InterruptedRepeat();
                    if (this.ID > 0)
                    {
                        interruptedRepeat = (from intr in db.InterruptedRepeats where intr.ID == this.ID select intr).FirstOrDefault();
                    }

                    interruptedRepeat.RepeastYear = this.RepeastYear;
                    interruptedRepeat.StudentID = this.StudentID;
                    interruptedRepeat.SpecialityID = this.SpecialityID;
                    interruptedRepeat.CourseID = this.CourseID;

                    if (this.ID == 0) db.InterruptedRepeats.InsertOnSubmit(interruptedRepeat);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }

        public static List<TInterruptedRepeat>LoadData(out string error)
        {
            List<TInterruptedRepeat> InterruptedRepeats = new List<TInterruptedRepeat>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    InterruptedRepeats = (from inr in db.InterruptedRepeats select new TInterruptedRepeat(inr)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return InterruptedRepeats;
        }
        public int ID { get; set; }

        public DateTime? RepeastYear { get; set; }

        public int StudentID { get; set; }

        public int SpecialityID { get; set; }

        public int CourseID { get; set; }
    }
}
