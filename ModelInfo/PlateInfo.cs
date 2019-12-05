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
        public int PName { get; set; }//板块名称
        public int GId { get; set; }//游戏分类
        public int PImage { get; set; }//板块图
        public int Url { get; set; }//路径
        public int PState { get; set; }//状态
        public int FLag { get; set; }//标识列
    }
}
