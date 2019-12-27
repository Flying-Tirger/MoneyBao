using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoneyBaoBll;
using MoneyBaoModel;
using Newtonsoft.Json;
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
        public int Post(string json)

        {
            GrowthInfoModel model = JsonConvert.DeserializeObject<GrowthInfoModel>(json);
            return growthInfo.Post(model);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns> 
        public ListPage<GrowthInfoModel>  Get(int page, int size,string UserEmail = null)
        {
            List<GrowthInfoModel> dt= growthInfo.Show(UserEmail);
            ListPage<GrowthInfoModel> list = new ListPage<GrowthInfoModel>()
            {
                code = 0,
                msg = "msg",
                count = dt.Count,
                data = dt.Skip((page - 1) * size).Take(size).ToList()
            };
            return list;
        }
    }
}
