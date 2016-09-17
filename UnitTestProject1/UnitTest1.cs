using Microsoft.VisualStudio.TestTools.UnitTesting;

using Assignment1;
using Assignment1.IO;

namespace Assignment1Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PersonListLoadTest()
        {
            XmlImportExportStrategy StorageStrategy = new XmlImportExportStrategy();
            PersonList testList = new PersonList() { StorageStrategy = StorageStrategy};
            testList.Load("C:\\NonsenseFolder\\NoFileHere.xml");
            Assert.IsNotNull(testList);
        }

        [TestMethod]
        public void MatcherTest()
        {
            Matcher matcher = new Matcher();
            Adult testP1 = new Adult(), testP2 = new Adult();
            testP1.SocialSecurityNumber = "9999";
            testP2.SocialSecurityNumber = "9999";
            testP1.StateFileNumber = null;
            testP2.StateFileNumber = null;
            testP1.BirthYear = 1920;
            testP1.BirthMonth = 9;
            testP1.BirthDay = 27;
            testP2.BirthYear = 1920;
            testP2.BirthMonth = 9;
            testP2.BirthDay = 27;
            testP1.FirstName = "Joeseph";
            testP1.LastName = "Joestar";
            testP2.FirstName = "Joseph";
            testP2.LastName = "Joestar";
            testP1.Gender = null;
            testP2.Gender = null;
            Assert.AreEqual(matcher.MatchMethod1(testP1, testP2), 0);
            Assert.AreEqual(matcher.MatchMethod2(testP1, testP2), 0);
            Assert.AreEqual(matcher.MatchMethod2(testP1, testP2), 0);
        }
    }
}
