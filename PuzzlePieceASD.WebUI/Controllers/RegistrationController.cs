using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuzzlePieceASD.Domain.DAL;

namespace PuzzlePieceASD.WebUI.Controllers
{
    public class RegistrationController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
    }
}