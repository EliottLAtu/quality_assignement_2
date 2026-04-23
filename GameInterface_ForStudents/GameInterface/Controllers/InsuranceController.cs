using Microsoft.AspNetCore.Mvc;
using GameInterface.Services;
using Moq;
//using GameInterface.ServiceProject; if we wanted it to b seperate


namespace YourProject.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly ParkingService _insuranceService;

        public InsuranceController()
        {
            var mockDiscountService = new Mock<IDiscountService>();
            _insuranceService = new ParkingService(mockDiscountService.Object);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int hour, string vehicle)
        {
            double result = _insuranceService.CalcPremium(hour, vehicle);
            ViewBag.Premium = (result > 0) ? $"Insurance Cost: {result} Euro" : "Invalid level or mode";
            //if (result > 0)
            //    ViewBag.Premium = $"Insurance Cost: {result} Euro";
            //else
            //    ViewBag.Premium = "Invalid level or mode";

            return View("Index");
        }
    }
}
