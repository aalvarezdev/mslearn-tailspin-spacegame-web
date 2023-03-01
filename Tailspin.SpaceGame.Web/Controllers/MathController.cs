using Microsoft.AspNetCore.Mvc;
using Tailspin.SpaceGame.Web.Application;

namespace Tailspin.SpaceGame.Web.Controllers
{
    public class MathController : Controller
    {
        IMathModels _mathModel;

        public MathController(IMathModels mathModel)
        {
            _mathModel = mathModel;
        }

        public IActionResult Index()
        {
            var suma = _mathModel.Suma(5, 5);
            ViewBag.Suma = suma;
            return View();
        }
    }
}
