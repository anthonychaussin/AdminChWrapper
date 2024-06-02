using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdminChWrapper.Models.Tests
{
    /// <summary>
    /// The company tests.
    /// </summary>
    [TestClass()]
    public class CompanyTests
    {
        /// <summary>
        /// Lists the translated name parser test.
        /// </summary>
        /// <param name="names">The names.</param>
        /// <param name="expectedNames">The expected names.</param>
        [TestMethod()]
        [DataRow("(INFOMANIAK NETWORK AG) (INFOMANIAK NETWORK LTD)", new string[] {"INFOMANIAK NETWORK AG", "INFOMANIAK NETWORK LTD"})]
        [DataRow("(Manufactory of Watches Rolex Ltd) (Uhrenfabrik Rolex AG)", new string[] { "Manufactory of Watches Rolex Ltd", "Uhrenfabrik Rolex AG" })]
        public void ListTranslatedNameParserTest(string names, string[] expectedNames)
        {
            CollectionAssert.AreEqual(expectedNames, Company.ListTranslatedNameParser(names).ToArray());
        }
    }
}