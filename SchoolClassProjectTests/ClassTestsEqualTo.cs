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
    public class ClassTestsEqualTo
    {
        [TestMethod()]
        public void EqualToTestDifferentId()
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
            bool actual = aOsztaly.EqualTo(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestDifferentMonthlyPaid()
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
            bool actual = aOsztaly.EqualTo(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestDifferentIdAndMonthlyPaid()
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
            bool actual = aOsztaly.EqualTo(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestSameSchoolYear()
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
            bool actual = aOsztaly.EqualTo(bOsztaly);
            //assert
            Assert.IsTrue(actual);
        }
    }
}