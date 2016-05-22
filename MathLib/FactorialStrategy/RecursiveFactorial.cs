using System;
using WA.Mathematics.Properties;

namespace WA.Mathematics
{
    public class RecursiveFactorial : IFactorialStrategy
    {
        public long Factorial(int num)
        {
            if (num < 0)
                throw new ArgumentException(Resources.Err_FactorialForNegativeIntegersNotDefined, nameof(num));

            return num > 1 ? num * Factorial(num - 1) : 1;
        }
    }
}