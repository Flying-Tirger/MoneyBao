using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    
    public class AmountRecordModel
    {
        public int AmountId         { get; set; }
        public string UserEmail	     { get; set; }
        public double ApplyMoney	     { get; set; }
        public double InvestorMoney    { get; set; }
        public DateTime CreateTime	     { get; set; }
        public int AmountState      { get; set; }
        public int AmountDisthingId { get; set; }

    }
}
