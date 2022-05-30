namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("FizzBang");
                }

                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("BuzzBang");
                }

                else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 7 == 0)
                {
                    Console.WriteLine("Bang");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}