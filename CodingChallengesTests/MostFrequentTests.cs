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
    public class MostFrequentTests
    {
        [TestMethod()]
        public void MostFrequentTest()
        {
            MostFrequent C = new MostFrequent();

            Assert.AreEqual(C.solution(new int[] { 1, 3, 1, 3, 2, 1 }), 1);
            Assert.AreEqual(C.solution(new int[] { 3, 3, 1, 3, 2, 1 }), 3);
            Assert.AreEqual(C.solution(new int[] {}), null);
            Assert.AreEqual(C.solution(new int[] {0}), 0);
            Assert.AreEqual(C.solution(new int[] { 0, -1, 10, 10, -1, 10, -1, -1, -1, 1 }), -1);
        }
    }
}