using System;
using System.Windows.Forms;
using Assignment1.IO;

/*
    Notes from class:
    #1 concern: Properly implementing strategy pattern
    #2 concern: Unit testing - need at least _some_



*/

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

            CreateTestData();

            Application.Run(new UserInterface());
        }

        private static void CreateTestData()
        {
            Random ran = new Random();
            PersonList set = new PersonList() { StorageStrategy = new XmlImportExportStrategy() };
            set.Save("Test.xml");
            set.StorageStrategy = new JsonImporterExporterStrategy();
            set.Save("Test.json");
        }
    }
}
