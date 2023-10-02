using Dojo_Survey_with_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey_with_Model.Controllers
{
    public class DojoSurvey : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(Survey survey)
        {
            return View(survey);
        }
    }
}
