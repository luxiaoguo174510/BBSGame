using ModelInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BBSGameAPI.Controllers
{
    [RoutePrefix("BBS")]
    public class BBSAPIController : ApiController
    {
        PublicToolsLib.HelpDb.DbHelper db = new PublicToolsLib.HelpDb.DbHelper();

        //用户启用/禁用
        [Route("UserStart")]
        [HttpPost]
        public IHttpActionResult UserStart(UserInfo u)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", u.UId);
            pairs.Add("@State", u.UState);
            int i = db.Proc_ExecuteNonQuery("P_Users", pairs);
            return Json(i);
        }
        //用户列表
        [Route("UserShow")]
        [HttpGet]
        public DataTable UserShow()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("P_user", pairs);
        }
        //评价列表
        [Route("CommShow")]
        [HttpGet]
        public DataTable CommShow()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("P_Commshow", pairs);
        }
        //删除评论
        [Route("DelCom")]
        [HttpPost]
        public int DelCom([FromBody]int CId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@CId", CId);
            return db.Proc_ExecuteNonQuery("P_delCom", pairs);
        }
        //游戏分类添加
        [Route("TypeAdd")]
        [HttpPost]
        public int TypeAdd(GameType g)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GName", g.GName);
            pairs.Add("@GState", g.GState);
            return db.Proc_ExecuteNonQuery("P_TypeAdd", pairs);
        }
        //游戏分类修改
        [Route("UptType")]
        [HttpPost]
        public int UptType([FromBody]GameType g)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GId", g.GId);
            pairs.Add("@GName", g.GName);
            pairs.Add("@GState", g.GState);
            return db.Proc_ExecuteNonQuery("P_TypeUpt", pairs);
        }

        //游戏分类删除
        [Route("DelType")]
        [HttpPost]
        public IHttpActionResult DelType([FromBody]int GId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GId", GId);
            return Json(db.Proc_ExecuteNonQuery("P_Deltype", pairs));
        }

        //游戏分类显示
        [Route("ShowType")]
        [HttpGet]
        public DataTable ShowType()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("P_ShowType", pairs);
        }
        //游戏分类反填
        [Route("OneType")]
        [HttpGet]
        public DataTable OneType(int id)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@id", id);
            return db.Proc_GetTable("p_OneType", pairs);
        }

        //添加版块
        [Route("AddPlate")]
        [HttpPost]
        public int AddPlate(PlateInfo p)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PName", p.PName);
            pairs.Add("@GId", p.GId);
            pairs.Add("@PImage", p.PImage);
            pairs.Add("@PState", p.PState);
            pairs.Add("@UID", p.UId);
            return db.Proc_ExecuteNonQuery("P_AddPlate", pairs);
        }
        //反填板块
        [Route("OnePlate")]
        [HttpGet]
        public DataTable OnePlate(int cid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@id", cid);
            return db.Proc_GetTable("p_OnePlate", pairs);
        }

        //修改版块
        [Route("UptPlate")]
        [HttpPost]
        public int UptPlate([FromBody]PlateInfo p)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", p.PId);
            pairs.Add("@PName", p.PName);
            pairs.Add("@GId", p.GId);
            pairs.Add("@PImage", p.PImage);
            pairs.Add("@PState", p.PState);
            pairs.Add("@UID", p.UId);
            return db.Proc_ExecuteNonQuery("P_UptPlate", pairs);
        }

        //删除版块
        [Route("DelPlate")]
        [HttpPost]
        public IHttpActionResult DelPlate([FromBody]int PId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", PId);
            return Json(db.Proc_ExecuteNonQuery("P_DelPlate", pairs));
        }

        //显示版块
        [Route("ShowPlate")]
        [HttpGet]
        public DataTable ShowPlate()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("P_SelPlate", pairs);
        }

        //帖子通过/不通过
        [Route("PostsPass")]
        [HttpPost]
        public IHttpActionResult PostsPass(PlateInfo p)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", p.PId);
            pairs.Add("@PState", p.PState);
            return Json(db.Proc_ExecuteNonQuery("P_Pass", pairs));
        }

        //帖子显示列表
        [Route("ShowPost")]
        [HttpGet]
        public DataTable ShowPost()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("p_post", pairs);
        }
        [Route("SelGameType")]
        [HttpGet]
        public IHttpActionResult SelGameType()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            List<GameType> list = JsonConvert.DeserializeObject<List<GameType>>(JsonConvert.SerializeObject(db.Proc_GetTable("P_SelGameType", pairs)));
            return Json(list);
        }
        [Route("SelUser")]
        [HttpGet]
        public IHttpActionResult SelUser()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            List<UserInfo> list = JsonConvert.DeserializeObject<List<UserInfo>>(JsonConvert.SerializeObject(db.Proc_GetTable("P_SelUser", pairs)));
            return Json(list);
        }

    }
}

