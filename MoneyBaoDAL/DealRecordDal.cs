using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using System.Data.SqlClient;
using System.Configuration;
using PubilcHelper;
namespace MoneyBaoDAL
{
    public class DealRecordDal
    {

        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <returns></returns>
        public int AddDealRecord(DealRecordModel dealRecord)
        {
            string sql = $"insert into DealRecord values('{dealRecord.UserEmail}','{dealRecord.StartBalance}','{dealRecord.EndBalance}','{dealRecord.BalanceTime}','{dealRecord.Cause}','{dealRecord.DealState}')";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);

        }
        /// <summary>
        /// 显示交易记录
        /// </summary>
        /// <param name="UserEmil">用户邮箱</param>
        /// <param name="StarTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <returns></returns>
        public List<DealRecordModel> ListDealRecordModel(string UserEmil="",string StarTime="",string EndTime="")
        {
            string sql = "select * from DealRecord where 1=1 ";
            //设置条件
            if (!string.IsNullOrWhiteSpace(UserEmil))
            {
                sql += $" and DealRecord.UserEmail = '{UserEmil}'";
            }
            if (!string.IsNullOrWhiteSpace(StarTime))
            {
                sql += $" and DealRecord.BalanceTime >= '{StarTime}'";
            }
            if (!string.IsNullOrWhiteSpace(EndTime))
            {
                sql += $" and DealRecord.BalanceTime <= '{EndTime}'";
            }
            return PubilcHelper.DBHelper.GetToList<DealRecordModel>(sql);
        }
    }
}
