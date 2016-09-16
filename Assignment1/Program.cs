using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1.IO;

namespace Assignment1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CreateTestData();

            Application.Run(new UserInterface());
        }

        /*private static void CreateTestData()
        {
            Random ran = new Random();
            PersonList set = new PersonList() { StorageStrategy = new XmlImportExportStrategy() };
            for (int nextAccountNumber = 0; nextAccountNumber < 100; nextAccountNumber++)
            {

                Person individual;
                if (ran.Next() < .5)
                    individual = new Child()
                    {
                        AccountNumber = "C" + nextAccountNumber.ToString().PadLeft(5, '0'),
                        Balance = ran.Next(0, 100000),
                        MaxChecksPerMonth = ran.Next(10, 200)

                    };
                else
                    individual = new Adult()
                    {
                        //AccountNumber = "S" + nextAccountNumber.ToString().PadLeft(5, '0'),
                        //Balance = ran.Next(1000, 1000000),
                        //MaxWithdrawalAmountPerMonth = ran.Next(100000, 1000000)
                    };
                set.Add(individual);
            }
            set.Save("Test.xml");
            set.StorageStrategy = new JsonImporterExporterStrategy();
            set.Save("Test.json");
        }*/
    }
}
