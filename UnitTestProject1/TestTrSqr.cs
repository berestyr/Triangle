using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class TestTrSqr
    {
        [TestMethod]
        public void trSqr2_3and4and5_6returned()
        {
            //arrange
            double lineA = 3;
            double lineB = 4;
            double lineC = 5;
            double expected = 6;

            //act
            MathOperation c = new MathOperation();
            double actual = c.trSqr2(lineA, lineB, lineC);

            //assert

            Assert.AreEqual(expected, actual);

        }

        
    }
}
