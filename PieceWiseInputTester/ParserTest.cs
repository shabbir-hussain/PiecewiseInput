using PieceWiseInput;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieceWiseInputTester
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
        ///A test for parseFunction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PieceWiseInput.exe")]
        public void parseFunctionTest()
        {
            //test setup
            Parser target = new Parser(); // TODO: Initialize to an appropriate value
            string function = "x*6*x+sin(x)"; // TODO: Initialize to an appropriate value
            List<Token> expected = new List<Token>(); // TODO: Initialize to an appropriate value
            List<Token> actual = expected;
            expected.Add(new Token(Parser.ValType.VARIABLE,"X"));

            //test method
            try
            {
                actual = target.parseFunction(function);
            }
            catch (InvalidInputException ex)
            {
                Assert.Fail(ex.Message);
            }

            //show output
            StringBuilder output = new StringBuilder();
            foreach (Token str in actual)
            {
                output.Append(str.ToString());
                output.Append("_");
            }
            Console.Write(output.ToString());
            
            //verify output
            if (expected.Count != actual.Count)
                Assert.Fail("Input and Output are different lengths");
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i].Equals(actual[i]))
                    Assert.Fail("Values not equal at" + i);
            }

        
            Assert.IsTrue(true);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
