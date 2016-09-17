using Assignment1.IO;
using System;

namespace Assignment1
{
    class Processor
    {
        public ImportExporterStrategy StorageStrategy { get; set; }
        public string InputFileName { get; set; }
        public int NumberOfPeriods { get; set; }
        public int BeginningTotal { get; private set; }
        public int EndingTotal { get; private set; }
        public int InterestPaid { get; private set; }
        public int FeesCollected { get; private set; }

        public void Run()
        {


            // Create PersonList from file
            PersonList personList = new PersonList() { StorageStrategy = StorageStrategy };
            personList.Load(InputFileName);

            //Begin to look for matches

        }
    }
}
