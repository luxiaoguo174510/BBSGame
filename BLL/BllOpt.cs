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
        public List<PostsInfo> ShowPoste(string title,int PageIndex,out string OutName)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@title", title);
            pairs.Add("@PageIndex", PageIndex);
            pairs.Add("@count", "");
            DataTable dt = db.ProcFY_GetTable("P_ShowPostsInfo", pairs,out OutName);
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
        /// <summary>
        /// 查询游戏分类
        /// </summary>
        /// <param name="GName"></param>
        /// <returns></returns>
        public DataTable GetGameType(string GName = "")
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GName", GName);
            return db.Proc_GetTable("P_GTS", pairs);
        }
        /// <summary>
        /// 查询所有板块
        /// </summary>
        /// <returns></returns>
        public DataTable GetPlate()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            DataTable data = db.Proc_GetTable("P_Plate", pairs);
            return data;
        }
        /// <summary>
        /// 查询所有版主
        /// </summary>
        /// <returns></returns>
        public DataTable GetPlateUser()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            DataTable data = db.Proc_GetTable("P_PlateUser", pairs);
            return data;
        }
        /// <summary>
        /// 获取图片
        /// </summary>
        /// <returns></returns>
        public DataTable GetPicture(string GName = "")
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@GName", GName);
            DataTable data = db.Proc_GetTable("P_Pic", pairs);
            return data;
        }
        public DataTable UserSelectOne(int UId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", UId);
            DataTable data = db.Proc_GetTable("P_UserSelectOne", pairs);
            return data;
        }
        public int UserUpd(UserInfo user)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", user.UId);
            pairs.Add("@NickName", user.NickName);
            pairs.Add("@HeadPic", user.HeadPic);
            pairs.Add("@Sex", user.Sex);
            pairs.Add("@Province", user.Province);
            int i = db.Proc_ExecuteNonQuery("P_UserUpd", pairs);
            return i;
        }
        public int GradeUp(int gral, int UId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@gral", gral);
            pairs.Add("@UId", UId);
            int i = db.Proc_ExecuteNonQuery("P_GradeUp", pairs);
            return i;
        }
        public int UpdPass(string NewPass, int UId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PassWord", NewPass);
            pairs.Add("@UId", UId);
            int i = db.Proc_ExecuteNonQuery("P_UpdPass", pairs);
            return i;
        }
        public ViewModel GetPostsInfo(int PId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", PId);
            DataTable data = db.Proc_GetTable("P_PostsInfo", pairs);
            ViewModel plate = JsonConvert.DeserializeObject<List<ViewModel>>(JsonConvert.SerializeObject(data)).First();
            return plate;
        }
        public List<ViewModel> GetComment(int PId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@PId", PId);
            DataTable data = db.Proc_GetTable("P_Comments", pairs);
            List<ViewModel> Comms = JsonConvert.DeserializeObject<List<ViewModel>>(JsonConvert.SerializeObject(data));
            return Comms;
        }
        public int AddComments(Comments comm)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", comm.UId);
            pairs.Add("@Content", comm.Content);
            pairs.Add("@PId", comm.PId);
            pairs.Add("@FId", comm.FId);
            int i = db.Proc_ExecuteNonQuery("P_AddComments", pairs);
            return i;
        }
        public int AddIntegral(IntegralInfo info)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId",info.UId);
            pairs.Add("@Score",info.Score);
            pairs.Add("@Remark",info.Remark);
            int i = db.Proc_ExecuteNonQuery("P_AddIntegral", pairs);
            return i;
        }
        public int SelBrowse(int UId, int PId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@UId", UId);
            pairs.Add("@PId", PId);
            int i = db.Proc_ExecuteNonQuery("P_SelBrowse", pairs);
            return  i;
        }
    }
}
