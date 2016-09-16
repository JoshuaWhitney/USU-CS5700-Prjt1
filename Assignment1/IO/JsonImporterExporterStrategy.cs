using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace Assignment1.IO
{
    public class JsonImporterExporterStrategy : ImportExporterStrategy
    {

        public override List<Person> Load(string filename)
        {
            List<Person> accounts = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Child), typeof(Adult) });

            if (OpenReader(filename))
            {
                accounts = serializer.ReadObject(Reader.BaseStream) as List<Person>;
                Reader.Close();
            }
            foreach (Person person in accounts)
            {
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
            }
            return accounts;
        }

        public override void Save(string filename, List<Person> accounts)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Child), typeof(Adult) });

            if (OpenWriter(filename))
            {
                serializer.WriteObject(Writer.BaseStream, accounts);
                Writer.Close();
            }
        }
    }
}
