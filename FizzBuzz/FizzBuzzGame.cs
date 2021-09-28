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
                if(Check(3,i))
                {
                    answer += "Fizz";
                }
                if(Check(5,i))
                {
                    answer += "Buzz";
                }
                yield return answer;
            }
        }

        private bool Check(int n,int i)
        {
            if (i % n == 0)
            {
                return true;
            }
            string str = i.ToString();
            if(str.Contains(n+""))
            {
                return true;
            }
            return false;
        }  
    }
}
