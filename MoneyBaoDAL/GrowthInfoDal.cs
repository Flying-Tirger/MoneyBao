﻿using System;
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
        SqlConnection conn = new SqlConnection(PubilcHelper.SqlConntionHelper.GetConntion());
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(GrowthInfoModel model)
        {

            string sql = $"insert into GrowthInfo values({model.UserEmail},{model.ChangeTime},{model.BeforeIntegral},{model.AfterIntegra},{model.GrowthValueNow},{model.Cause},{model.DisthingId},{model.ChangeValue}";
            return conn.Execute(sql,conn);
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
            return conn.Query<GrowthInfoModel>(sql, conn).ToList();
        }

    }
}
