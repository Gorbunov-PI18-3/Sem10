using System;
using System.Collections.Generic;
using System.Text;

namespace Sem10_HW
{
    public class Calc : ICalculator
    {
        ICalculator Calculator { get; }
        public Calc(ICalculator calculator)
        {

        }

        public void Solve(int number, int number2)
        {
            Calculator.Solve(number, number2);
        }
    }
}
