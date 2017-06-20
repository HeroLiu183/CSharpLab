using CSharpLab.ExtensionMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpLabTests.ExtensionMethodTests
{
    /// <summary>
    /// Summary description for ExtensionMethodTest
    /// </summary>
    [TestClass]
    public class ExtensionMethodTest
    {
        public ExtensionMethodTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void String_Pars_To_Int_Extension_Method_Tests()
        {
            //Arrange
            var target = "100";
            var expect = 100;
            //Act
            var actual = target.ParsToInt();
            //Assert
            Assert.AreEqual(expect,actual);
        }
    }
}
