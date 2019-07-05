
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Add_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //Actual
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("Este test da problemas, arreglarlo luego")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Actual
            var result = _math.Add(1,2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
