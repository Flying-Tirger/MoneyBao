using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoDAL;
using MoneyBaoModel;

namespace MoneyBaoBll
{
   public class ShopInfoBll
    {
        ShopInfoDal dal = new ShopInfoDal();
        /// <summary>
        /// 商品显示
        /// </summary>
        /// <returns></returns>
        public List<ShopInfoModel> ShopShow()
        {
            List<ShopInfoModel> shop = dal.ShopShow();
            return shop;
         }
    }
}
