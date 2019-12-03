using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    class UserInfo
    {
        public string UId { get; set; }             //int identity              not null,
        public string UName { get; set; }             //varchar(50)                    null,
        public string PassWord { get; set; }             //varchar(255)                   null,
        public string NickName { get; set; }             //varchar(50)                    null,   昵称
        public string HeadPic { get; set; }             //varchar(255)                   null,      头像
        public string Sex { get; set; }             //varchar(2)                     null,
        public string Birthday { get; set; }             //datetime                       null,
        public string Integral { get; set; }             //int                            null,     积分
        public string Grade { get; set; }             //int                            null,        等级
        public string Province { get; set; }             //varchar(50)                    null,     省份
        public string Phone { get; set; }             //varchar(11)                    null,
        public string UState { get; set; }             //varchar(50)                    null,
    }
}
