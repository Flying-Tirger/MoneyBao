using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 交易记录表
    /// </summary>
    class DealRecordModel
    {
        /// <summary>
        /// 交易记录Id
        /// </summary>
        public int DealRecordId { get; set; }
        /// <summary>
        /// 用户邮箱--连接用户信息表
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 交易前余额
        /// </summary>
        public double StartBalance { get; set; }
        /// <summary>
        /// 交易后余额
        /// </summary>
        public double EndBalance { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime BalanceTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Cause { get; set; }
        /// <summary>
        /// 状态(支出,收入)
        /// </summary>
        public int DealState { get; set; }
    }
}
