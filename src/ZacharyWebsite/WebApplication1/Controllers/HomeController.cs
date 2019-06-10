using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeRenderingModel
            {
                Name = "Hello World!"
            };

            return this.View(model);
        }
    }
}