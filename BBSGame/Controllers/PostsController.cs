using BLL;
using ModelInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BBSGame.Controllers
{
    public class PostsController : Controller
    {
        BllOpt bp = new BllOpt();
        HomePageController Home = new HomePageController();
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
        //显示帖子
        public ActionResult ShowPost(string title = "", int PlateId = 0,int PageIndex=1)
        {
            string OutName = "";
            ViewBags();
            System.Web.HttpContext.Current.Session["PlateId"] = PlateId;
            List<PostsInfo> posts = bp.ShowPoste(title,PageIndex,out OutName);
            int count = int.Parse(OutName.ToString());
            int pagecount = (int)Math.Ceiling((decimal)count / 20);
            ViewBag.Pre = PageIndex <= 1 ? 1 : PageIndex - 1;
            ViewBag.Next = PageIndex >= pagecount ? pagecount : PageIndex + 1;
            return View(posts);
        }
        public ActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public void CreatePost(PostsInfo m)
        {
            if (!Directory.Exists(Server.MapPath("/Image/")))
            {
                Directory.CreateDirectory(Server.MapPath("/Image/"));
            }
            string outname = "";
            int result = bp.AddPoste(m, out outname);
            if (result > 0)
            {
                int j = 0;
                int i = Convert.ToInt32(outname);
                HttpFileCollection httpFile = System.Web.HttpContext.Current.Request.Files;
                for (int y = 0; y < httpFile.Count; y++)
                {
                    HttpPostedFile file = httpFile[y];
                    file.SaveAs(Server.MapPath("/Image/" + file.FileName));
                    Pictures pictures = new Pictures
                    {
                        PostId = i,
                        Picture = "/Image/" + file.FileName
                    };
                    j += bp.AddPicture(pictures);
                }
                if (j > 0)
                {
                    Home.AddIntegral(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + "发帖成功!");
                    Response.Write("<script>alert('发帖成功！');parent.layer.close(parent.layer.getFrameIndex(window.name));</script>");
                }
                else
                {
                    Response.Write("<script>alert('发帖失败！');parent.layer.close(parent.layer.getFrameIndex(window.name));</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('发帖失败！');parent.layer.close(parent.layer.getFrameIndex(window.name));</script>");
            }
        }
        public void DelPost(string IdName, string TableName, int Id)
        {
            int result = bp.DelPoste(IdName, TableName, Id);
            if (result > 0)
            {
                Response.Write("<script>alert('删除帖子成功！');location.href='/Posts/AddPost'</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败！');location.href='/Posts/index'</script>");
            }
        }
        public ActionResult PostsInfo(int PId)
        {
            try
            {
                int UId = int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString());
                int i = bp.SelBrowse(UId, PId);
                if (i > 0||i==-1)
                {
                    ViewModel plate = bp.GetPostsInfo(PId);
                    ViewBag.Comms = bp.GetComment(PId);
                    ViewBags();
                    return View(plate);
                }
                return View();
            }
            catch (Exception)
            {
                ViewModel plate = bp.GetPostsInfo(PId);
                ViewBag.Comms = bp.GetComment(PId);
                ViewBags();
                return View(plate);
            }
        }
        public ActionResult AddComments(string Nick,int PId,int CId)
        {
            ViewBag.Nick = Nick;
            ViewBag.PId = PId;
            ViewBag.CId = CId;
            return View();
        } 
        [HttpPost]
        public void AddComments(Comments comm)
        {
            try
            {
                comm.UId = int.Parse(System.Web.HttpContext.Current.Session["UId"].ToString());
                int i = bp.AddComments(comm);
                if (i > 0)
                {
                    Home.AddIntegral(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + "评论成功!");
                    Response.Write($"<script>alert('评论成功!');location.href='/Posts/PostsInfo/?PId={comm.PId}'</script>");
                }
                else
                {
                    Response.Write($"<script>alert('评论失败!');location.href='/Posts/PostsInfo/?PId={comm.PId}'</script>");
                }
            }
            catch (Exception)
            {
                Response.Write($"<script>alert('您还未登录!');location.href='/LoginHtml/index.html'</script>");
            }
            
        }
        
    }
}