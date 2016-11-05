using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public virtual ICollection<Excercise> excercises { get; set; }

        public Category(string name)
        {
            this.categoryName = name;
        }

        public override string ToString()
        {
            return $"{categoryName}";
        }
    }
}
