using System;
using System.Linq;
using WA.Mathematics.Properties;

namespace WA.Mathematics
{
    public class FunctionalFactorial : IFactorialStrategy
    {
        public long Factorial(int num)
        {
            if (num < 0)
                throw new ArgumentException(Resources.Err_FactorialForNegativeIntegersNotDefined, nameof(num));

            return num > 0 ? Enumerable.Aggregate(Enumerable.Range(1, num), 1L, (a, b) => a * b) : 1;
        }
    }
}