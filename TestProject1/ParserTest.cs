using PieceWiseInput;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ParserTest and is intended
    ///to contain all ParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ParserTest
    {


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
        ///A test for eval
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PieceWiseInput.exe")]
        public void evalTestEval()
        {
            Parser_Accessor target = new Parser_Accessor(); // TODO: Initialize to an appropriate value
            String input;
            double expected;
            double actual;

            try
            {
                input = "6*x^2";
                target.inputFuntion(input);
                expected = 24F; // TODO: Initialize to an appropriate value
                actual = target.evalFuncAt(2);
                Assert.AreEqual(expected, actual);
                Console.WriteLine("e: " + expected + " a: " + actual); 

                input = "sin(PI/2)";
                target.inputFuntion(input);
                expected = 1F; // TODO: Initialize to an appropriate value
                actual = target.evalFuncAt(5);
                Assert.AreEqual(expected, actual);
                Console.WriteLine("e: " + expected + " a: " + actual); 

                input = "5*x+2";
                target.inputFuntion(input);
                expected = 7F; // TODO: Initialize to an appropriate value
                actual = target.evalFuncAt(1);
                Assert.AreEqual(expected, actual);
                Console.WriteLine("e: " + expected + " a: " + actual); 

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            
        }
    }
}
