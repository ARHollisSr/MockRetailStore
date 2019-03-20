using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreeHitCombo.Models;

namespace ThreeHitCombo.Controllers
{
    public class GamesController : Controller
    {
        // GET: Game/Random
        public ActionResult Random()
        {
            var game = new Game() {Name = "Fortnite!"};
            return View(game);

        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");

        }
    }
}