using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoneyBaoModel;
using MoneyBaoDAL;
namespace MoneyBaoBll
{
    /// <summary>
    /// 兑换记录表
    /// </summary>
    public class ConventRecordBll
    {
        ConventRecordDal dal = new ConventRecordDal();
        /// <summary>
        /// 添加：记录兑换信息 (兑换个数)(消费积分)(兑换时间)
        /// </summary>
        /// <param name="recordModel"></param>
        /// <returns></returns>
        public int RecordAdd(ConventRecordModel recordModel)
        {
          
            ShopInfoDal infoDal = new ShopInfoDal();
            int n =  infoDal.Update(recordModel.ShopInfoId, recordModel.ConventCount);
            if (n>0)
            {
                return dal.RecordAdd(recordModel);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 显示：关联用户表和商品信息表 显示出用户邮箱，兑换的商品信息，
        ///       兑换的个数，消费的积分，兑换时间
        /// </summary>
        /// <returns></returns>
        public List<ConventRecordModel> RecordShow(string UserEmil = "")
        {
            return dal.RecordShow(UserEmil);
        }
        /// <summary>
        /// 删除：可单个删除兑换的信息，一键全选，删除所有
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public int RecordDel(string sid)
        {

            return dal.RecordDel(sid);
        }
    }
}
