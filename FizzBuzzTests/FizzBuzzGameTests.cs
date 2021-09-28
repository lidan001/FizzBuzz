using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzGameTests
    {
        [TestMethod()]
        public void RunTest()
        {
            FizzBuzzGame game = new FizzBuzzGame { PlayerCount = 15 };
            var answers = game.Run().ToList();
            var rightAnswers = new List<string>
            {
                "","","Fizz","","Buzz",
                "Fizz","","","Fizz","Buzz",
                "","Fizz","Fizz","","FizzBuzz"
            };
            for(int i=0;i<answers.Count;i++)
            {
                Assert.AreEqual(answers[i], rightAnswers[i]);
            }
        }
    }
}