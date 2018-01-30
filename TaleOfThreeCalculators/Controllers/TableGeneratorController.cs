using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaleOfThreeCalculators.Controllers
{
    public class TableGeneratorController : Controller
    {
        // GET: TableGenerator
        public ActionResult Index()
        {
            return View();
        }
    }
}