using System;
using WA.Mathematics.Properties;

namespace WA.Mathematics.MathLibFactory
{
    public class MathLibFactory : IMathLibFactory
    {
        public IMathLib GetMathLib(FactorialAlgorithm factorialAlgorithm)
        {
            IFactorialStrategy strategy;
            switch (factorialAlgorithm)
            {
                case FactorialAlgorithm.Functional:
                    strategy = new FunctionalFactorial();
                    break;
                case FactorialAlgorithm.Recursional:
                    strategy = new RecursiveFactorial();
                    break;
                default:
                    throw new NotSupportedException(string.Format(Resources.Err_FactorialAlgorithmNotSupported, factorialAlgorithm));
            }
            return new MathLib(strategy);
        }
    }
}
