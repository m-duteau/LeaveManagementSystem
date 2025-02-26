using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "[Name]",
                DateOfBirth = new DateTime(1990, 04, 01)
            };
            return View(data);
        }
    }
}
