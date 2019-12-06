using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelInfo;
using Newtonsoft.Json;

namespace BLL
{
    public class BllOpt
    {
        PublicToolsLib.HelpDb.DbHelper db = new PublicToolsLib.HelpDb.DbHelper();
        public int ReplyToComment(Comments com)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", com.UId);
            pairs.Add("@Content", com.Content);
            pairs.Add("@CreateDate", com.CreateDate);
            pairs.Add("@PId", com.PId);
            pairs.Add("@FId", com.FId);
            int i = db.Proc_ExecuteNonQuery("P_ComA", pairs);
            return i;
        }
        public int DeleteComment(int CId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@IdName", "CId");
            pairs.Add("@TableName", "Comments");
            pairs.Add("@Id", CId);
            int i = db.Proc_ExecuteNonQuery("P_Del", pairs);
            return i;
        }
        public List<Comments> ShowComment(int CId = 0)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@CId", CId);
            return JsonConvert.DeserializeObject<List<Comments>>(JsonConvert.SerializeObject(db.Proc_GetTable("P_Show", pairs)));
        }
        //添加帖子（发帖）
        public int AddPoste(PostsInfo m, out string outname)//out输出参数
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PTitle", m.PTitle);
            pairs.Add("@PContent", m.PContent);
            pairs.Add("@CreateDate", System.DateTime.Now);
            pairs.Add("@CreateUser", m.CreateUser);
            pairs.Add("@PlateId", m.PlateId);
            pairs.Add("@count", "");
            return db.Proc_ExecuteNonQuery("P_AddPostsInfo", pairs, out outname);
        }
        //显示帖子（模糊查询）
        public List<PostsInfo> ShowPoste(string name)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@title", name);
            DataTable dt = db.Proc_GetTable("P_ShowPostsInfo", pairs);
            List<PostsInfo> list = JsonConvert.DeserializeObject<List<PostsInfo>>(JsonConvert.SerializeObject(dt));
            return list;
        }
        //删除帖子
        public int DelPoste(string IdName, string TableName, int Id)//（ID名称，表名称，要删除的ID）
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@IdName", IdName);
            pairs.Add("@TableName", TableName);
            pairs.Add("@Id", Id);
            return db.Proc_ExecuteNonQuery("P_Del", pairs);
        }
        //添加图片
        public int AddPicture(Pictures m)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PostId", m.PostId);
            pairs.Add("@Pricture", m.Picture);
            return db.Proc_ExecuteNonQuery("P_AddPicture", pairs);
        }
        public DataTable GetGameType(string GName="")
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GName",GName);
            return db.Proc_GetTable("P_GTS", pairs);
        }
    }
}
