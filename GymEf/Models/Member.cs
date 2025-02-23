using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEf.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public string Password { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime MembershipEndDate { get; set; }
        public int? MembershipTypeID { get; set; }
        public MembershipType MembershipType { get; set; }
        public int? ClassId { get; set; }
        public Class Class { get; set; }
    }
}
