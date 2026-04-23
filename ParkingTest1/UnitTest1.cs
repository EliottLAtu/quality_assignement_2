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

        //whitebox Testing : 


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
        // black box testing : 
        [Test]
        public void BlackTestpass1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(2, "standard"), Is.EqualTo(8));

        }
        [Test]
        public void BlackTestboundaries1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(0, "electric"), Is.EqualTo(0));

        }
        [Test]
        public void BlackTestBoundaries2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(1, "standard"), Is.EqualTo(4));

        }
        [Test]
        public void BlackTestBoundaries3()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(3, "standard"), Is.EqualTo(12));

        }
        [Test]
        public void BlackTestBoundaries4()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(1, "electric"), Is.EqualTo(3));

        }
        [Test]
        public void BlackTestBoundaries5()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(4, "standard"), Is.EqualTo(12));

        }
        [Test]
        public void BlakcTestBoundaries6()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(5, "electric"), Is.EqualTo(15));

        }
        [Test]
        public void BlackTestBoundaries7()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(6, "electric"), Is.EqualTo(12));

        }
        [Test]
        public void BlackTestBoundaries8()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(9, "standard"), Is.EqualTo(27));

        }
        [Test]
        public void BlackTestBoundaries9()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.That(parkingService.CalculateFee(10, "electric"), Is.EqualTo(10));

        }
        [Test]
        public void BlackTestFail1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Throws<ArgumentException>(delegate { parkingService.CalculateFee(2, "invalid"); });
        }
        [Test]
        public void BlackTestFail2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Throws<ArgumentException>(delegate { parkingService.CalculateFee(-2, "standard"); });
        }
    }
}
