using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data;
using System.Data.SqlClient;
using ModelInfo;
using BBSGame.LoginHtml;

namespace BBSGame.Controllers
{
    public class LoginController : Controller
    {
        HomePageController Home = new HomePageController();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 短信验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string GetPhoneYanZheng(string phone)
        {
            DuanXinYanZheng m = new DuanXinYanZheng();
            return m.Main(phone);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public int ZhuCe(UserInfo m)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=10.1.152.12;Initial Catalog=BBSGame;User ID=sa;pwd=1234"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand($"insert into UserInfo values('{m.UName}','{m.PassWord}','{m.NickName}','{m.HeadPic}','{m.Sex}','{m.Birthday}','{m.Integral}','{m.Grade}','{m.Province}','{m.Phone}','{m.UState}')", conn);
                int i = comm.ExecuteNonQuery();
                conn.Close();
                return i;
            }

        }

        /// <summary>
        /// 登录验证
        /// 在图片验证后验证
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public int LoginUser(string UName,string PassWord,string Phone)
        {
            using (SqlConnection conn=new SqlConnection("Data Source=DESKTOP-G7L4DJ9;Initial Catalog=BBSGame;User ID=sa;pwd=1234"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand($"select * from UserInfo where UName like '{UName}' and PassWord like '{PassWord}' and Phone like '{Phone}'",conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(comm);
                DataTable DT = new DataTable();
                sqlData.Fill(DT);
                int i = (int)DT.Rows.Count;
                if (i>0)
                {
                    Session["NickName"] = DT.Rows[0]["NickName"];
                    Session["UId"] = DT.Rows[0]["UId"];
                    
                }
                conn.Close();
                return i;
            }
        }

        public int TuPianYanZheng(string token)
        {
            String appId = "f4821addb462dd54853153c0c72ef42f";
            String appSecret = "4a1b54464e6af3cb0ceb4bda7816cf32";
            DxCsharpSDK.Captcha captcha = new DxCsharpSDK.Captcha(appId, appSecret);
            DxCsharpSDK.CaptchaResponse response = captcha.VerifyToken(token);
            Response.Write(response.captchaStatus);
            //确保验证状态是SERVER_SUCCESS，SDK中有容错机制，在网络出现异常的情况会返回通过
            if (response.result)
            {
                /**token验证通过，继续其他流程**/
                return 1;
            }
            else
            {
                /**token验证失败，业务系统可以直接阻断该次请求或者继续弹验证码**/
                return 0;
            }
            

        }
    }
}