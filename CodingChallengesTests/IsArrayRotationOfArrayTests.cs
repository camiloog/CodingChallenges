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
    public class IsArrayRotationOfArrayTests
    {
        [TestMethod()]
        public void IsArrayRotationOfArrayTest()
        {
            IsArrayRotationOfArray C = new IsArrayRotationOfArray();

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 4, 5, 6, 7, 8, 1, 2, 3}
                ), false);

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 4, 5, 6, 7, 1, 2, 3}
                ), true);

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 4, 5, 6, 9, 1, 2, 3}
                ), false);

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 4, 6, 5, 7, 1, 2, 3}
                ), false);

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 4, 5, 6, 7, 0, 2, 3}
                ), false);

            Assert.AreEqual(
                C.solution(
                new int[] { 1, 2, 3, 4, 5, 6, 7},
                new int[] { 1, 2, 3, 4, 5, 6, 7}
                ), true);
        }
    }
}