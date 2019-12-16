using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoDAL;
using MoneyBaoModel;

namespace MoneyBaoBll
{
    /// <summary>
    /// 商品表
    /// </summary>
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

        /// <summary>
        /// 修改库存量
        /// </summary>
        /// <param name="ShopInfoId"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public int Update(int ShopInfoId, int Count)
        {
            return dal.Update(ShopInfoId, Count);
        }
    }
}
