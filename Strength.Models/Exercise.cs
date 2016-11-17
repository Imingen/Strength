using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Strength.Models
{

    public enum Categories
    {
        Chest,
        Back,
        Shoulder,
        Legs,
        Arms
    }

    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }
        [Required]
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public byte[] Image{ get; set; }

        public Categories Category { get; set; }
        public virtual ICollection<Workout> workouts { get; set; }


        public override string ToString()
        {
            return $"{ExerciseName} - {Category}\n{ExerciseDescription}";
        }

    }
}   
