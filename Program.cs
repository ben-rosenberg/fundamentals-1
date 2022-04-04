using System;

namespace Fundamentals1
{
    class Practice
    {
        public void Print1To255()
        {
            for (int i = 1; i <= 255; ++i)
            {
                Console.WriteLine(i);
            }
        }

        public void Print1To100DivBy3Or5()
        {
            for (int i = 1; i <= 100; ++i)
            {
                if ((i % 3 == 0) ^ (i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; ++i)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }

        public void WhileFizzBuzz()
        {
            int i = 1;
            while (i <= 100)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    ++i;
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                ++i;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Practice practice = new Practice();

            practice.Print1To255();
            practice.Print1To100DivBy3Or5();
            practice.FizzBuzz();
            practice.WhileFizzBuzz();
        }
    }
}
