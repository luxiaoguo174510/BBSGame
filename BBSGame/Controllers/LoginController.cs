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
using System.IO;

namespace BBSGame.Controllers
{
    [Serializable]
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
        public ActionResult ZhuCe()
        {
            return View();
        }
        [HttpPost]
        public void ZhuCe(UserInfo m, HttpPostedFileBase Path)
        {
            //判断字段是否包含空项
            if (m.Birthday == null  || m.NickName == null || m.PassWord == null || m.Phone == null || m.Province == null || m.Sex == null || m.UName == null)
            {
                Response.Write("<script>alert('注册字段不能为空或注册失败请稍后再试');</script>");
            }
            if (Path != null)
            {
                if (!Directory.Exists(Server.MapPath("/Image/")))
                {
                    Directory.CreateDirectory(Server.MapPath("/Image/"));
                }
                Path.SaveAs(Server.MapPath("/Image/" + Path.FileName));
                m.HeadPic = "/Image/" + Path.FileName;
            }
            //存储过程MD5加密
            using (SqlConnection conn = new SqlConnection("Data Source=10.1.152.12;Initial Catalog=BBSGame;User ID=sa;pwd=1234"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("ZhuCe", conn);
                comm.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlUName = new SqlParameter("@UName", SqlDbType.VarChar, 30);
                sqlUName.Value = m.UName;
                SqlParameter sqlPassWord = new SqlParameter("@PassWord", SqlDbType.VarChar, 30);
                sqlPassWord.Value = m.PassWord;
                SqlParameter sqlNickName = new SqlParameter("@NickName", SqlDbType.VarChar, 30);
                sqlNickName.Value = m.NickName;
                SqlParameter sqlHeadPic = new SqlParameter("@HeadPic", SqlDbType.VarChar, 255);
                sqlHeadPic.Value = m.HeadPic;
                SqlParameter sqlSex = new SqlParameter("@Sex", SqlDbType.VarChar, 30);
                sqlSex.Value = m.Sex;
                SqlParameter sqlBir = new SqlParameter("@Bir", SqlDbType.DateTime);
                sqlBir.Value = m.Birthday;
                SqlParameter sqlProvince = new SqlParameter("@Province", SqlDbType.VarChar, 30);
                sqlProvince.Value = m.Province;
                SqlParameter sqlPhone = new SqlParameter("@Phone", SqlDbType.VarChar, 30);
                sqlPhone.Value = m.Phone;
                comm.Parameters.Add(sqlUName);
                comm.Parameters.Add(sqlPassWord);
                comm.Parameters.Add(sqlNickName);
                comm.Parameters.Add(sqlHeadPic);
                comm.Parameters.Add(sqlSex);
                comm.Parameters.Add(sqlBir);
                comm.Parameters.Add(sqlProvince);
                comm.Parameters.Add(sqlPhone);
                int i = comm.ExecuteNonQuery();
                conn.Close();
                if (i>0)
                {
                    Response.Write("<script>alert('注册成功');location.href = '../LoginHtml/index.html';</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册字段不能为空或注册失败请稍后再试');</script>");
                }
            }

        }

        /// <summary>
        /// 登录验证
        /// 在图片验证后验证
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public int LoginUser(string UName, string PassWord, string Phone)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=10.1.152.12;Initial Catalog=BBSGame;User ID=sa;pwd=1234"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("DengLu", conn);
                comm.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlUName = new SqlParameter("@UName", SqlDbType.VarChar, 30);
                sqlUName.Value = UName;
                SqlParameter sqlPassWord = new SqlParameter("@PassWord", SqlDbType.VarChar, 30);
                sqlPassWord.Value = PassWord;
                SqlParameter sqlPhone = new SqlParameter("@Phone", SqlDbType.VarChar, 30);
                sqlPhone.Value = Phone;
                comm.Parameters.Add(sqlUName);
                comm.Parameters.Add(sqlPassWord);
                comm.Parameters.Add(sqlPhone);
                SqlDataAdapter sqlData = new SqlDataAdapter(comm);
                DataTable DT = new DataTable();
                sqlData.Fill(DT);
                int i = (int)DT.Rows[0][0];
                System.Web.HttpContext.Current.Session["NickName"] = DT.Rows[0]["NickName"];
                System.Web.HttpContext.Current.Session["UId"] = DT.Rows[0]["UId"];
                System.Web.HttpContext.Current.Session["User"] = JsonConvert.SerializeObject(DT);
                conn.Close();
                Home.AddIntegral(DateTime.Now.ToShortDateString()+DateTime.Now.ToShortTimeString()+"登陆成功!");
                return i;
            }
        }



        /// <summary>
        /// 弃用
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public int TuPianYanZheng(string token)
        {
            String appId = "f4821addb462dd54853153c0c72ef42f";
            String appSecret = "4a1b54464e6af3cb0ceb4bda7816cf32";
            DxCsharpSDK.Captcha captcha = new DxCsharpSDK.Captcha(appId, appSecret);//DxCsharpSDK 为引用 DxCsharpSDK.dll
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