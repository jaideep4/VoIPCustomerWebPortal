using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 namespace VoipApplicationProject.Models
{
    public class PaymentModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        public int Card_No { get; set; }
        [Required]
        public DateTime Expiry_Date { get; set; }   
    }
}
