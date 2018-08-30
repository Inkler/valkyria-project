using Microsoft.AspNetCore.Mvc;
using Valkyria.Web.Models;

namespace Valkyria.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AutoValidateAntiforgeryToken]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult UserLogin(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return NotFound();
        }

        //[HttpPost]
        //public ActionResult UserLogin()
        //{
        //    return View();
        //}
    }
}
