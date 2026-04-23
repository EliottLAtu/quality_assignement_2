using Moq;
using NUnit;
using System.Collections;

namespace ParkingTest1
{

    
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Testhybrid()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(10, "hybrid"), Is.EqualTo(0));

        }
        [Test]
        public void Teststandard1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(2, "standard"), Is.EqualTo(8));
        }
        [Test]
        public void Teststandard2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(5, "standard"), Is.EqualTo(15));

        }
        [Test]
        public void Teststandard3()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(0, "standard"), Is.EqualTo(0));

        }
        [Test]
        public void Testelectric1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(0, "electric"), Is.EqualTo(0));

        }
        [Test]
        public void Testelectric2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(2, "electric"), Is.EqualTo(6));

        }
        [Test]
        public void Testelectric3()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(9, "electric"), Is.EqualTo(18));

        }
    }
}
