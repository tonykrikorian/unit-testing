using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomersControllerTests
    {
        private CustomerController _controller;
        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_WhenIdIsZero_ReturnNotFound()
        {

            var result = _controller.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
            Assert.That(result, Is.InstanceOf<ActionResult>());
        }
        [Test]
        public void GetCustomer_WhenIdIsNotZero_ReturnOk()
        {
            var result = _controller.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());
            Assert.That(result, Is.InstanceOf<ActionResult>());
        }
    }
}
