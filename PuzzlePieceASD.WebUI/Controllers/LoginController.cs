using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuzzlePieceASD.Domain.DAL;
using PuzzlePieceASD.WebUI.ViewModels;

namespace PuzzlePieceASD.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private UserContext db = new UserContext();

        //GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (db)
                {
                    var user = db.Users.Where(a => a.UserName.Equals(model.UserName) &&
                                a.Password.Equals(model.Password)).FirstOrDefault();

                    if (user.UserName != null && user.Password != null)
                    {
                        return RedirectToAction("Please Login");
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult CheckPassword(string UserName)
        {

            return View(db);
        }
    }
}