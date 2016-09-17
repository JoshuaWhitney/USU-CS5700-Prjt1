using Assignment1.IO;
using System.Collections.Generic;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1
{
    class Processor
    {
        public ImportExporterStrategy StorageStrategy { get; set; }
        public string InputFileName { get; set; }

        public void Run()
        {
            // Create PersonList from file
            PersonList personList = new PersonList() { StorageStrategy = StorageStrategy };
            personList.Load(InputFileName);

            int index = 0;
            var matcher = new Matcher();
            //Begin to look for matches, iterate through all object in list
            //Console.WriteLine(personList.GetSize() + " - Number of objects");
            foreach (Person person1 in personList)
            {

                List<Person> restOfList = personList.GetSublist(index+1, (personList.GetSize()-1) - index);
                foreach (Person person2 in restOfList)
                {
                    int match = matcher.MatchMethod1(person1, person2);
                    match += matcher.MatchMethod2(person1, person2);
                    match += matcher.MatchMethod3(person1, person2);

                    if (match >= 1)
                        Console.WriteLine("Match between Person #" + person1.ObjectId +" and  #" + person2.ObjectId);



                    //Console.WriteLine("Compare Person #" + person1.ObjectId + " and Person #" + person2.ObjectId);
                }
                Console.WriteLine("");

                index++;

                /* Print contents of each object in personList
                Console.WriteLine("Person #" + person1.ObjectId +
                                    "\n\tState File Number: " + person1.StateFileNumber +
                                    "\n\tSocial Security Number: " + person1.SocialSecurityNumber +
                                    "\n\tFirst Name: " + person1.FirstName +
                                    "\n\tMiddle Name: " + person1.MiddleName +
                                    "\n\tLast Name: " + person1.LastName +
                                    "\n\tBirth Day: " + person1.BirthDay +
                                    "\n\tBirth Month: " + person1.BirthMonth +
                                    "\n\tBirth Year: " + person1.BirthYear +
                                    "\n\tGender: " + person1.Gender);
                if (person1 is Adult)
                {
                    Adult adult = (Adult)person1;
                    Console.WriteLine("\tPhone Number 1:" + adult.Phone1 +
                                        "\n\tPhone Number 2:" + adult.Phone2);
                }
                else if (person1 is Child)
                {
                    Child child = (Child)person1;
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
