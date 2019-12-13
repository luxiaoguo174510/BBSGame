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
        public ActionResult ShowPost(string Plate,string title)
        {
            ViewBags();
            List<PostsInfo> posts= bp.ShowPoste(title);
            return View(posts);
        }
        public ActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public void CreatePost(PostsInfo m,HttpPostedFileBase file,Pictures p)
        {
            string strpath = "/resource/images";
            string s = Path.GetFileName(file.FileName);
            if(!Directory.Exists(Server.MapPath("images")))
            {
                Directory.CreateDirectory(Server.MapPath("images"));
            }
            file.SaveAs(Server.MapPath(strpath + s));
            p.Picture = strpath + s;
            string outname = "";
            string name = Session["CreateUser"].ToString();
            m.CreateUser = name;
            int result = bp.AddPoste(m,out outname);
            int i = Convert.ToInt32(outname);
            if(result>0)
            {
                Response.Write("<script>alert('添加帖子成功！');location.href='/Posts/index'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！');location.href='/Posts/AddPost'</script>");
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

    }
}