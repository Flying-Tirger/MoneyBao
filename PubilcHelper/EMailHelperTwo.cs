using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
namespace PubilcHelper
{

    public class EMailHelperTwo
    {
        /// <summary>
        /// 邮箱验证 返回验证码
        /// </summary>
        /// <param name="JiShou">接受的邮箱账号</param>
        /// <param name="Count">验证码数量</param>
        /// <returns></returns>
        public string Send(string JiShou,int Count)
        {
            string YZM = CreateBlendCode(Count);
            //发件人地址
            MailAddress from = new MailAddress("1779613869@qq.com");
            MailMessage message = new MailMessage();
            message.Body = "您本次的验证码为"+YZM;
            message.IsBodyHtml = true;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            //收件人地址
            message.To.Add(JiShou);
            message.Subject = "邮箱验证";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.From = from;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Host = "smtp.qq.com";
            client.Port = 587;
            //邮箱账户和密码
            //邮箱和邮件授权码
            client.Credentials = new System.Net.NetworkCredential("1779613869@qq.com", "iqnxrccswrlgbaic");
            try
            {
                client.Send(message);
                return YZM;
            }
            catch (Exception ex)
            {             
                string mssage = ex.ToString();
                return "";
            }
         
        }
        /// <summary>
        /// 这个是使用字母,数字混合
        /// </summary>
        /// <param name="VcodeNum"></param>
        /// <returns></returns>
        public  string CreateBlendCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(61);
                if (temp == t)
                {
                    return CreateBlendCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }

            return randomCode;
        }


    }
}