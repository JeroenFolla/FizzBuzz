using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
        public void Buzzer_When1_Return1()
        {
            //Act
            int input = 1;
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void Buzzer_When2_Returns2(
            [DataRow 2] int input)
        {
            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("2", output);
        }

        [TestMethod]
        public void Buzzer_When3_ReturnsFizz(int input)
        {
            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
    }
}
