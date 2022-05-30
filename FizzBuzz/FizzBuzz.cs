using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void DoFizzBuzz(int maxNumber)
        {      
            for (int i = 1; i <= maxNumber; i++)
            {
                List<String> displayResult = new List<string>();

                if (i % 3 == 0) 
                {
                    displayResult.Add("Fizz");
                }

                if (i % 5 == 0)
                {
                    displayResult.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    displayResult.Add("Bang");
                }

                if (i % 11 == 0) 
                {
                    displayResult.Add("Bong");
                }

                if (i % 17 == 0)
                {
                    displayResult.Reverse();
                }
                
                if (displayResult.Count == 0)
                {
                    displayResult.Add(i.ToString());
                }

                Console.WriteLine(string.Join("", displayResult));
           
            }
        }
    }
}