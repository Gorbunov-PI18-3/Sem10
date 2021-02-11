using System;

namespace Sem10_HW
{
    class Program
    {
       void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());


        }
    }



    public interface ICalculator
    {

        void Solve(int number, int number2);

    }

    class Calculator : ICalculator
    {
        public void Solve(int number, int number2)
        {
            
        }
    }
}
