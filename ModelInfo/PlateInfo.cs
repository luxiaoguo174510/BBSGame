using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class PlateInfo//板块
    {
        public int PId { get; set; }//主键
        public string PName { get; set; }//板块名称
        public int GId { get; set; }//游戏分类
        public string PImage { get; set; }//板块图
        public string Url { get; set; }//路径
        public string PState { get; set; }//状态
        public int FLag { get; set; }//帖子数
        public int RowId { get; set; }//标识列
        public int UId { get; set; }//版主
    }
}
