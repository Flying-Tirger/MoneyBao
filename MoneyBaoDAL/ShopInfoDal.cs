using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoneyBaoModel;
using PubilcHelper;

namespace MoneyBaoDAL
{
    
    public  class ShopInfoDal
    {
        /// <summary>
        /// 商品显示
        /// </summary>
        public List<ShopInfoModel> ShopShow()
        {
            string sql = "select * from ShopInfo where ShopState=0";
            return DBHelper.GetToList<ShopInfoModel>(sql);
        }
        /// <summary>
        /// 修改库存量
        /// </summary>
        /// <param name="ShopInfoId"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public int Update(int ShopInfoId, int Count,int State=-1)
        {
            string sql = "";
            if (State != -1)
            {
                sql = $"update ShopInfo set StockCount-={Count}, ShopState={State} where ShopInfoId={ShopInfoId}";
                return DBHelper.ExecuteNonQuery(sql);
            }
            else
            {
                sql = $"update ShopInfo set StockCount-={Count} where ShopInfoId={ShopInfoId}";
                return DBHelper.ExecuteNonQuery(sql);
            }
            
        }
    }
}
