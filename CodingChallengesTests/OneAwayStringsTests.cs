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
    public class OneAwayStringsTests
    {
        [TestMethod()]
        public void OneAwayStringsTest()
        {
            OneAwayStrings S = new OneAwayStrings();
            Assert.AreEqual(S.solution("abcde", "abcd"), true);
            Assert.AreEqual(S.solution("abde", "abcde"), true);
            Assert.AreEqual(S.solution("a", "a"), true);
            Assert.AreEqual(S.solution("abcdef", "abqdef"), true);
            Assert.AreEqual(S.solution("abcdef", "abccef"), true);
            Assert.AreEqual(S.solution("abcdef", "abcde"), true);
            Assert.AreEqual(S.solution("aaa", "abc"), false);
            Assert.AreEqual(S.solution("abcde", "abc"), false);
            Assert.AreEqual(S.solution("abc", "abcde"), false);
            Assert.AreEqual(S.solution("abc", "bcc"), false);
        }
    }
}