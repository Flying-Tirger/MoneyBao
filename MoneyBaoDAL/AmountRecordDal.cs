using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using MoneyBaoModel;
using PubilcHelper;
namespace MoneyBaoDAL
{
    public class AmountRecordDal
    {
        /// <summary>
        /// 添加项目记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddAmountRecord(AmountRecordModel model) 
        {
            string sql = $"insert into AmountRecord values('{model.UserEmail}','{model.ApplyMoney}','{model.InvestorMoney}','{model.CreateTime}','{model.AmountState}','{model.AmountDisthingId}')";
            using (SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion()))
            {
                return conn.Execute(sql, conn);
            }
        }
        /// <summary>
        /// 显示记录
        /// </summary>
        /// <param name="CreateTime"></param>
        /// <param name="AmountState"></param>
        /// <returns></returns>
        public List<AmountRecordModel> Show(string CreateTime = "", string ,string AmountState = "")
        {
            string sql = "select * from AmountRecord  where 1=1 ";
            if (!string.IsNullOrWhiteSpace(CreateTime))
            {
                sql += $" and CreateTim>='{CreateTime}'";
            }
            if (AmountState != "-1")
            {
                sql += string.Format(" and AmountState={0}", AmountState);
            }
            using (SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion()))
            {
                return conn.Query<AmountRecordModel>(sql, conn).ToList();
            }
        }
        /// <summary>
        /// 修改状态 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(int AmountState, int AmountId)
        {
            string sql = $"update AmountRecord set AmountState={AmountState} where AmountId  in ({AmountId})";
            using (SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion()))
            {
                return conn.Execute(sql, conn);
            }
        }
    }
}