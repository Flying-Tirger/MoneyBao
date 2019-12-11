using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using PubilcHelper;
namespace MoneyBaoDAL
{
    public class EncryPetdDal
    {
        public List<EncryPetdModel> Get()
        {
            return DBHelper.GetToList<EncryPetdModel>("select * from encrypetd");
        }

    }
}
