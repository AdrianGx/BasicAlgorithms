using System;

namespace Basic_Algorithms
{
     class Program
    {
         static void fizzBuzz(int number)
        {
            for(int i=0; i<=number; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);

            }
        }
     
        static void Main(string[] args)
        {
                   /* ### TEST ### */
            Console.Write("Please insert range:");
            int range = Convert.ToInt32(Console.ReadLine());
            fizzBuzz(range);
        }
    }
}
