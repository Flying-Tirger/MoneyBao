using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoneyBaoBll;
using MoneyBaoModel;
namespace MoneyBaoAPI.Controllers
{
    public class GrowthInfoController : ApiController
    {
        GrowthInfoBll growthInfo = new GrowthInfoBll();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(GrowthInfoModel model)
        {
            return growthInfo.Post(model);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns> 
        public List<GrowthInfoModel> Get(string UserEmail = null)
        {
            return growthInfo.Show(UserEmail);
        }
    }
}
