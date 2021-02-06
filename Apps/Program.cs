using System;

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
                var input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }

                Util.Calc()

            }
        }
    }
}
