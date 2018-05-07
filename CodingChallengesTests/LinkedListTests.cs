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
    public class LinkedListTests
    {
        [TestMethod()]
        public void LinkedListTest()
        {
            LinkedList S = new LinkedList();

            Assert.AreEqual(S.solution(new int[] { 1, 4, -1, 3, 2 }),4);
        }
    }
}