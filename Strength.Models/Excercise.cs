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
        public string Category { get; set; }

        /*Image prop plez
         * public int MyProperty { get; set; }
         */

        public Excercise(string name, string description, string categ)
        {
            this.ExerciseName = name;
            this.ExcersiceDescription = description;
            this.Category = categ;

        }

        public override string ToString()
        {
            return $"{ExerciseName} - {Category}\n{ExcersiceDescription}";
        }

    }
}
