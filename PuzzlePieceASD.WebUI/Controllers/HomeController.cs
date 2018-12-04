using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuzzlePieceASD.Domain.DAL;

namespace PuzzlePieceASD.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //GET: User Database
        private UserContext db = new UserContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db);
        }
    }
}