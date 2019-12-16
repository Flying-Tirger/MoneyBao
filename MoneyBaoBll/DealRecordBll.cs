using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
    /// <summary>
    /// 交易记录表
    /// </summary>
   public class DealRecordBll
    {
        MoneyBaoDAL.DealRecordDal dal = new MoneyBaoDAL.DealRecordDal();
        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <returns></returns>
        public int AddDealRecord(DealRecordModel dealRecord)
        {
            return dal.AddDealRecord(dealRecord);
        }
        /// <summary>
        /// 显示交易记录
        /// </summary>
        /// <param name="UserEmil">用户邮箱</param>
        /// <param name="StarTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <returns></returns>
        public List<DealRecordModel> ListDealRecordModel(string UserEmil = "", string StarTime = "", string EndTime = "")
        {
            return dal.ListDealRecordModel(UserEmil, StarTime, EndTime);
        }
    }
}
