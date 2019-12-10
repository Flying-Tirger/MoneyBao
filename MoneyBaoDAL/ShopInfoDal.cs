using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoneyBaoModel;
using Dapper;

namespace MoneyBaoDAL
{
    
    public  class ShopInfoDal
    {
        SqlConnection conn = new SqlConnection(SqlconntionHelper.GetConntion());
        /// <summary>
        /// 商品显示
        /// </summary>
        public List<ShopInfoModel> ShopShow()
        {
            string sql = "select * from ShopInfo";
            return conn.Query<ShopInfoModel>(sql, conn).ToList();
        }
    }
}
