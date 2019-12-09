using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    public class ConventRecordModel
    {
        public int ConventRecordId  { get; set; }
        public int ShopInfoId	     { get; set; }
        public string UserEmail	     { get; set; }
        public int ConventCount	 { get; set; }
        public int ConsumeIntegral  { get; set; }
        public DateTime ConventTime      { get; set; }
    }
}
