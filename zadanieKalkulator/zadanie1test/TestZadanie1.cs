using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie1;

namespace Zadanie1Test
{
    [TestClass]
    public class TestZadanie1
    {
        [TestMethod]
        public void Dodawanie()
        {
            Calculator.a = 5;
            Calculator.b = 34;
            Calculator.c = Calculator.a + Calculator.b;
            double expected = 39;

            Assert.AreEqual(expected, Calculator.c, "Not equal");

        }

        [TestMethod]
        public void Odejmowanie()
        {
            Calculator.a = 123;
            Calculator.b = 23;
            Calculator.c = Calculator.a - Calculator.b;
            double expected = 100;

            Assert.AreEqual(expected, Calculator.c, "Not equal");

        }

        [TestMethod]
        public void Mnożenie()
        {
            Calculator.a = 10;
            Calculator.b = 291;
            Calculator.c = Calculator.a * Calculator.b;
            double expected = 2910;

            Assert.AreEqual(expected, Calculator.c, "Not equal");

        }

        [TestMethod]
        public void Dzielenie()
        {
            Calculator.a = 5;
            Calculator.b = 34;
            double c = Calculator.a + Calculator.b;
            double expected = 39;

            Assert.AreEqual(expected, c, "Not equal");

        }
    }
   
}
