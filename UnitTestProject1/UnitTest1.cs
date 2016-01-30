using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            int test = 1;
            Assert.AreEqual(1, test);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int test = 3;
            Assert.AreEqual(2, test);
        }

        public void PrintString(int numberOfTimeToPrint)
        {
            for (int i = 1; i <= numberOfTimeToPrint; i++)
            {
                Console.WriteLine("Hello World");
            }
        }

        public void TestPrintString()
        {
            PrintString(3);
        }

    }
}
