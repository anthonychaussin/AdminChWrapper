using AdminChWrapper.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdminChWrapper.Api.Tests
{
    /// <summary>
    /// The search api tests.
    /// </summary>
    [TestClass()]
    public class SearchApiTests
    {
        /// <summary>
        /// Gets or sets the _api.
        /// </summary>
        private static SearchApi _api { get; set; }

        /// <summary>
        /// Classes the init.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            _api = new SearchApi();
        }


        /// <summary>
        /// Vats the search test.
        /// </summary>
        /// <param name="vat">The vat.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod()]
        [DataRow("103167648", 103167648)]
        [DataRow("CHE103167648", 103167648)]
        [DataRow("CHE-103167648", 103167648)]
        [DataRow("CHE-161.864.680", 161864680)]
        [DataRow("CHE-103.167.648", 103167648)]
        [DataRow("CHE-397.769.844", 397769844)]
        [DataRow("CHE-114.268.609", 114268609)]
        [DataRow("CHE-108.838.390", 108838390)]
        [DataRow("CHE-105.979.841", 105979841)]
        [DataRow("103.167.648", 103167648)]
        [DataRow("CHE103.167.648", 103167648)]
        [DataRow("103167648.", 103167648)]
        [DataRow(" CHE-103 167.648 ", 103167648)]
        public void VatSearchTest(string vat, int expected)
        {
            Assert.AreEqual(_api.VatSearch<Company>(vat).Id, expected);
        }

        /// <summary>
        /// Vats the search fail test.
        /// </summary>
        /// <param name="vat">The vat.</param>
        [TestMethod()]
        [DataRow(" CHE-100 000.000 ")]
        public void VatSearchFailTest(string vat)
        {
            Assert.ThrowsException<Exception>(() =>_api.VatSearch<Company>(vat));
        }
    }
}