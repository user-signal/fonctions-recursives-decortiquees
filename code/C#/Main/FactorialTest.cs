using NFluent;
using NUnit.Framework;
using static Main.Factorial;

namespace Main
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
            Check.That(FactTail(3, 1)).IsEqualTo(6);
        }
    }
}