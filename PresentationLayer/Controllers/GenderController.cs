using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;

namespace PresentationLayer.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            GenderBusiness gb = new GenderBusiness();
            var gender = gb.GetAllGenders();
            return View(gender);
        }
    }
}