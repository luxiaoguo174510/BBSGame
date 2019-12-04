using BLL;
using ModelInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBSGame.Controllers
{
    public class PostsController : Controller
    {
        BllOpt bl = new BllOpt();
        // GET: Posts
        public ActionResult Index(string name="")
        {
            return View(bl.ShowPoste(name));
        }
        //添加帖子
        public ActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public void AddPost(PostsInfo m,out string outname)
        {
            int result = bl.AddPoste(m,out outname);
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
                Response.Write("<script>alert('删除帖子成功！');location.href='/Posts/index'</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败！');location.href='/Posts/AddPost'</script>");
            }
        }

    }
}