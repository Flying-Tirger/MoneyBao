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
        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddAmountInfo(AmountInfoModel model)
        {
            if (dal.AddAmountInfo(model)>0)
            {
                AmountRecordDal recordDal = new AmountRecordDal();
                AmountRecordModel amount = new AmountRecordModel()
                {
                       AmountDisthingId=0,
                       AmountSerial = model.AmountSerial,
                      AmountState=2, ApplyMoney=model.ApplyMoney, CreateTime=DateTime.Now,
                      UserEmail =model.FinanceUser,
                       InvestorMoney=0
                };
              return  recordDal.AddAmountRecord(amount);
            }
            else
            {
                return 0;
            }
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
