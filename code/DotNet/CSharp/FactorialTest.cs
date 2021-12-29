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
            Check.That(Fact(3u)).IsEqualTo(6);
        }

        [Test]
        public void fact_tail_test()
        {
            Check.That(FactTailRecursive(1u, 3u)).IsEqualTo(6);
        }

        [Test]
        public void fact_trampoline_test()
        {
            Check.That(FactTrampoline(1u, 3u).Run()).IsEqualTo(6);
        }
    }
}