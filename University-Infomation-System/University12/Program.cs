using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using University12.Classes;
using University12.Forms;

namespace University12
{
    static class Program
    {
        //static property for ImageUrl
        public static string ImageURl = @"D:\University12(18)\University12\Images";
        public static string Connectionstring = "Data Source=.;Initial Catalog=\"University 1234\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public static TUsers CurrentUser { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUniversity());
            
    }
        public static string SqlConnection = "Data Source=.;Initial Catalog = University 1234 ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        }
    
    }

