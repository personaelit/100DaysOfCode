using System;
using Util;

namespace App
{
    class Program
    {
        static decimal _leftOperand;
        static void Main(string[] args)
        {
            //round one - we are going to support simple arthimetic, +,-,*/.
            //maybe someday maybe never - multi-step expressions using order of operations

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

                try
                {
                    //TODO: keyword fun.
                    if (input == "pi" || input == "π")
                    {
                        Console.WriteLine(Math.PI);
                    }
                    else
                    {
                        ExpressionEvaluator evaluator = new ExpressionEvaluator(input);
                        _leftOperand = evaluator.Left;
                        Console.WriteLine(new Calc(evaluator).PerformCalulation());
                    }
                }
                catch (DivideByZeroException)
                {
                    //have fun with this
                    //have fun with this
                    int strobeFor = new Random().Next(7, 17);
                    for (int i = 0; i <= strobeFor; i++)
                    {
                        Joggle();
                        Console.SetCursorPosition(0, Console.CursorTop);
                        DivvyNothing(strobeFor == i);
                        System.Threading.Thread.Sleep(new Random().Next(7, 777));
                    }
                }
                catch (Exception)
                {
                    //TODO: Fun with Invalid Expressions.
                    throw;
                }
            }

            static void DivvyNothing(bool writeLine)
            {
                if (!writeLine)
                {
                    Console.Write($"Error: Cannot divide {_leftOperand} by zero per laws of the universe.");
                    return;
                }

                Console.WriteLine($"Error: Cannot divide {_leftOperand} by zero per laws of the universe.");
            }
        }

        private static void Joggle()
        {
            Console.ForegroundColor = (ConsoleColor)new Random().Next(0, 15);
            Console.BackgroundColor = (ConsoleColor)new Random().Next(0, 15);
            
            while (Console.ForegroundColor == Console.BackgroundColor)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(0, 15);
            }
        }
    }
}
