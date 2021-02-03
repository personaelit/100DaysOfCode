using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simple calc!");
            Console.WriteLine("Try some basic math.");
            Console.WriteLine("\"exit\" to exit.");
            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }

                var operator = GetOperator(input);

                //round one - we are going to support simple addition.
                //round two - subtraction
                //round three - multiplication
                //round four - wager a guess - oh yes, division.
                //bonus round - simple expressions using order of operations



            }

        }

        private static object GetOperator(string input)
        {
            throw new NotImplementedException();
        }
    }
}
