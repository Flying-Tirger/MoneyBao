using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    public class ShopInfoModel
    {
        ///商品Id
        public int ShopInfoId { get; set; }
        //商品名称
        public string ShopName { get; set; }
        //商品图片
        public string ShopPicture { get; set; }
        //商品价格
        public double ShopMuch { get; set; }
        //商品折扣
        public double ShopDiscount { get; set; }
        //库存量
        public int StockCount { get; set; }
        //商品状态(上架，下架)
        public int ShopState { get; set; }
    }
}
