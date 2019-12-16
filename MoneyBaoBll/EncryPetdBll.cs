using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoBll
{
    /// <summary>
    /// 密保表
    /// </summary>
    public class EncryPetdBll
    {
        MoneyBaoDAL.EncryPetdDal dal = new MoneyBaoDAL.EncryPetdDal();
        public List<EncryPetdModel> Get()
        {
            return dal.Get();
        }
    }
}
