using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 成长值积分变动表
    /// </summary>
    public class GrowthInfoModel
    {
        /// <summary>
        /// 成长值Id
        /// </summary>
        public int GrowthId { get; set; }
        /// <summary>
        /// 用户邮箱(绑定用户信息)
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 变动时间
        /// </summary>
        public DateTime ChangeTime { get; set; }
        /// <summary>
        /// 变动前积分
        /// </summary>
        public int BeforeIntegral { get; set; }
        /// <summary>
        /// 变动后积分
        /// </summary>
        public int AfterIntegra { get; set; }
        /// <summary>
        /// 现有成长值
        /// </summary>
        public int GrowthValueNow { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Cause { get; set; }
        /// <summary>
        /// 区别Id(1:成长值   0:积分)
        /// </summary>
        public int DisthingId { get; set; }
        /// <summary>
        /// 变动值
        /// </summary>
        public int ChangeValue { get; set; }
    }
}
