namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(var i = 0; i <= 100; i++) 
            {
                Console.WriteLine($"{i}:{FizzBuzz(i)}");
            } 
        }

        public static string FizzBuzz(int num) 
        {
            var answer = string.Empty;

            if (num % 3 == 0) 
            {
                answer += "Fizz";
            }
            if (num % 5 == 0)
            {
                answer += "Buzz";
            }

            return answer;

        }   
    }
}