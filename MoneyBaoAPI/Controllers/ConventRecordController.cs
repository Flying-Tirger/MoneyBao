using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoneyBaoBll;
using MoneyBaoModel;
namespace MoneyBaoAPI.Controllers
{
    public class ConventRecordController : ApiController
    {
        ConventRecordBll RecordBll = new ConventRecordBll();
        /// <summary>
        /// 添加：记录兑换信息 (兑换个数)(消费积分)(兑换时间)
        /// </summary>
        /// <param name="recordModel"></param>
        /// <returns></returns>
        public int RecordAdd(ConventRecordModel recordModel)
        {
            return RecordBll.RecordAdd(recordModel);
        }
        /// <summary>
        /// 显示：关联用户表和商品信息表 显示出用户邮箱，兑换的商品信息，
        ///       兑换的个数，消费的积分，兑换时间
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ConventRecordModel> RecordShow()
        {
            return RecordBll.RecordShow();
        }
        /// <summary>
        /// 删除：可单个删除兑换的信息，一键全选，删除所有
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public int RecordDel(string sid)
        {

            return RecordBll.RecordDel(sid);
        }
    }
}
