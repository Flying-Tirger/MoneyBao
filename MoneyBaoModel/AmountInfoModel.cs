using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 项目表
    /// </summary>
    public class AmountInfoModel
{       /// <summary>
        /// 项目Id
        /// </summary>
        public int AmountId { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string AmountName { get; set; }
        /// <summary>
        /// 项目编号(Jqb+当前时间)
        /// </summary>
        public string AmountSerial { get; set; }
        /// <summary>
        /// 申请金额
        /// </summary>
        public decimal ApplyMoney { get; set; }
        /// <summary>
        /// 利率
        /// </summary>
        public decimal InterestRate { get; set; }
        /// <summary>
        /// 融资期限
        /// </summary>
        public int FinanceTime { get; set; }
        /// <summary>
        /// 还款期限(融资成功后还款的期限)
        /// </summary>
        public int RapayMentTime { get; set; }
        /// <summary>
        /// 融资人(昵称)
        /// </summary>
        public string FinanceUser { get; set; }
        /// <summary>
        /// 状态(审核中,成功[上架],失败,还款,下架)
        /// </summary>
        public int AmountState { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime AuditTime { get; set; }
        /// <summary>
        /// 身份证正面
        /// </summary>
        public string IdentityFornt { get; set; }
        /// <summary>
        /// 身份证反面
        /// </summary>
        public string IdentityReal { get; set; }
        /// <summary>
        /// 抵押物
        /// </summary>
        public string Guarantee { get; set; }
        /// <summary>
        /// 抵押物证明(证明照片)
        /// </summary>
        public string GuaranteeInfo { get; set; }
        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string LinkManNumber { get; set; }
        /// <summary>
        /// 投资人数
        /// </summary>
        public int InvestorCount { get; set; }
        /// <summary>
        /// 融资金额
        /// </summary>
        public decimal AmountMoney { get; set; }
    }
}
