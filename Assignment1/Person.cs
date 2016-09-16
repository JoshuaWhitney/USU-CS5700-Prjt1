using System.Runtime.Serialization;

namespace Assignment1
{
    public class Person
    {
        public int ObjectId { get; set; }
        public string StateFileNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public string Gender { get; set; }
    }
}
