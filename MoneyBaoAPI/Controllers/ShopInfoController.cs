using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using MoneyBaoBll;
using System.Data.SqlClient;
using MoneyBaoModel;

namespace MoneyBaoAPI.Controllers
{
    
    public class ShopInfoController : ApiController
    {
        ShopInfoBll bll = new ShopInfoBll();
        public List<ShopInfoModel> GetShopShow()
        {
            return bll.ShopShow();
        }
        public int Putshop(int ShopInfoId, int Count)
        {
            return bll.Update(ShopInfoId, Count);
        }
    }
}
