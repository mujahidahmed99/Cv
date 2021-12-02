using System;
using static System.Console;
namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            Tennis t = new Tennis();
            for (int i = 0; i < 0; i++)
            {
                t.Player1WinsPoint();
            }
            for (int i = 0; i < 1; i++)
            {
                t.Player2WinsPoint();
            }
            Console.WriteLine(t.score());
        }
    }
}
