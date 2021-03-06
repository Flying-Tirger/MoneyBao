﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using System.Data.SqlClient;
using System.Data;
using PubilcHelper;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 兑换记录表Dal
    /// </summary>
    public class ConventRecordDal
    {
   
        /// <summary>
        /// 添加：记录兑换信息 (兑换个数)(消费积分)(兑换时间)
        /// </summary>
        /// <param name="recordModel"></param>
        /// <returns></returns>
        public int RecordAdd(ConventRecordModel recordModel)
        {
           
            string sql = $"insert into ConventRecord values({recordModel.ShopInfoId},'{recordModel.UserEmail}',{recordModel.ConventCount},{recordModel.ConsumeIntegral},getDate())";

               return   PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示：关联用户表和商品信息表 显示出用户邮箱，兑换的商品信息，
        ///       兑换的个数，消费的积分，兑换时间
        /// </summary>
        /// <returns></returns>
        public List<ConventRecordModel> RecordShow(string UserEmail = null)
        {
            if (UserEmail!=null)
            {
                string sql = $"select * from ConventRecord join UserInfo on ConventRecord.UserEmail=UserInfo.UserEmail  Where 1=1";
                if (!string.IsNullOrWhiteSpace(UserEmail))
                {
                    sql += $" and UserEmail = '{UserEmail}'";
                }
                return PubilcHelper.DBHelper.GetToList<ConventRecordModel>(sql);
            }
            else
            {
                string sql = $"select * from ConventRecord join ShopInfo on ConventRecord.ShopInfoId=ShopInfo.ShopInfoId  Where 1=1";
                return PubilcHelper.DBHelper.GetToList<ConventRecordModel>(sql);
            }
        }
        /// <summary>
        /// 删除：可单个删除兑换的信息，一键全选，删除所有
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public int RecordDel(int sid)
        {
            string sql = $"delete from ConventRecord where ConventRecordId = {sid}";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
    }
}
