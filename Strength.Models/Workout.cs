using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength.Models
{
   public class Workout
    {
        public int workoutId { get; set; }
        public string workoutName { get; set; }
        public List<Excercise> Exercises { get; set; }

        public Workout(string name)
        {
            this.workoutName = name;
      }

        public override string ToString()
        {
            return $"{workoutName}\n{Exercises}";
        }
    }
}
