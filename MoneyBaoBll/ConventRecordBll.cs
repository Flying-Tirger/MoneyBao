using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoneyBaoModel;
using MoneyBaoDAL;
namespace MoneyBaoBll
{
    public class ConventRecordBll
    {
        /// <summary>
        /// 添加：记录兑换信息 (兑换个数)(消费积分)(兑换时间)
        /// </summary>
        /// <param name="recordModel"></param>
        /// <returns></returns>
        public int RecordAdd(ConventRecordModel recordModel)
        {
            ConventRecordDal dal = new ConventRecordDal();
            return dal.RecordAdd(recordModel);
        }
        /// <summary>
        /// 显示：关联用户表和商品信息表 显示出用户邮箱，兑换的商品信息，
        ///       兑换的个数，消费的积分，兑换时间
        /// </summary>
        /// <returns></returns>
        public List<ConventRecordModel> RecordShow(string UserEmil = "")
        {
            ConventRecordDal dal = new ConventRecordDal();
            return dal.RecordShow(UserEmil);
        }
        /// <summary>
        /// 删除：可单个删除兑换的信息，一键全选，删除所有
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public int RecordDel(string sid)
        {
            ConventRecordDal dal = new ConventRecordDal();
            return dal.RecordDel(sid);
        }
    }
}
