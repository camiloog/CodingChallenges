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
    public class NonRepeatingCharacterTests
    {
        [TestMethod()]
        public void NonRepeatingCharacterTest()
        {
            NonRepeatingCharacter C = new NonRepeatingCharacter();

            Assert.AreEqual(C.solution("abcab"), 'c');
            Assert.AreEqual(C.solution("abab"), null);
            Assert.AreEqual(C.solution("aabbbc"), 'c');
            Assert.AreEqual(C.solution("aabbdbc"), 'd');
        }
    }
}