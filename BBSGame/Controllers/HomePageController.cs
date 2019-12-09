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
        public ActionResult Index(string GType = "")
        {
            ViewBags(GType);
            return View();
        }
        public void GetFile(HttpPostedFileBase Path)
        {
            string mode = "Cut";
            Path.SaveAs(Server.MapPath("/Content/images/" +Path.FileName));
            PublicToolsLib.HelpImg.ImageHandlerHelper.PointThumbnail(Server.MapPath("/Content/images/" + Path.FileName), Server.MapPath("/Content/images/thum_" + Path.FileName), 498, 220, mode);
        }
        public void ViewBags(string GType="")
        {
            List<GameType> game = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(bp.GetGameType()));
            List<GameType> games = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(bp.GetGameType(GType)));
            List<PlateInfo> plates = JsonConvert.DeserializeObject<List<PlateInfo>>(JsonConvert.SerializeObject(bp.GetPlate()));
            List<UserInfo> users = JsonConvert.DeserializeObject<List<UserInfo>>(JsonConvert.SerializeObject(bp.GetPlateUser()));
            List<Pictures> pictures = JsonConvert.DeserializeObject<List<Pictures>>(JsonConvert.SerializeObject(bp.GetPicture(GType)));
            ViewBag.GameType = games;
            ViewBag.GType = game;
            ViewBag.Plate = plates;
            ViewBag.count = (plates.Count/2);
            ViewBag.User = users;
            ViewBag.Picture = pictures;
        }
        public ActionResult PersonalInformation(int UId)
        {
            return View();
        }
    }
}