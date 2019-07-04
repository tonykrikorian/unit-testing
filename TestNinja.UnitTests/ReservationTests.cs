using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        //NombreMetodo_Escenario_ResultadoEsperado
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
           var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsSameWhoReserved_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var userReserve = new User();
            reservation.MadeBy = userReserve;

            //Act
            var result = reservation.CanBeCancelledBy(userReserve);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
