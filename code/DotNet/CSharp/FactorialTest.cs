using NFluent;
using NUnit.Framework;
using static CSharp.Factorial;

namespace CSharp
{
    public class FactorialTest
    {
        [Test]
        public void fact_test()
        {
            Check.That(Fact(3)).IsEqualTo(6);
        }

        [Test]
        public void fact_tail_test()
        {
            Check.That(FactTailRecursive(3, 1)).IsEqualTo(6);
        }
    }
}