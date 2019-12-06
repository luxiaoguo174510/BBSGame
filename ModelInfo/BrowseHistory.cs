using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class BrowseHistory//浏览记录
    {
        public int BId { get; set; }//主键
        public int UId { get; set; }//用户
        public int PId { get; set; }//帖子
    }
}
