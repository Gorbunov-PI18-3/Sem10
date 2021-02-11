using System;

namespace Sem10_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result = x + b;
            Console.WriteLine("результат сложения: " + result);
            Console.ReadKey();
        }
    }
}
