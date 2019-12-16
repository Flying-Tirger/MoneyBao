using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
    /// <summary>
    /// 成长值积分变动表
    /// </summary>
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
            MoneyBaoDAL.UserInfoDal infoDal = new MoneyBaoDAL.UserInfoDal();
            return dal.Post(model);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns> 
        public List<GrowthInfoModel> Show(string UserEmail=null)
        {
            return dal.Show(UserEmail);
        }
    }
}
