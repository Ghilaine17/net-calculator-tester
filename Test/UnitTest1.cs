using NUnit.Framework;
using System.IO;
using System;
using NUnit.Framework.Interfaces;


namespace Netcalculatortest
{
    public class Tests
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1.5f, 1.5f, 3)]
        [TestCase(29.2f, 10.8f, 40)]
        public void TestMethodAdd(float num1, float num2, float result)
        {
            Calculator calculator = new Calculator();
           float Add = calculator.Add(num1, num2); 
            Assert.That(Add == result);
        }
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(3, 1.5f, 1.5f)]
        [TestCase(40, 10.8f, 29.2f)]
        public void TestMethodSubstract(float num1, float num2, float result)
        {
            Calculator calculator = new Calculator();
            float Sub = calculator.Substract(num1, num2);
            Assert.That(Sub == result);
        }
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1.5f, 1.5f, 2.25f)]
        [TestCase(20, 10, 200)]
        public void TestMethodMultiply(float num1, float num2, float result)
        {
            Calculator calculator = new Calculator();
            float Mul = calculator.Moltiplication(num1, num2);
            Assert.That(Mul == result);
        }
        [Test]
        [TestCase(2,2, 1)]
        [TestCase(3, 1.5f, 2)]
        [TestCase(40, 10.8f, 3.703703704f)]
        public void TestMethodDivide(float num1, float num2, float result)
        {
            Calculator calculator = new Calculator();
            float Div = calculator.Divide(num1, num2);
            Assert.That(Div == result);
        }
    }
}