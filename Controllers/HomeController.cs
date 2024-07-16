using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag.Selamlama = saat > 12 ? "İyi günler" : "Günaydin";
            // ViewBag.Username = "Ece";
            int userCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydin";
            // ViewData["Username"] = "Ece";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 16, 30, 0),
                NumberOfPeople = userCount
            };


            return View(meetingInfo);
        }
    }
}