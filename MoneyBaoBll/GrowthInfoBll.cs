using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
   public class GrowthInfoBll
    {
        MoneyBaoDAL.GrowthInfoDal dal = new MoneyBaoDAL.GrowthInfoDal();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(GrowthInfoModel model)
        {
            return dal.Post(model);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns> 
        public List<GrowthInfoModel> Show()
        {
            return dal.Show();
        }
    }
}
