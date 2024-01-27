using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Calculator;

public class Calculator
{
    public object Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero!");
        }

        int quotient = a / b;
        int remainder = a % b;

        return (quotient, remainder);
    }
}

