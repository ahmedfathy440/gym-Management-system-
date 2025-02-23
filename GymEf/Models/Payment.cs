using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEf.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? payEndDate { get; set; }
        public int? memberId { get; set; }
        public Member member { get; set; }
    }
}
