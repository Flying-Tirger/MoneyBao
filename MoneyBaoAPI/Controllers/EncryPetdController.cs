using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoneyBaoAPI.Controllers
{

    public class EncryPetdController : ApiController
    {

        MoneyBaoBll.EncryPetdBll bll = new MoneyBaoBll.EncryPetdBll();
        public List<EncryPetdModel> Get()
        {
            return bll.Get();
        }
    }
}
