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
    public class CommonElementsTests
    {
        [TestMethod()]
        public void CommonElementsTest()
        {
            CommonElements C = new CommonElements();

            CollectionAssert.AreEqual(
                C.solution(
                new int[] { 0, 1, 4, 6, 7, 9 },
                new int[] { 1, 2, 4, 5, 9, 10 }
                ),
                new int[] { 1, 4, 9 }
                );
            CollectionAssert.AreEqual(
                C.solution(
                new int[] { 1, 2, 9, 10, 11, 12 },
                new int[] { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 }
                ),
                new int[] { 1, 2, 9, 10, 12 }
                );
            CollectionAssert.AreEqual(
                C.solution(
                new int[] { 0, 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9, 10, 11 }
                ),
                new int[] {}
                );
        }
    }
}