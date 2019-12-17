using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 项目记录表
    /// </summary>
    public class AmountRecordModel
    {
        /// <summary>
        /// 项目记录表Id
        /// </summary>
        public int AmountId { get; set; }
        /// <summary>
        /// 连接项目表
        /// </summary>
        public int AmountInfoId { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 融资金额
        /// </summary>
        public decimal ApplyMoney { get; set; }
        /// <summary>
        /// 投资金额
        /// </summary>
        public decimal InvestorMoney { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 状态(0:投资成功  1:筹资成功 2:正在审核 3:审核未通过 4:正在筹资)
        /// </summary>
        public int AmountState { get; set; }
        /// <summary>
        /// 区分项目(0:融资   1:投资)
        /// </summary>
        public int AmountDisthingId { get; set; }

    }
}
