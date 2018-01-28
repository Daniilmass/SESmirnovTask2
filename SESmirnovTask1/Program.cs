using System;

namespace SESmirnovTask1
{
    class Program
    {
        static void Main(string[] args)
          
        {
            int x;
            Console.WriteLine("Hello World! Enter a numerical value from 1 to 10");
            x = Console.Read();

            if (x > 5)
            {
                Console.WriteLine("Nice, number is bigger than 5!");
            }
            else
            {
                Console.WriteLine("Number is NOT bigger than 5");
            }
            Console.WriteLine("BYE");
        }
    }
}
