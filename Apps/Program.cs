using System;
using Util;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //round one - we are going to support simple arthimetic, +,-,*/.
            //maybe someday maybe never - multi-step expressions using order of operations

            Console.WriteLine("Welcome to simple calc!");
            Console.WriteLine("Try some basic math.");
            Console.WriteLine("\"exit\" to exit.");

            while (true)
            {
                //Console.ResetColor();
                var input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }

                try
                {
                    ExpressionEvaluator evaluator = new ExpressionEvaluator(input);
                    Console.WriteLine(new Calc(evaluator).PerformCalulation());
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero per laws of the universe.");
                    Console.BackgroundColor = have fun with this
                    Console.ForegroundColor = have fun with this
                    
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
