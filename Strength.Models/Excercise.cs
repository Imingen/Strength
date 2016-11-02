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
        public Category category { get; set; }

        /*Image prop plez
         * public int MyProperty { get; set; }
         */

        // public Category Category { get; set; }
        public Excercise(int id, string name, string description, Category categ)
        {
            this.ExerciseId = id;
            this.ExerciseName = name;
            this.ExcersiceDescription = description;
            this.category = categ;

        }

        public override string ToString()
        {
            return $"{ExerciseName}-{category}";
        }


        //maybe make this protected or private
        public enum Category
        {
            Chest = 1,
            Back,
            Shoulder,
            Legs,
            Arms
        }
    }
}
