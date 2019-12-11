using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
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
            return dal.AddAmountRecord(model);
        }
        /// <summary>
        /// 显示记录
        /// </summary>
        /// <param name="CreateTime"></param>
        /// <param name="AmountState"></param>
        /// <returns></returns>
        public List<AmountRecordModel> Show(string CreateTime = "",  string AmountState = "")
        {
            return dal.Show(CreateTime, AmountState);
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
