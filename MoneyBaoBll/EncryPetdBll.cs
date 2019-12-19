using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
    /// <summary>
    /// 密保表a
    /// </summary>
    /// <returns>作者韩传浩</returns>
    public class EncryPetdBll
    {
        MoneyBaoDAL.EncryPetdDal dal = new MoneyBaoDAL.EncryPetdDal();
        /// <summary>
        /// 显示密保问题
        /// </summary>
        /// <returns>获取密保的问题</returns>
        public List<EncryPetdModel> Get()
        {
            return dal.Get();
        }


    }
}
