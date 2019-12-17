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
    public class DealRecordController : ApiController
    {
        DealRecordBll DealInfo = new DealRecordBll();
        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(DealRecordModel model)
        {
            return DealInfo.AddDealRecord(model);
        }
        /// <summary>
        /// 显示交易记录
        /// </summary>
        /// <param name="UserEmil"></param>
        /// <param name="StarTime"></param>
        /// <param name="EndTime"></param>
        /// <returns></returns>
        public List<DealRecordModel> Get(string UserEmil = "", string StarTime = "", string EndTime = "")
        {
            return DealInfo.ListDealRecordModel(UserEmil, StarTime, EndTime);
        }
    }
}
