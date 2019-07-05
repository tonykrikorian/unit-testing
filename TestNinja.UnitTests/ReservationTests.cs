using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        //NombreMetodo_Escenario_ResultadoEsperado
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
           var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsSameWhoReserved_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var userReserve = new User();
            reservation.MadeBy = userReserve;

            //Act
            var result = reservation.CanBeCancelledBy(userReserve);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsAnyone_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
