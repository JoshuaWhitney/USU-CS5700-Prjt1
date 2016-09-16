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
            BeginningTotal = 0;
            EndingTotal = 0;
            InterestPaid = 0;
            FeesCollected = 0;

            // Create PersonList from file
            PersonList personList = new PersonList() { StorageStrategy = StorageStrategy };
            personList.Load(InputFileName);
            /*
            // Compute beginning balance
            foreach (Person person in personList)
                BeginningTotal += person.Balance;

            // Foreach account compute fees and interest
            foreach (Person person in personList)
            {
                int interest = InterestStrategy?.Calculate(person) ?? 0;
                person.Balance += interest;
                InterestPaid += interest;

                int fee = FeeStrategy?.Calculate(person) ?? 0;
                person.Balance -= fee;
                FeesCollected += fee;
            }

            // Compute beginning balance
            foreach (Person person in personList)
                EndingTotal += person.Balance;
            */
        }
    }
}
