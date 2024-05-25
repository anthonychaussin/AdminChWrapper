using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdminChWrapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminChWrapper.Models.Tests
{
    [TestClass()]
    public class CompanyTests
    {
        [TestMethod()]
        [DataRow("(INFOMANIAK NETWORK AG) (INFOMANIAK NETWORK LTD)", new string[] {"INFOMANIAK NETWORK AG", "INFOMANIAK NETWORK LTD"})]
        [DataRow("(Manufactory of Watches Rolex Ltd) (Uhrenfabrik Rolex AG)", new string[] { "Manufactory of Watches Rolex Ltd", "Uhrenfabrik Rolex AG" })]
        public void ListTranslatedNameParserTest(string names, string[] expectedNames)
        {
            CollectionAssert.AreEqual(expectedNames, Company.ListTranslatedNameParser(names).ToArray());
        }
    }
}