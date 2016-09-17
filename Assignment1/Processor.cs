using Assignment1.IO;
using System.Collections;
using System.Collections.Generic;
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

            int index = 0;

            //Begin to look for matches, iterate through all object in list
            Console.WriteLine(personList.GetSize() + " - Number of objects");
            foreach (Person person1 in personList)
            {

                List<Person> restOfList = personList.GetSublist(index+1, (personList.GetSize()-1) - index);
                foreach (Person person2 in restOfList)
                {
                    Console.WriteLine("Compare Person #" + person1.ObjectId + " and Person #" + person2.ObjectId);
                }
                Console.WriteLine("");

                index++;

                /* Print contents of each object in personList
                Console.WriteLine("Person #" + person.ObjectId +
                                    "\n\tState File Number: " + person.StateFileNumber +
                                    "\n\tSocial Security Number: " + person.SocialSecurityNumber +
                                    "\n\tFirst Name: " + person.FirstName +
                                    "\n\tMiddle Name: " + person.MiddleName +
                                    "\n\tLast Name: " + person.LastName +
                                    "\n\tBirth Day: " + person.BirthDay +
                                    "\n\tBirth Month: " + person.BirthMonth +
                                    "\n\tBirth Year: " + person.BirthYear +
                                    "\n\tGender: " + person.Gender);
                if (person is Adult)
                {
                    Adult adult = (Adult)person;
                    Console.WriteLine("\tPhone Number 1:" + adult.Phone1 +
                                        "\n\tPhone Number 2:" + adult.Phone2);
                }
                else if (person is Child)
                {
                    Child child = (Child)person;
                    Console.WriteLine("\tNewborn Screening Number:" + child.NewbornScreeningNumber +
                                        "\n\tIs Part of a Multiple Birth:" + child.IsPartOfMultipleBirth +
                                        "\n\tBirth Order:" + child.BirthOrder +
                                        "\n\tBirth County:" + child.BirthCounty +
                                        "\n\tMother's First Name:" + child.MotherFirstName +
                                        "\n\tMother's Middle Name:" + child.MotherMiddleName +
                                        "\n\tMother's Last Name:" + child.MotherLastName);
                }
                */
            }
        }
    }
}
