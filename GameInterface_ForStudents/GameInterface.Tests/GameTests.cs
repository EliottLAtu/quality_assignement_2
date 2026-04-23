using GameInterface;
using NUnit.Framework;
using Moq;
namespace GameInterface.Tests
{
    [TestFixture]

    // this is my test class it will contain my unit tests
    // you will need to mock the discount service in your tests
    // you will then take out the mocking for the final system test with selenium
    public class GameTests

    {
        [Test]
        public void Test1()

        {
       

            // Arrange
            var mockDiscountService = new Mock<Services.IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0.9);
            var myIS = new Services.InsuranceService(mockDiscountService.Object);

            //Services.InsuranceService myIS = new Services.InsuranceService(mockDiscountService.Object);
            //act
            var answer = myIS.CalcPremium(55, "Casual");
            //assert
            TestContext.WriteLine(answer);

            Assert.That(answer, Is.EqualTo(3.15).Within(.01));

        }
    }
}
