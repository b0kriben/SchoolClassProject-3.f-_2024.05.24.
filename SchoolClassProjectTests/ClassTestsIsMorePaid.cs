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
    public class ClassTestsIsMorePaid
    {
        [TestMethod()]
        public void EqualToTestFirstIsMorePaid()
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
            bool actual = aOsztaly.IsMorePaid(bOsztaly);
            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void EqualToTestSecondIsMorePaid()
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
            bool actual = aOsztaly.IsMorePaid(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestSameMonthlyPaid()
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
            bool actual = aOsztaly.IsMorePaid(bOsztaly);
            //assert
            Assert.IsFalse(actual);
        }
    }
}