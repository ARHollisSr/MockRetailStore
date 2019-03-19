using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreeHitCombo.Models;

namespace ThreeHitCombo.Controllers
{
    public class GameController : Controller
    {
        // GET: Game/Random
        public ActionResult Random()
        {
            var game = new Game() {Name = "Fortnite!"};
            return View(game);
        }
    }
}