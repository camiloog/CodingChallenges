using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Tests
{
    [TestClass()]
    public class MinPositiveIntegerNotOccurringTests
    {
        [TestMethod()]
        public void MinPositiveIntegerNotOccurringTest()
        {
            MinPositiveIntegerNotOccurring C = new MinPositiveIntegerNotOccurring();

            Assert.AreEqual(C.solution(new int[] { 1, 2 }), 3);
            Assert.AreEqual(C.solution(new int[] { 1, 3, 6, 4, 1, 2 }), 5);
        }
    }
}