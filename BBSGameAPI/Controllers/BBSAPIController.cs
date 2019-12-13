using ModelInfo;
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
        [HttpGet]
        public int UserStart(int UId, string State)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", UId);
            pairs.Add("@State", State);
            int i = db.Proc_ExecuteNonQuery("P_Users", pairs);
            return i;
        }
        //删除评论
        [Route("DelCom")]
        [HttpGet]
        public int DelCom(int CId)
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
        public int UptType(GameType g)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GId", g.GId);
            pairs.Add("@GName", g.GName);
            pairs.Add("@GState", g.GState);
            return db.Proc_ExecuteNonQuery("P_TypeUpt", pairs);
        }

        //游戏分类删除
        [Route("DelType")]
        [HttpGet]
        public int DelType(int GId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GId", GId);
            return db.Proc_ExecuteNonQuery("P_Deltype", pairs);
        }

        //游戏分类显示
        [Route("ShowType")]
        [HttpGet]
        public DataTable ShowType()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_GetTable("P_ShowType", pairs);
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
            return db.Proc_ExecuteNonQuery("P_AddPlate", pairs);
        }

        //修改版块
        [Route("UptPlate")]
        [HttpPost]
        public int UptPlate(PlateInfo p)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", p.PId);
            pairs.Add("@PName", p.PName);
            pairs.Add("@GId", p.GId);
            pairs.Add("@PImage", p.PImage);
            pairs.Add("@PState", p.PState);
            return db.Proc_ExecuteNonQuery("P_UptPlate", pairs);
        }

        //删除版块
        [Route("DelPlate")]
        [HttpGet]
        public int DelPlate(int PId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", PId);
            return db.Proc_ExecuteNonQuery("P_DelPlate", pairs);
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
        [HttpGet]
        public int PostsPass(int PId, string PState)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", PId);
            pairs.Add("@PState", PState);
            return db.Proc_ExecuteNonQuery("P_Pass", pairs);
        }
    }
}
