using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoneyBaoModel;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using PubilcHelper;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 兑换记录表Dal
    /// </summary>
    public class ConventRecordDal
    {
        SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion());
        /// <summary>
        /// 添加：记录兑换信息 (兑换个数)(消费积分)(兑换时间)
        /// </summary>
        /// <param name="recordModel"></param>
        /// <returns></returns>
        public int RecordAdd(ConventRecordModel recordModel)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"insert into ConventRecord values('{recordModel.ConventCount}','{recordModel.ConsumeIntegral}','newdate()')";
            SqlCommand cmd = new SqlCommand(sql,conn);
            int n=cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
        /// <summary>
        /// 显示：关联用户表和商品信息表 显示出用户邮箱，兑换的商品信息，
        ///       兑换的个数，消费的积分，兑换时间
        /// </summary>
        /// <returns></returns>
        public List<ConventRecordModel> RecordShow(string UserEmil = "")
        {
            string sql = $"select * from ConventRecord  where 1-1";
            if (!string.IsNullOrWhiteSpace(UserEmil))
            {
                sql += $" and UserEmail = '{UserEmil}'";
            }
            using (SqlConnection conn = new SqlConnection(SqlConntionHelper.GetConntion()))
            {
                return conn.Query<ConventRecordModel>(sql, conn).ToList();
            }
        }
        /// <summary>
        /// 删除：可单个删除兑换的信息，一键全选，删除所有
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public int RecordDel(string DealRecordId)
        {
            string sql = $"delete from ConventRecord where DealRecordId in ({DealRecordId})";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql,conn);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
    }
}
