using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CampaignMonitor.Interfaces;
using CampaignMonitor.Dependency;
using CampaignMonitor.Extensions;
using System.Linq;

namespace CampaignMonitor.Business.Test
{
    [TestClass]
    public class DotNetTests
    {
        private IDotNetManager _dotNetManager;
        protected IDotNetManager DotNetManager
        {
            get
            {
                return _dotNetManager = _dotNetManager ?? UnityHelper.Resolve<IDotNetManager>();
            }
        }

        //Requirement 1 Unit Test
        [TestMethod]
        public void TestIsNullOrEmptyExtension()
        {
            var emptyString = string.Empty;

            string nullString = null;
            
            Assert.IsTrue(emptyString.IsNullOrEmpty() == string.IsNullOrEmpty(emptyString));
            Assert.IsTrue(nullString.IsNullOrEmpty() == string.IsNullOrEmpty(nullString));
        }

        //Requirement 2 Unit Test
        [TestMethod]
        public void TestGetPositiveDivisors()
        {
            var resultExpected = new int[] { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };

            int[] result = DotNetManager.GetPositiveDivisors(60);

            //Check to see the arrays are the same
            Assert.IsTrue(result.Count() == resultExpected.Count());
            Assert.IsTrue(resultExpected.Intersect(result).Count() == result.Count());
        }

        //Requirement 3 Unit Test
        [TestMethod]
        public void TestGetSurfaceArea()
        {
            var resultExpected = 6;

            double result = DotNetManager.GetSurfaceArea(3, 4, 5);

            Assert.IsTrue(result == resultExpected);
        }

        //Requirement 3 Unit Test Check InvalidTriangleException
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "InvalidTriangleException")]
        public void TestGetSurfaceAreaException()
        {            
            double result = DotNetManager.GetSurfaceArea(-3, 4, 5);            
        }

        public int[] TestIntArray1
        {
            get
            {
                return new int[] { 1, 1, 4, 5, 8, 8 };
            }
        }

        //Requirement 4 Unit Test
        [TestMethod]
        public void TestFindCommonElements()
        {
            var resultExpected = new int[] { 1, 8 };

            int[] result = DotNetManager.FindCommonElements(TestIntArray1);

            //Check to see the arrays are the same
            Assert.IsTrue(result.Count() == resultExpected.Count());
            Assert.IsTrue(resultExpected.Intersect(result).Count() == result.Count());
        }
    }
}
