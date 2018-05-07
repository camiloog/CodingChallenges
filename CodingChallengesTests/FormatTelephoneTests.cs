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
    public class FormatTelephoneTests
    {
        [TestMethod()]
        public void FormatTelephoneTest()
        {
            FormatTelephone S = new FormatTelephone();

            Assert.AreEqual(S.solution("0 - 22 1985--324"), "022-198-53-24");
            Assert.AreEqual(S.solution("00-44  48 5555 8361"), "004-448-555-583-61");
            Assert.AreEqual(S.solution("555372654"), "555-372-654");
        }
    }
}