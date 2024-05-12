using Microsoft.AspNetCore.Mvc;
using OpdrachtASP.NETCore.Models;

namespace OpdrachtASP.NETCore.Controllers 
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Info()
            {
                Name = "",
                Email = "",
                Message = ""

            });
        }

        [HttpGet]
        public IActionResult Update() => View(new Info());


        [HttpPost]
        public IActionResult Update(Info info)
        {
            if (ModelState.IsValid is false)
                return View(info);

            return View("Index", info);
        }
    }
}
