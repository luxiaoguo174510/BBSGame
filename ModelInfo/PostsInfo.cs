using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class PostsInfo//帖子表
    {
        public int PId         { get; set; }//主键
        public string PTitle      { get; set; }//标题
        public string PContent    { get; set; }//内容
        public DateTime CreateDate  { get; set; }//发布时间
        public string CreateUser  { get; set; }//发布人
        public string PState      { get; set; }//状态
        public int PageView    { get; set; }//浏览量
        public int PlateId     { get; set; }//板块
        public int Num { get; set; }//回复条数
    }
}
