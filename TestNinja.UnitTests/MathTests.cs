
using NUnit.Framework;
using TestNinja.Fundamentals;
using System.Collections.Generic;
using System.Linq;

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
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Actual
            var result = _math.Add(1,2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert
            /*Estas formas son validas, pero existe una forma mas limpia*/
            //Assert.That(result, Is.Not.Empty);

            //Assert.That(result.Count, Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //Forma preferida para validar Collections
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Asserts Utiles
            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

        }
    }
}
