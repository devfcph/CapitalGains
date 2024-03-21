using CodeChallenge_CapitalGains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_CapitalGains.Entities
{
    public class Capital
    {
        public OperationType Operation { get; set; }

        public Decimal UnitCost {  get; set; }
        public Int32 Quantity { get; set; }
    }
}
