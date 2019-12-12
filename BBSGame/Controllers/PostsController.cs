﻿using BLL;
using ModelInfo;
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
        BllOpt bl = new BllOpt();
        HomePageController Home = new HomePageController();
        // GET: Posts
        public ActionResult Index(string name="")
        {
            Home.ViewBags();
            return View(bl.ShowPoste(name));
        }
        //添加帖子
        public ActionResult AddPost()
        {
            Home.ViewBags();
            return View();
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
            int result = bl.AddPoste(m,out outname);
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
            int result = bl.DelPoste(IdName, TableName, Id);
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