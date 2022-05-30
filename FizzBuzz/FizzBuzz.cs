//split
namespace FizzBuzz
{
    public class FizzBuzz
    {
        private bool IsDivisibleBy(int nominator, int denominator)
        {
            return nominator % denominator == 0;
        }
        public void DoFizzBuzz(int maxNumber)
        {      
            for (int i = 1; i <= maxNumber; i++)
            {
                Console.WriteLine(RulesForEachNumber(i));
            }
        }

        private bool StartsWithB(string testString)
        {
            return testString[0] == 'B';
        }

        public string RulesForEachNumber(int number)
        {
            List<string> displayResult = new List<string>();

                if (IsDivisibleBy(number, 3)) 
                {
                    displayResult.Add("Fizz");
                }

                if (IsDivisibleBy(number, 5))
                {
                    displayResult.Add("Buzz");
                }

                if (IsDivisibleBy(number, 7))
                {
                    displayResult.Add("Bang");
                }

                if (IsDivisibleBy(number, 11))
                {
                   displayResult = new List<string>{ "Bong" };
                }

                if(IsDivisibleBy(number, 13))
                {
                    int firstBIndex = displayResult.FindIndex(StartsWithB);

                    if (firstBIndex == -1)
                    {
                        displayResult.Add("Fezz");
                    }

                    else 
                    {
                        displayResult.Insert(firstBIndex, "Fezz");
                    }
                }

                if (IsDivisibleBy(number, 17))
                {
                    displayResult.Reverse();
                }
                
                if (displayResult.Count == 0)
                {
                    displayResult.Add(number.ToString());
                }

                return string.Join("", displayResult);
           
        }
    }
}
