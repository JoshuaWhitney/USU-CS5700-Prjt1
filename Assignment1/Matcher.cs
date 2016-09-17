using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Matcher
    {
        private bool checkIfSSN(Person p1, Person p2)
        {
            if (p1.SocialSecurityNumber == null || p2.SocialSecurityNumber == null) return false;
            return true;
        }

        private bool checkIfSFN(Person p1, Person p2)
        {
            if (p1.StateFileNumber == null || p2.StateFileNumber == null) return false;
            return true;
        }

        private bool checkIfNSN(Person p1, Person p2)
        {
            if (p1 is Adult || p2 is Adult)
            {
                return false;
            }
            Child c1 = (Child)p1;
            Child c2 = (Child)p2;
            if (c1.NewbornScreeningNumber == null || c2.NewbornScreeningNumber == null) return false;
            return true;
        }

        private bool checkForTwoNames(Person p1, Person p2)
        {
            int score = 3;
            if (p1.FirstName == null || p2.FirstName == null)
                score--;
            if (p1.MiddleName == null || p2.MiddleName == null)
                score--;
            if (p1.LastName == null || p2.LastName == null)
                score--;
            if (score >= 2) return true;
            return false;
        }

        public int MatchMethod1(Person p1, Person p2)
        {
            //if (checkType(p1, p2) == -1) return -1;
            if (checkIfSSN(p1, p2))
            {
                if (p1.SocialSecurityNumber == p2.SocialSecurityNumber &&
                    p1.BirthYear == p2.BirthYear &&
                    p1.BirthMonth == p2.BirthMonth &&
                    p1.BirthDay == p2.BirthDay)
                    return 1;
            }
            else if (checkIfSFN(p1, p2))
            {
                if (p1.StateFileNumber == p2.StateFileNumber &&
                    p1.BirthYear == p2.BirthYear &&
                    p1.BirthMonth == p2.BirthMonth &&
                    p1.BirthDay == p2.BirthDay)
                    return 1;
            }
            else if (checkIfNSN(p1, p2))
            {
                Child c1 = (Child)p1;
                Child c2 = (Child)p2;
                if (c1.StateFileNumber == c2.StateFileNumber &&
                    p1.BirthYear == p2.BirthYear &&
                    p1.BirthMonth == p2.BirthMonth &&
                    p1.BirthDay == p2.BirthDay)
                    return 1;
            }
            return 0;
        }


        public int MatchMethod2(Person p1, Person p2)
        {
            if (checkForTwoNames(p1, p2) == false) return 0;
            else if (checkIfSSN(p1, p2))
            {
                if (p1.SocialSecurityNumber == p2.SocialSecurityNumber &&
                    p1.FirstName == p2.FirstName &&
                    p1.MiddleName == p2.MiddleName &&
                    p1.LastName == p2.LastName)
                    return 1;
            }
            else if (checkIfSFN(p1, p2))
            {
                if (p1.StateFileNumber == p2.StateFileNumber &&
                    p1.FirstName == p2.FirstName &&
                    p1.MiddleName == p2.MiddleName &&
                    p1.LastName == p2.LastName)
                    return 1;
            }
            else if (checkIfNSN(p1, p2))
            {
                if (p1.StateFileNumber == p2.StateFileNumber &&
                    p1.FirstName == p2.FirstName &&
                    p1.MiddleName == p2.MiddleName &&
                    p1.LastName == p2.LastName)
                    return 1;
            }
            return 0;
        }

        public int MatchMethod3(Person p1, Person p2)
        {
            if (checkForTwoNames(p1, p2) == false) return 0;
            else if (p1.Gender == p2.Gender &&
                    p1.FirstName == p2.FirstName &&
                    p1.MiddleName == p2.MiddleName &&
                    p1.LastName == p2.LastName &&
                    p1.BirthYear == p2.BirthYear &&
                    p1.BirthMonth == p2.BirthMonth &&
                    p1.BirthDay == p2.BirthDay)
                return 1;
            return 0;
        }
    }
}
