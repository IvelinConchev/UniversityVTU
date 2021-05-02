using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TFormOfEducation
    {
        public TFormOfEducation()
        {

        }

        public TFormOfEducation(FormOfEducation forme)
        {
            this.ID = forme.ID;
            this.Name = forme.Name;
        }

        public string Save()
        {
            string error = "";

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    FormOfEducation formOfEducation = new FormOfEducation();
                    if (this.ID > 0)
                    {
                        formOfEducation = (from foe in db.FormOfEducations where foe.ID == this.ID select foe).FirstOrDefault();
                    }

                    formOfEducation.Name = this.Name;

                    if (this.ID == 0) db.FormOfEducations.InsertOnSubmit(formOfEducation);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }


        public static List<TFormOfEducation>LoadData(out string error)
        {
            List<TFormOfEducation> FormOfEducations = new List<TFormOfEducation>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    FormOfEducations = (from forme in db.FormOfEducations select new TFormOfEducation(forme)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return FormOfEducations;
        }
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
