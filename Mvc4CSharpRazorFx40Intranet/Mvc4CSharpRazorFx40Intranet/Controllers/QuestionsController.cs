using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4Testpad.Models;

namespace Mvc4Testpad.Controllers
{
    public class QuestionsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Questions
                            {
                                Question1 = "Do you have?", 
                                Question1Validation = "Yes|No|Don't Know"
                            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Questions model)
        {
            return View(model);
        }

    }
}
