using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength.Models
{
   public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Compound { get; set; }
        public bool Isolation { get; set; }

        public virtual ICollection<Excercise> Excersices { get; set; }
    }
}
