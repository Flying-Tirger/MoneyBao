using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoDAL;
using MoneyBaoModel;
namespace MoneyBaoBll
{
    /// <summary>
    /// 项目表
    /// </summary>
  public  class AmountInfoBll
    {
        AmountInfoDal dal = new AmountInfoDal();
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddAmountInfo(AmountInfoModel model)
        {
     
            return dal.AddAmountInfo(model);
        }
        /// <summary>
        /// 修改投资人的身份、抵押物、抵押物证明、联系人手机号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateAmountInfo(AmountInfoModel model)
        {
            return dal.UpdateAmountInfo(model);
        }
        /// <summary>
        /// 显示项目表
        /// </summary>
        public List<AmountInfoModel> ShowAmountInfo()
        {
            return dal.ShowAmountInfo();
        }
    }
}
