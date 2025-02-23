using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEf.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string? ClassName { get; set; }
        public string? Schedule { get; set; }
        public int? MaxCapacity { get; set; } = 20;
        public int? TrainerID { get; set; }
        public Trainer Trainer { get; set; }
        public ICollection<Member> Members { get; set; }=new List<Member>();
    }
}
