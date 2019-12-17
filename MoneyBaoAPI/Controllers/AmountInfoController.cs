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
    /// <summary>
    /// 项目表  常雅俊
    /// </summary>
    public class AmountInfoController : ApiController
    {
        AmountInfoBll bll = new AmountInfoBll();
        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PostAmountInfo(AmountInfoModel model)
        {
            return bll.AddAmountInfo(model);
        }
        /// <summary>
        /// 修改投资人的身份、抵押物、抵押物证明、联系人手机号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PutAmountInfo(AmountInfoModel model)
        {
            return bll.UpdateAmountInfo(model);
        }
        /// <summary>
        /// 显示项目表
        /// </summary>
        public List<AmountInfoModel> GetAmountInfo()
        {
            return bll.ShowAmountInfo();
        }
    }
}
