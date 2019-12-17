using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using System.Data.SqlClient;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 成长值积分变动表
    /// </summary>
    public class GrowthInfoDal
    {
        
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(GrowthInfoModel model)
        {

            string sql = $"insert into GrowthInfo values({model.UserEmail},'getdate()',{model.BeforeIntegral},{model.AfterIntegra},{model.GrowthValueNow},{model.Cause},{model.DisthingId},{model.ChangeValue}";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public List<GrowthInfoModel> Show(string UserEmail = null)
        {
            string sql = "select * from GrowthInfo";
            if (!string.IsNullOrWhiteSpace(UserEmail))
            {
                sql += $" where UserEmail = '{UserEmail}'";
            }
            return PubilcHelper.DBHelper.GetToList<GrowthInfoModel>(sql);
        }

    }
}
