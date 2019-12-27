using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
namespace MoneyBaoAPI.Controllers
{

    public class EncryPetdController : ApiController
    {

        MoneyBaoBll.EncryPetdBll bll = new MoneyBaoBll.EncryPetdBll();
        /// <summary>
        /// 密保的显示或者绑定，a
        /// </summary>
        /// <returns>作者韩传浩</returns>
        /// <returns>获取密保问题</returns>
        public List<EncryPetdModel> Get()
        {
            return bll.Get();
        }

        /// <summary>
        /// 邮箱信息发送
        /// </summary>
        /// <param name="JiShou">所要发送的人</param>
        /// <returns>韩传浩</returns>
        public string GetTesGetCode(string JiShou)
        {
            PubilcHelper.EMailHelperTwo EMailHelper = new PubilcHelper.EMailHelperTwo();
            //TestGetCode返回验证码
            string TestGetCode = EMailHelper.Send(JiShou, 4);
            return TestGetCode;
        }

        public string GetTestGetCode(string JiShou)
        {
            PubilcHelper.EMailHelperTwo EMailHelper = new PubilcHelper.EMailHelperTwo() ;
            //TestGetCode返回验证码
            string TestGetCode =EMailHelper.Send(JiShou, 4);
            return TestGetCode;
        }
    }
}


