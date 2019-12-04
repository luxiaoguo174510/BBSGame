using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class Pictures//图片
    {
        public int PId { get; set; }//主键
        public int PostId { get; set; }//帖子
        public string Picture { get; set; }//图片路径
    }
}
