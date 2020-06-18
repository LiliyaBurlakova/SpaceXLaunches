using Microsoft.AspNetCore.Mvc;

namespace CSharpSpaceXApp.Controllers
{
    /// <summary>
    /// For customer error page - APIError
    /// </summary>

    public class ErrorController : Controller
    {

        public IActionResult APIError()
        {

            return View();
        }
    }
}
