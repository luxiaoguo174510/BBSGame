using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class IntegralInfo//积分明细
    {
        public int IId { get; set; }//主键
        public int Score { get; set; }//分值
        public int UId { get; set; }//用户
        public string Remark { get; set; }//描述
    }
}
