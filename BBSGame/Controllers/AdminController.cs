using ModelInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace BBSGame.Controllers
{
    public class AdminController : Controller
    {
        ApiHelper api = new ApiHelper();
        // GET: Admin

        #region 游戏分类
        //游戏分类显示
        public ActionResult Index()
        {
            string url = "http://localhost:8086/BBS/ShowType";
            return View(api.GetApi<GameType>(url));
        }

        //游戏分类添加
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public void Add(GameType game)
        {
            string url = "http://localhost:8086/BBS/TypeAdd";

            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(game)));
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='/Admin/Index'</script>");
            }
            else
            {

                Response.Write("<script>alert('添加失败');location.href='/Admin/Add'</script>");
            }
        }

        //游戏分类删除

        public void Delete(int GId)
        {
            string url = "http://localhost:8086/BBS/DelType";
            string s = api.PostApi(url, JsonConvert.SerializeObject(GId));
            int i = Convert.ToInt32(s);
            if (i > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Admin/Index'</script>");
            }
            else
            {

                Response.Write("<script>alert('删除失败')</script>");
            }
        }
        //游戏分类修改
        public ActionResult Upt(int id)
        {
            string url = "http://localhost:8086/BBS/OneType/?id=" + id;
            return View(api.GetApi<GameType>(url).First());
        }

        [HttpPost]
        public void Upt(GameType game)
        {
            string url = "http://localhost:8086/BBS/UptType";
            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(game)));
            if (i > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='/Admin/Index'</script>");
            }
            else
            {

                Response.Write("<script>alert('修改失败')</script>");
            }
        }
        #endregion

        #region 板块

        //板块显示
        public ActionResult PlateIndex()
        {
            string url = "http://localhost:8086/BBS/ShowPlate";
            return View(api.GetApi<PlateInfo>(url));
        }
        //板块添加
        public ActionResult PlateAdd()
        {
            ViewBag.listG = new SelectList(SelGameType(), "GId", "GName");
            ViewBag.listU = new SelectList(SelUser(), "UId", "NickName");
            return View();
        }
        [HttpPost]
        public void PlateAdd(PlateInfo info,HttpPostedFileBase Path)
        {
            string url = "http://localhost:8086/BBS/AddPlate";
            if (Path != null)
            {
                if (!Directory.Exists(Server.MapPath("/Image/")))
                {
                    Directory.CreateDirectory(Server.MapPath("/Image/"));
                }
                Path.SaveAs(Server.MapPath("/Image/" + Path.FileName));
                info.PImage = "/Image/" + Path.FileName;
            }
            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(info)));
            if (i > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='/Admin/PlateIndex'</script>");
            }
            else
            {

                Response.Write("<script>alert('添加失败');location.href='/Admin/Add'</script>");
            }
        }

        //板块删除

        public void PlateDelete(int GId)
        {
            string url = "http://localhost:8086/BBS/DelPlate";
            string s = api.PostApi(url, JsonConvert.SerializeObject(GId));
            int i = Convert.ToInt32(s);
            if (i > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Admin/PlateIndex'</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
        //板块修改
        public ActionResult PlateUpt(int cid)
        {
            string url = "http://localhost:8086/BBS/OnePlate/?cid=" + cid;
            return View(api.GetApi<PlateInfo>(url).First());
        }

        [HttpPost]
        public void PlateUpt(PlateInfo game)
        {
            string url = "http://localhost:8086/BBS/UptPlate";
            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(game)));
            if (i > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='/Admin/PlateIndex'</script>");
            }
            else
            {

                Response.Write("<script>alert('修改失败')</script>");
            }
        }
        //游戏分类
        public List<GameType> SelGameType()
        {
            string url = "http://localhost:8086/BBS/SelGameType";
            return api.GetApi<GameType>(url);
        }
        //所有用户
        public List<UserInfo> SelUser()
        {
            string url = "http://localhost:8086/BBS/SelUser";
            return api.GetApi<UserInfo>(url);
        }

        #endregion

        #region 帖子禁用启用
        //帖子列表
        public ActionResult IndexPost()
        {
            string url = "http://localhost:8086/BBS/ShowPost";
            return View(api.GetApi<PostsInfo>(url));
        }
        //帖子通过/不通过
        public void U1(PostsInfo p)
        {
            string url = "http://localhost:8086/BBS/PostsPass";
            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(p)));
            if (i > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='/Admin/IndexPost'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='/Admin/IndexPost'</script>");
            }
        }

        #endregion

        #region 用户禁用启用
        //用户列表
        public ActionResult UserShow()
        {
            string url = "http://localhost:8086/BBS/UserShow";
            return View(api.GetApi<UserInfo>(url));
        }
        //用户通过/不通过
        public int T1(UserInfo p)
        {
            string url = "http://localhost:8086/BBS/UserStart";
            int i = Convert.ToInt32(api.PostApi(url, JsonConvert.SerializeObject(p)));
            if (i > 0)
            {
                return i;
            }
            else
            {

                return i;
            }
        }

        #endregion

        #region 评价管理
        public ActionResult CommIndex()
        {
            string url = "http://localhost:8086/BBS/CommShow";
            return View(api.GetApi<Comments>(url));
        }

        //评价删除

        public void CommDelete(int CId)
        {
            string url = "http://localhost:8086/BBS/DelCom";
            string s = api.PostApi(url, JsonConvert.SerializeObject(CId));
            int i = Convert.ToInt32(s);
            if (i > 0)
            {
                Response.Write("<script>alert('删除成功');location.href='/Admin/CommIndex'</script>");
            }
            else
            {

                Response.Write("<script>alert('删除失败')</script>");
            }
        }

        #endregion

    }
    public class ApiHelper
    {
        public string PostApi(string url, string str)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(str);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.PostAsync(url, content).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            return result;
        }
        public List<T> GetApi<T>(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = client.GetAsync(url).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<T> list = JsonConvert.DeserializeObject<List<T>>(result);
            return list;
        }
    }
}