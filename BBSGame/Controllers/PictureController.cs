using BLL;
using ModelInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBSGame.Controllers
{
    public class PictureController : Controller
    {
        
        BllOpt bl = new BllOpt();
        // GET: Picture
        public ActionResult Index()
        {
            return View(bl.ShowPicture());
        }
        //图片上传
        public ActionResult AddPricture()
        {
            return View();
        }
        [HttpPost]
        public void AddPricture(Pictures m,HttpPostedFileBase file)
        {
            string filename = Path.GetFileName(file.FileName);
            if(!Directory.Exists(Server.MapPath("/pastpicture/image/")))
            {
                Directory.CreateDirectory(Server.MapPath("/pastpicture/image/"));
            }
            file.SaveAs(Server.MapPath("/pastpicture/image/" + filename));
            m.Picture = "/pastpicture/image/" + filename;
            int result = bl.AddPicture(m);
            if(result>0)
            {
                Response.Write("<script>alert('添加图片成功！');location.href='/Picture/index'</script>");
            }
        }


        /// <summary>
        /// 多图上传
        /// </summary>
        /// <returns></returns>
        
        public ActionResult ProcessRequest()
        {
            return View();
        }
        [HttpPost]
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            var num = context.Request.Files.Count;

            for (int i = 0; i < num; i++)
            {
                HttpPostedFile file = context.Request.Files[i];
                //上传的文件保存到目录(为了保证文件名不重复，加个Guid)
                string path = "/Upload/" + Guid.NewGuid().ToString() + file.FileName;
                file.SaveAs(context.Request.MapPath(path));//必须得是相对路径

            }
            context.Response.Write("上传成功");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}