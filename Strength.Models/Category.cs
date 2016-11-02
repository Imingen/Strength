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

        /*Put these in exercise instead
        public bool Compound { get; set; }
        public bool Isolation { get; set; }
         */

        public Category(int CategoryId, string CategoryName)
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
        }
        
        public virtual ICollection<Excercise> Excercises { get; set; }
    }
}
