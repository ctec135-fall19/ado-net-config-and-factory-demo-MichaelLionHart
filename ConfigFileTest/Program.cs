using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using static System.Console;

namespace ConfigFileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***** Fun with config files ***** \n");

            string[] appSettings = new string[5];
            appSettings[0] = ConfigurationManager.AppSettings["provider1"];
            appSettings[1] = ConfigurationManager.AppSettings["provider2"];
            appSettings[2] = ConfigurationManager.AppSettings["connectionString2"];
            appSettings[3] = ConfigurationManager.AppSettings["provider3"];
            appSettings[4] = ConfigurationManager.AppSettings["connectionString3"];

            foreach (string s in appSettings)
            {
                WriteLine(s);
            }
            WriteLine();

            WriteLine(ConfigurationManager.ConnectionStrings
                ["AutoLotOLeDbProvider"].ConnectionString);

        }
    }
}
