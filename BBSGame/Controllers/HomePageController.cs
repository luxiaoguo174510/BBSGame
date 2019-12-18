using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ModelInfo;
using Newtonsoft.Json;

namespace BBSGame.Controllers
{
    [Serializable]
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
            Path.SaveAs(Server.MapPath("/Content/images/" + Path.FileName));
            PublicToolsLib.HelpImg.ImageHandlerHelper.PointThumbnail(Server.MapPath("/Content/images/" + Path.FileName), Server.MapPath("/Content/images/thum_" + Path.FileName), 498, 220, mode);
        }
        public void ViewBags(string GType = "")
        {
            List<GameType> game = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(bp.GetGameType()));
            List<GameType> games = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(bp.GetGameType(GType)));
            List<PlateInfo> plates = JsonConvert.DeserializeObject<List<PlateInfo>>(JsonConvert.SerializeObject(bp.GetPlate()));
            List<UserInfo> users = JsonConvert.DeserializeObject<List<UserInfo>>(JsonConvert.SerializeObject(bp.GetPlateUser()));
            List<Pictures> pictures = JsonConvert.DeserializeObject<List<Pictures>>(JsonConvert.SerializeObject(bp.GetPicture(GType)));
            ViewBag.GameType = games;
            ViewBag.GType = game;
            ViewBag.Plate = plates;
            ViewBag.count = (plates.Count / 2);
            ViewBag.User = users;
            ViewBag.Picture = pictures;
        }
        public ActionResult PersonalInformation(int UId= -1)
        {
            int i = 0;
            if (UId==-1)
            {
                i = int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString());
            }
            else
            {
                i = UId;
            }
            UserInfo user = JsonConvert.DeserializeObject<List<UserInfo>>(JsonConvert.SerializeObject(bp.UserSelectOne(i))).First();
            return View(user);
        }
        [HttpPost]
        public void PersonalInformation(UserInfo user, HttpPostedFileBase Path)
        {
            if (Path != null)
            {
                if (!Directory.Exists(Server.MapPath("/Image/")))
                {
                    Directory.CreateDirectory(Server.MapPath("/Image/"));
                }
                Path.SaveAs(Server.MapPath("/Image/" + Path.FileName));
                user.HeadPic = "/Image/" + Path.FileName;
            }
            user.UId= int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString());
            int i = bp.UserUpd(user);
            if (i > 0)
            {
                Response.Write("<script>alert('修改资料成功!');parent.layer.close(parent.layer.getFrameIndex(window.name));</script>");
            }
        }
        public void UpGrade(int Integral, int Grade)
        {
            if (Grade==100)
            {
                Response.Write("<script>alert('您已经是满级了，不能再升了!😱 ');location.href='/HomePage/PersonalInformation'</script>");
            }
            int gral = 1;
            for (int i = 0; i < Grade; i++)
            {
                gral = gral * 2;
            }
            if (Integral< gral)
            {
                Response.Write("<script>alert('升级失败，积分不足😭');location.href='/HomePage/PersonalInformation'</script>");
            }
            else
            {
                int i = int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString());
                int j= bp.GradeUp(gral, i);
                if (j>0)
                {
                    Response.Write("<script>alert('等级+1😁');location.href='/HomePage/PersonalInformation'</script>");
                }
            }
        }
        public ActionResult UpdPass()
        {
            return View();
        }
        [HttpPost]
        public void UpdPass(string Phone, string Pass, string NewPass)
        {
            List<UserInfo> list = JsonConvert.DeserializeObject<List<UserInfo>>(System.Web.HttpContext.Current.Session["User"].ToString());
            foreach (var item in list)
            {
                if (item.Phone != Phone)
                {
                    Response.Write("<script>alert('手机号不正确!');location.href='/HomePage/UpdPass'</script>");
                }
                else if (item.PassWord != Pass)
                {
                    Response.Write("<script>alert('旧密码有误!');location.href='/HomePage/UpdPass'</script>");
                }
                else if (item.PassWord == NewPass)
                {
                    Response.Write("<script>alert('新密码不能与旧密码一致!');location.href='/HomePage/UpdPass'</script>");
                }
                else
                {
                    int i = bp.UpdPass(NewPass, int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString()));
                    if (i > 0)
                    {
                        Response.Write("<script>alert('修改密码成功!');parent.layer.close(parent.layer.getFrameIndex(window.name));</script>");
                    }
                }
            }
        }
        public void AddIntegral(string Remark)
        {
            IntegralInfo info = new IntegralInfo
            {
                UId=int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString()),
                Score=10,
                Remark=Remark
            };
            bp.AddIntegral(info);
        }
    }
}