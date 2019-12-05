using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class Comments//评论
    {
        public int CId{ get; set; }//主键
        public int UId{ get; set; }//用户
        public string Content{ get; set; }//内容
        public DateTime CreateDate { get; set; }//发表时间
        public int PId{ get; set; }//帖子
        public int FId { get; set; }//父级Id
    }
}
