using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public int PlayerCount { get; set; } = 100;

        const string threeTimesString = "Fizz";

        const string fiveTimesString = "Buzz";

        public IEnumerable<string> Run()
        {
            for (int i = 1; i <= PlayerCount; i++)
            {
                var answer = "";
                if(i%3==0)
                {
                    answer += "Fizz";
                }
                if(i%5==0)
                {
                    answer += "Buzz";
                }
                yield return answer;
            }
        }
    }
}
