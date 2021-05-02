using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University12.DB;

namespace University12.Classes
{
    public class TEducationLevel
    {
        public int ID { get; set; }

        public string LevelName { get; set; }

        public TEducationLevel()
        {

        }
        public TEducationLevel(ЕducationaLevel el)
        {
            this.ID = el.ID;
            this.LevelName = el.LevelName;

        }

        public string Save()
        {
            string error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    ЕducationaLevel educationLevel = new ЕducationaLevel();

                    if (this.ID > 0)
                    {
                        educationLevel = (from edu in db.ЕducationaLevels where edu.ID == this.ID select edu).FirstOrDefault();
                    }

                    educationLevel.LevelName = this.LevelName;

                    if (this.ID == 0) db.ЕducationaLevels.InsertOnSubmit(educationLevel);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;

        }
        public static List<TEducationLevel> LoadData(out string error)
        {
            List<TEducationLevel> educationLevels = new List<TEducationLevel>();
            error = string.Empty;

            try
            {
                using (SQLDatabaseDataContext db = new SQLDatabaseDataContext(Program.Connectionstring))
                {
                    educationLevels = (from ed in db.ЕducationaLevels select new TEducationLevel(ed)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return educationLevels;
        }
    }
}

