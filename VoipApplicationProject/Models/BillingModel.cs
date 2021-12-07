using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoipApplicationProject.Models
{
    public class Billing
    {
        public IEnumerable<BillingModel> BillingModel { get; set; }
        public IEnumerable<MenuAccessModel> MenuAccessModels { get; set; }

    }
    public class BillingModel
    {
        public int Sr_No { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Type { get; set; }
        
        [Required]
        public Balance Amount{ get; set; }
        public string TransactionId { get; set; }
        public bool Status { get; set; }
        public BillingModel[] data { get; set; }
    }
    public enum Balance
    {
        value1 = 50,
        value2 = 100,
        value3 = 150,
        value4 = 200,
        value5 = 250,

    }
}
