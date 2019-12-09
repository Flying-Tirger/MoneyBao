using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 兑换记录表
    /// </summary>
    public class ConventRecordModel
    {
       ///节课
        /// <summary>
        /// 兑换Id
        /// </summary>
        public int ConventRecordId  { get; set; }
        /// <summary>
        /// 商品Id(连接商品信息)
        /// </summary>
        public int ShopInfoId	     { get; set; }
        /// <summary>
        /// 用户邮箱(连接用户信息)
        /// </summary>
        public string UserEmail	     { get; set; }
        /// <summary>
        /// 兑换个数
        /// </summary>
        public int ConventCount	 { get; set; }
        /// <summary>
        /// 消费积分
        /// </summary>
        public int ConsumeIntegral  { get; set; }
        /// <summary>
        /// 兑换时间
        /// </summary>
        public DateTime ConventTime      { get; set; }
    }
}
