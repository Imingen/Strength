﻿using Strength.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strength.DataAccess
{
    public class StrengthContext : DbContext
    {
        public StrengthContext() :
            base("StrengthTest")
        {
            this.Configuration.ProxyCreationEnabled = false;    
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().HasMany<Exercise>(e => e.Exercises).WithMany(w => w.workouts).Map(cs =>
            {
                cs.MapLeftKey("WorkoutId");
                cs.MapRightKey("ExerciseId");
                cs.ToTable("Workout_Has_Exercises");
            });
            }
    }
}
