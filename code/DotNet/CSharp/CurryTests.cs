using NFluent;
using NUnit.Framework;
using static CSharp.Curry;

namespace CSharp
{
    public class FactorialTests
    {
        [Test]
        public void uncurried_test()
        {
            Check.That(Add(42, 19)).IsEqualTo(61);
        }

        [Test]
        public void curried_test()
        {
            Check.That(AddCurried(42)(19)).IsEqualTo(61);
        }

        [Test]
        public void curried_with_partial_test()
        {
            var addPartial = AddCurried(42);
            Check.That(addPartial(19)).IsEqualTo(61);
        }
    }
}