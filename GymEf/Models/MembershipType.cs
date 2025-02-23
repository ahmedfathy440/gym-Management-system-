using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEf.Models
{
    public class MembershipType
    {
        public int MembershipTypeID { get; set; }
        public string? TypeName { get; set; }
        public decimal? Price { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
