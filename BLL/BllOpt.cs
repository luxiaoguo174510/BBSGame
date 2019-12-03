using System;
using System.Collections.Generic;
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
            pairs.Add("@UId",com.UId);
            pairs.Add("@Content",com.Content);
            pairs.Add("@CreateDate",com.CreateDate);
            pairs.Add("@PId",com.PId);
            pairs.Add("@FId",com.FId);
            int i= db.Proc_ExecuteNonQuery("P_ComA", pairs);
            return i;
        }
        public int DeleteComment(int CId)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@IdName","CId");
            pairs.Add("@TableName", "Comments");
            pairs.Add("@Id",CId);
            int i = db.Proc_ExecuteNonQuery("P_Del", pairs);
            return i;
        }
        public List<Comments> ShowComment(int CId=0)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@CId", CId);
            return JsonConvert.DeserializeObject<List<Comments>>(JsonConvert.SerializeObject(db.Proc_GetTable("P_Show", pairs)));
        }
    }
}
