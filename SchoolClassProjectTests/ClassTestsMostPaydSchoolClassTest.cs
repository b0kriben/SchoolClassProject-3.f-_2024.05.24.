using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class ClassTestsMostPaydSchoolClassTest
    {
        [TestMethod()]
        public void EqualToTestFirstMostPaidSchoolClass()
        {
            //arrage
            Class aOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "a",
                MonthlyPaid = 7000,
            };
            Class bOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "b",
                MonthlyPaid = 6000,
            };
            //act
            bool actual = aOsztaly.MostPaydSchoolClass(bOsztaly);
            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void EqualToTestSecondMostPaidSchoolClass()
        {
            //arrage
            Class aOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "a",
                MonthlyPaid = 7000,
            };
            Class bOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "b",
                MonthlyPaid = 8000,
            };
            //act
            bool actual = aOsztaly.MostPaydSchoolClass(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestSameMostPaidSchoolClass()
        {
            //arrage
            Class aOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "a",
                MonthlyPaid = 7000,
            };
            Class bOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "b",
                MonthlyPaid = 7000,
            };
            //act
            bool actual = aOsztaly.MostPaydSchoolClass(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestNoPaidSchoolClass()
        {
            //arrage
            Class aOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "a",
                MonthlyPaid = 7000,
            };
            Class bOsztaly = new Class
            {
                SchoolYear = 9,
                Id = "b",
                MonthlyPaid = 0,
            };
            //act
            bool actual = aOsztaly.MostPaydSchoolClass(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }
    }
}