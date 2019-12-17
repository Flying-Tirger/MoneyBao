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
    
    public class ShopInfoController : ApiController
    {
        /// <summary>
        /// 实例化bll
        /// </summary>
        ShopInfoBll bll = new ShopInfoBll();
        /// <summary>
        /// 商品显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ShopInfoModel> GetShopShow()
        {
            return bll.ShopShow();
        }
        /// <summary>
        /// 库存量修改
        /// </summary>
        /// <param name="ShopInfoId">商品Id</param>
        /// <param name="Count">修改的库存量</param>
        /// <returns></returns>
        [HttpPut]
        public int Putshop(int ShopInfoId, int Count)
        {
            return bll.Update(ShopInfoId, Count);
        }
    }
}
