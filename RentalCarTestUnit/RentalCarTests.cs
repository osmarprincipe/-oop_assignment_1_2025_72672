using oop_assignment_1_2025_72672.Models;

namespace RentalCarTestUnit
{
    public class RentalCarTests
    {


        private RentalCar CreateDefaultRentalCar(bool borrowed = false)
        {
            return new RentalCar("BMW", "X1", "SUV", "202-D-11111", 90.0, borrowed);
        }

        [Fact]
        public void Constructor_Properties_Are_Set_Correctly()
        {
            var rentalcar = CreateDefaultRentalCar();

            Assert.Equal("BMW", rentalcar.Manufacturer);
            Assert.Equal("X1", rentalcar.Model);
            Assert.Equal("SUV", rentalcar.BodyType);
            Assert.Equal("202-D-11111", rentalcar.RegistrationNumber);
            Assert.Equal(90.0, rentalcar.Price);
        }

        [Fact]
        public void Constructor_Empty_Manufacturer_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RentalCar("", "X1", "SUV", "202-D-11111", 90.0));
        }

        [Fact]
        public void Constructor_Empty_Model_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RentalCar("BMW", "", "SUV", "202-D-11111", 90.0));
        }
        [Fact]
        public void Constructor_Empty_BodyType_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RentalCar("BMW", "X1", "", "202-D-11111", 90.0));
        }
        [Fact]
        public void Constructor_Empty_RegistrationNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RentalCar("BMW", "X1", "SUV", "", 90.0));
        }

        [Fact]
        public void Constructor_0_Price_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RentalCar("BMW", "X1", "SUV", "202-D-11111", 0));
        }

        [Fact]
        public void Borrow_WhenNotBorrowed_SetsBorrowedTrueAndReturnsTrue()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: false);

            // Act
            bool bookingSucceeded = car.Borrow();

            // Assert
            Assert.True(bookingSucceeded);
            Assert.True(car.Borrowed);
            Assert.True(car.CheckBorrowed());
        }

        [Fact]
        public void Borrow_WhenAlreadyBorrowed_DoesNotChangeStatusAndReturnsFalse()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: true);

            // ajuda a ver se o carro realmente começou alugado
            Assert.True(car.Borrowed);          // se isso falhar, o problema é o construtor/helper

            // Act
            bool bookingSucceeded = car.Borrow();

            // Assert
            Assert.False(bookingSucceeded);
            Assert.True(car.Borrowed);
            Assert.True(car.CheckBorrowed());
        }


        [Fact]
        public void ReturnRentalCar_WhenBorrowed_SetsBorrowedFalse()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: true);

            // Act
            car.ReturnRentalCar();

            // Assert
            Assert.False(car.Borrowed);
            Assert.False(car.CheckBorrowed());
        }

        [Fact]
        public void CheckPrice_ReturnsCurrentPrice()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: false);

            // Act
            double currentPrice = car.CheckPrice();

            // Assert
            Assert.Equal(90.0, currentPrice);
        }

        [Fact]
        public void ChangePrice_UpdatesPrice()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: false);

            // Act
            car.ChangePrice(120.0);

            // Assert
            Assert.Equal(120.0, car.Price);
            Assert.Equal(120.0, car.CheckPrice());
        }

        [Fact]
        public void CheckBorrowed_ReturnsCorrectStatus()
        {
            // Arrange
            var car = CreateDefaultRentalCar(borrowed: false);

            // Act + Assert
            Assert.False(car.CheckBorrowed());

            car.Borrow();

            Assert.True(car.CheckBorrowed());
        }
    }
}
