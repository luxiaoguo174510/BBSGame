using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class ViewModel
    {
        public int BId { get; set; }//主键
        public int UId { get; set; }//用户
        public int PId { get; set; }//帖子
        public int CId { get; set; }//主键
        public string Content { get; set; }//内容
        public DateTime CreateDate { get; set; }//发表时间
        public int FId { get; set; }//父级Id
        public int GId { get; set; }//主键
        public string GName { get; set; }//类名
        public string Url { get; set; }//路径
        public string GState { get; set; }//状态
        public int IId { get; set; }//主键
        public int Score { get; set; }//分值
        public string Remark { get; set; }//描述
        public int PostId { get; set; }//帖子
        public string Picture { get; set; }//图片路径
        public string PName { get; set; }//板块名称
        public string PImage { get; set; }//板块图
        public string PState { get; set; }//状态
        public int FLag { get; set; }//帖子数
        public int RowId { get; set; }//标识列
        public string PTitle { get; set; }//标题
        public string PContent { get; set; }//内容
        public string CreateUser { get; set; }//发布人
        public int PageView { get; set; }//浏览量
        public int PlateId { get; set; }//板块
        public string UName { get; set; }//用户名      
        public string PassWord { get; set; }//密码   
        public string NickName { get; set; }//昵称   
        public string HeadPic { get; set; }//头像路径    
        public string Sex { get; set; }//性别        
        public string Birthday { get; set; }//生日   
        public string Integral { get; set; }//积分   
        public string Grade { get; set; }//等级      
        public string Province { get; set; }//居住省   
        public string Phone { get; set; }//手机号      
        public string UState { get; set; }//状态   
    }
}
