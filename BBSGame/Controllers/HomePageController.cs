using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ModelInfo;
using Newtonsoft.Json;

namespace BBSGame.Controllers
{
    public class HomePageController : Controller
    {
        BllOpt bp = new BllOpt();
        // GET: HomePage
        public ActionResult Index()
        {
            List<GameType> games = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(bp.GetGameType()));
            ViewBag.GameType = games;
            return View();
        }
    }
}