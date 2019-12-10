using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MoneyBaoModel;
using System.Data.SqlClient;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 成长值积分变动表
    /// </summary>
    public class GrowthInfoDal
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MoneyLeopard;Integrated Security=True");
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(GrowthInfoModel model)
        {

            string sql = $"insert into GrowthInfo values({model.GrowthId},{model.UserEmail},{model.ChangeTime},{model.BeforeIntegral},{model.AfterIntegra},{model.GrowthValueNow},{model.Cause},{model.DisthingId},{model.ChangeValue}";
            return conn.Execute(sql);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns> 
        public List<GrowthInfoModel> Show()
        {
            return conn.Query<GrowthInfoModel>("select * from GrowthInfo join UserInfo on GrowthInfo.GrowthId=UserInfo.UserId join ConventRecord on UserInfo.UserId=ConventRecord.ConventRecordId join ShopInfo on ConventRecord.ConventRecordId=ShopInfo.ShopInfoId", conn).ToList();
        }

    }
}
