using System;
using System.Linq;
using WA.Mathematics.Properties;

namespace WA.Mathematics
{
    public class MathLib : IMathLib
    {
        private IFactorialStrategy _factorialStrategy;

        public MathLib() : this(new RecursiveFactorial())
        { }

        public MathLib(IFactorialStrategy factorialStrategy)
        {
            _factorialStrategy = factorialStrategy;
        }

        public long Factorial(int num) => _factorialStrategy.Factorial(num);


        public long UnevenFactorial(int num)
        {
            if (num < 0)
                throw new ArgumentException(Resources.Err_FactorialForNegativeIntegersNotDefined, nameof(num));

            return num > 0 ?
                Enumerable.Aggregate(Enumerable.Range(1, num).Where(n => n % 2 != 0), 1L, (a, b) => a * b) :
                1;
        }


        // Square Factorial is basically a normal factorial squared, 
        // so we are reusing our existing factorial functionality

        public long SquareFactorial(int num) => (long)Math.Pow(_factorialStrategy.Factorial(num), 2);
    }
}