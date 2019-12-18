using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class GameType//游戏分类
    {
        public int GId { get; set; }//主键
        public string GName { get; set; }//类名
        public int GState { get; set; }//状态
    }
}
