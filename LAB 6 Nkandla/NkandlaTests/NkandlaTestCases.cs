using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB_Nkandla;

namespace NkandlaTests
{
    [TestClass]
    public class NkandlaTestCases
    {
        Homestead someplace = new Homestead("Someplace", "13", "Gauteng", "South Africa");
        Person jeff = new Person("Jeff", 29, "Male", "Lawyer", "DA");
        Nkandla nkandla = new Nkandla("Nkandla", "9", "KZN", "South Africa");
        Politician jZ = new Politician("Jacob Zuma", 43, "Male", "President", "ANC");
        Politician hZ = new Politician("Hellen Zille", 50, "Female", "Politician", "DA");
        Politician jM = new Politician("Julius Malema", 38, "Male", "Politician", "EFF");

        //Test Homestead
        [TestMethod]
        public void Test_Homestead_Name()
        {
            var result = someplace.Name;

            Assert.AreEqual(result, "Someplace");
        }
        [TestMethod]
        public void Test_Homestead_District()
        {
            var result = someplace.District;

            Assert.AreEqual(result, "13");
        }
        [TestMethod]
        public void Test_Homestead_Province()
        {
            var result = someplace.Province;

            Assert.AreEqual(result, "Gauteng");
        }
        [TestMethod]
        public void Test_Homestead_Country()
        {
            var result = someplace.Country;

            Assert.AreEqual(result, "South Africa");
        }
        [TestMethod]
        public void Test_Homestead_Accept()
        {
            var result = someplace.accept(jZ);
            Assert.AreEqual(result, "Jacob Zuma, welcome to Nkandla!");
        }
        [TestMethod]
        public void Test_Homestead_Accept_Fail()
        {
            var result = someplace.accept(hZ);
            Assert.AreEqual(result, "Hellen Zille: Pay back the money!!!");
        }

        //Test Person
        [TestMethod]
        public void Test_Peron_Name()
        {
            var result = jeff.Name;
            Assert.AreEqual(result, "Jeff");
        }
        [TestMethod]
        public void Test_Peron_Age()
        {
            var result = jeff.Age;
            Assert.AreEqual(result, 29);
        }
        [TestMethod]
        public void Test_Peron_Gender()
        {
            var result = jeff.Gender;
            Assert.AreEqual(result, "Male");
        }
        [TestMethod]
        public void Test_Person_Type()
        {
            var result = jeff.Type;
            Assert.AreEqual(result, "Lawyer");

        }
        [TestMethod]
        public void Test_Person_Party()
        {
            var result = jeff.PoliticalParty;
            Assert.AreEqual(result, "DA");
        }

        //Test Nkandla
        [TestMethod]
        public void Test_Nkandla_Name()
        {
            var result = nkandla.Name;
            Assert.AreEqual(result, "Nkandla");
        }
        [TestMethod]
        public void Test_Nkandla_District()
        {
            var result = nkandla.District;
            Assert.AreEqual(result, "9");
        }
        [TestMethod]
        public void Test_Nkandla_Province()
        {
            var result = nkandla.Province;
            Assert.AreEqual(result, "KZN");
        }
        [TestMethod]
        public void Test_Nkandla_Country()
        {
            var result = nkandla.Country;
            Assert.AreEqual(result, "South Africa");
        }
        [TestMethod]
        public void Test_Nkandla_ChickenRun()
        {
            nkandla.ChickenRun.NumerOfChickens.Equals(13);
            var result = nkandla.ChickenRun.NumerOfChickens;
            Assert.AreEqual(result, 13);
        }

        //Test Politician
        [TestMethod]
        public void Test_Politician_Name()
        {
            var result = jZ.Name;
            Assert.AreEqual(result, "Jacob Zuma");
        }
        [TestMethod]
        public void Test_Politician_Age()
        {
            var result = jZ.Age;
            Assert.AreEqual(result, 43);
        }
        [TestMethod]
        public void Test_Politician_Gender()
        {
            var result = jZ.Gender;
            Assert.AreEqual(result, "Male");
        }
        [TestMethod]
        public void Test_Politician_Type()
        {
            var result = jZ.Type;
            Assert.AreEqual(result, "President");

        }
        [TestMethod]
        public void Test_Politician_Party()
        {
            var result = jZ.PoliticalParty;
            Assert.AreEqual(result, "ANC");
        }




        [TestMethod]
        public void Test_Generic()
        {

            
        }


    }
}
