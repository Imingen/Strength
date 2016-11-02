using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strength.Models
{
    public class Excercise
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExcersiceDescription { get; set; }
        public Category Category { get; set; }

    }
}
