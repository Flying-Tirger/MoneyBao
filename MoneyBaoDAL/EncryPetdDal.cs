using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using PubilcHelper;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 密保表
    /// </summary>
    public class EncryPetdDal
    {

        /// <summary>
        /// 密保显示
        /// </summary>
        /// <returns>作者韩传浩</returns>
        /// <returns>获取全部密保问题</returns>
        public List<EncryPetdModel> Get()
        {
            return DBHelper.GetToList<EncryPetdModel>("select * from encrypetd");
        }

    }
}
