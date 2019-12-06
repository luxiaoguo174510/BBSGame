using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

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