using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void AmyntaGroupPrintsWhenDivisibleByThreeOrFive()
        {
            Program AG = new Program();
            int a = 1;
            int b = 101;
            AG.AmyntaGroupFizzBuzz(a, b);
        }
    }
}