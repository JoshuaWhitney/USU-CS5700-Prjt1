﻿using System.Runtime.Serialization;

namespace Assignment1
{
    [DataContract]
    public class Child : Person
    {
        [DataMember]
        public string NewbornScreeningNumber { get; set; }
        [DataMember]
        public string IsPartOfMultipleBirth { get; set; }
        [DataMember]
        public int BirthOrder{ get; set; }
        [DataMember]
        public string BirthCounty { get; set; }
        [DataMember]
        public string MotherFirstName { get; set; }
        [DataMember]
        public string MotherMiddleName { get; set; }
        [DataMember]
        public string MotherLastName { get; set; }
    }
}
