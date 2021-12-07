using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoipApplicationProject.Models
{
    public class BalanceCustomerModel
    {
        public string BalanceCustomerID { get; set; }
        public int BalanceAmount { get; set; }
        public TransactionType TranscationType { get; set; }
        public string CustomerId { get; set; }
    }
    

}
