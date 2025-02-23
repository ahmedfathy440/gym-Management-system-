using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEf.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? Phone { get; set; }
        public decimal? Salary { get; set; }

        public ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
