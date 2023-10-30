using CalculadoraMedia.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMedia.Controllers
{
    public class MediaController : Controller
    {
        public IActionResult Result(MediaDto model)
        {
            return View(model);
        }

        public IActionResult Values()
        {
            return View(new MediaDto());
        }

        [HttpPost]
        public IActionResult CalcularMedia(MediaDto model)
        {
            model.Result = (model.Number1 + model.Number2) / 2;
            return View("Result", model);
        }
    }
}
