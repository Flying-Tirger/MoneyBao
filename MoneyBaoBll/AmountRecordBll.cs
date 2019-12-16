using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
    /// <summary>
    /// 项目记录表
    /// </summary>
    public class AmountRecordBll
    {
        MoneyBaoDAL.AmountRecordDal dal = new MoneyBaoDAL.AmountRecordDal();
        /// <summary>
        /// 添加项目记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddAmountRecord(AmountRecordModel model)
        {
            MoneyBaoDAL.AmountInfoDal infoDal = new MoneyBaoDAL.AmountInfoDal();
            int n =  infoDal.UpdateInvestorCount(model.InvestorMoney, model.AmountId);
            if (n>0)
            {
                return dal.AddAmountRecord(model);
            }
            else
            {
                return 0;
            }
        }
        
        /// <summary>
        /// 显示记录
        /// </summary>
        /// <param name="CreateTime">创建时间</param>
        /// <param name="AmountState">状态</param>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public List<AmountRecordModel> Show(string CreateTime = "",  int AmountState = "",string UserEmail="")
        {
            return dal.Show(CreateTime, AmountState,UserEmail);
        }
        /// <summary>
        /// 修改状态 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(int AmountState, int AmountId)
        {
            return dal.Update(AmountState, AmountId);
        }
    }
}
