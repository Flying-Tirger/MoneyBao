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
        public int PostAmountInfo(string json)
        {
            AmountInfoModel model = JsonConvert.DeserializeObject<AmountInfoModel>(json);
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
        public List<AmountInfoModel> GetAmountInfo(int AmountId=-1)
        {
            if (AmountId==-1)
            {
                return bll.ShowAmountInfo();
            }
            else
            {
                return bll.ShowAmountInfo().Where(s => s.AmountId == AmountId).ToList();
            }
        }
    }
}
