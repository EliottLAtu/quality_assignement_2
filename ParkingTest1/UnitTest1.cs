using Moq;

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
            Assert.Equals(0, parkingService.CalculateFee(10, "hybrid"));

        }
        [Test]
        public void Teststandard1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(8, parkingService.CalculateFee(2, "standard"));

        }
        [Test]
        public void Teststandard2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(15, parkingService.CalculateFee(5, "standard"));

        }
        [Test]
        public void Teststandard3()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(0, parkingService.CalculateFee(0, "standard"));

        }
        [Test]
        public void Testelectric1()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(0, parkingService.CalculateFee(0, "electric"));

        }
        [Test]
        public void Testelectric2()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(6, parkingService.CalculateFee(2, "electric"));

        }
        [Test]
        public void Testelectric3()
        {
            var mockService = new Mock<IDiscountService>();
            mockService.SetReturnsDefault(0.5);
            ParkingService parkingService = new ParkingService(mockService.Object);
            Assert.Equals(18, parkingService.CalculateFee(9, "electric"));

        }
    }
}
