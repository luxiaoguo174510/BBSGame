using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class UserInfo
    {
        public string UId { get; set; }//主键        
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
