using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength.Models
{
   public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }
        [Required]
        public string WorkoutName { get; set; }

        public virtual ICollection<Excercise> Exercises { get; set; }

        

        public override string ToString()
        {
            return $"{WorkoutName}\n{Exercises}";
        }
    }
}
