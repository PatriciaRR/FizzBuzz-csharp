namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}