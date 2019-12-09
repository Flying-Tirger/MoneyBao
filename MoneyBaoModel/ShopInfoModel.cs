using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    public class ShopInfoModel
    {
       /// <summary>
       /// 商品Id
       /// </summary>
        public int ShopInfoId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string ShopPicture { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double ShopMuch { get; set; }
        /// <summary>
        /// 商品折扣
        /// </summary>
        public double ShopDiscount { get; set; }
        /// <summary>
        /// 库存量
        /// </summary>
        public int StockCount { get; set; }
        /// <summary>
        /// 商品状态(上架，下架)
        /// </summary>
        public int ShopState { get; set; }
    }
}
