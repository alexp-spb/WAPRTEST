using Test1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    
    
    /// <summary>
    ///This is a test class for CompTest and is intended
    ///to contain all CompTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CompTest
    {s


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for t1
        ///</summary>
        [TestMethod()]
        public void t1Test()
        {
            Comp target = new Comp(); // TODO: Initialize to an appropriate value
            target.t1();
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Comp Constructor
        ///</summary>
        [TestMethod()]
        public void CompConstructorTest()
        {
            Comp target = new Comp();
            //Assert.Inconclusive("TODO: Implement code to verify target");
           // Assert.Fail("TEST FAIL10");
        }
    }
}
