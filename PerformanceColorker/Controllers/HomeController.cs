using System;
using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;

namespace PerformanceColorker.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Performance()
        {
            ViewBag.Message = "Performance checker";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpGet]
        public double GetValue(string guid)
        {
            Random random = new Random();
            int milliseconds = random.Next(500, 1500);
            Thread.Sleep(milliseconds);

            return (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }
        
        [HttpPost]
        public double PostValue(string guid)
        {
            Random random = new Random();
            int milliseconds = random.Next(500, 1500);
            Thread.Sleep(milliseconds);

            return (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }
    }
}