using System.Runtime.Serialization;

namespace Assignment1
{
    public class Child : Person
    {
        public string NewbornScreeningNumber { get; set; }
        public string IsPartOfMultipleBirth { get; set; }
        public int BirthOrder{ get; set; }
        public string BirthCounty { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherMiddleName { get; set; }
        public string MotherLastName { get; set; }
    }
}
