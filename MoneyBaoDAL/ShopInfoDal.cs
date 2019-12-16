using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoneyBaoModel;
using Dapper;
using PubilcHelper;

namespace MoneyBaoDAL
{
    
    public  class ShopInfoDal
    {
        SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion());
        /// <summary>
        /// 商品显示
        /// </summary>
        public List<ShopInfoModel> ShopShow()
        {
            string sql = "select * from ShopInfo where ShopState=true";
            return conn.Query<ShopInfoModel>(sql, conn).ToList();
        }
        /// <summary>
        /// 修改库存量
        /// </summary>
        /// <param name="ShopInfoId"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public int Update(int ShopInfoId,int Count)
        {
            string sql = $"update set StockCount-={Count} where ShopInfoId={ShopInfoId}";
            return conn.Execute(sql);
        }
    }
}
