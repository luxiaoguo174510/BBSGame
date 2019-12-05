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

namespace BBSGame.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登录验证
        /// 在图片验证后验证
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public int LoginUser(string UName,string PassWord,string Phone)
        {
            using (SqlConnection conn=new SqlConnection("Data Source=10.1.152.12;Initial Catalog=BBSGame;User ID=sa;pwd=1234"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand($"select COUNT(1) from UserInfo where UName='{UName}' and PassWord='{PassWord}' and Phone='{Phone}'",conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(comm);
                DataTable DT = new DataTable();
                sqlData.Fill(DT);
                int i = (int)DT.Rows[0][0];
                conn.Close();
                return i;
            }
        }

        /// <summary>
        /// Api接口发送短信验证码
        /// 验证码=>随即生成
        /// </summary>
        /// <param name="iphone"></param>
        /// <returns></returns>
        public string GetIphoneYanZheng(string iphone)
        {
            string _timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string _content = "【GameLife】富婆你好!我是你大哥。";
            string _sign =Sign("你们的豪哥g+H19990326+DateTime.Now","UTF-8");
            //string url = $"http://cloud.yunsms.cn/v2sms.aspx/?action=send&userid=1787&timestamp={_timestamp}&sign={_sign}&mobile={iphone}&content={_content}&extno=";
            string url = $"http://cloud.yunsms.cn/v2sms.aspx?action=send&userid=1787&timestamp={_timestamp}&sign={_sign}&mobile={iphone}&content={_content}&extno=";
            //string url = $"http://cloud.yunsms.cn/v2sms.aspx?action=send&userid=1690&timestamp=20190117230015&sign=8cc9da70545cc7da27c2eb95031a13ff&mobile={iphone}&content=【GameLife】富婆你好!我是你大哥。&extno=";
            HttpClient client = new HttpClient();//【GameLife】富婆你好!我是你大哥。
            HttpResponseMessage message = client.GetAsync(url).Result;
            string x = message.Content.ReadAsStringAsync().Result;

            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "";
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

        private string Sign(string strSource, string sEncode)
        {
            //new
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider(); 
            //获取密文字节数组
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.GetEncoding(sEncode).GetBytes(strSource));

            //转换成字符串，并取9到25位
            //string strResult = BitConverter.ToString(bytResult, 4, 8);

            //转换成字符串，32位
            string strResult = BitConverter.ToString(bytResult);

            //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉        
            strResult = strResult.Replace("-", "");

            return strResult.ToLower();
        }

    }
}