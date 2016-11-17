using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Strength.DataAccess;
using Strength.Models;

namespace Strength.DataService.Controllers
{
    public class ExcercisesController : ApiController
    {
        private StrengthContext db = new StrengthContext();

        // GET: api/Excercises
        public IQueryable<Exercise> GetExercises()
        {
            return db.Exercises;
        }

        // GET: api/Excercises/5
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult GetExcercise(int id)
        {
            Exercise excercise = db.Exercises.Find(id);
            if (excercise == null)
            {
                return NotFound();
            }

            return Ok(excercise);
        }

        // PUT: api/Excercises/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExcercise(int id, Exercise excercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != excercise.ExerciseId)
            {
                return BadRequest();
            }

            db.Entry(excercise).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcerciseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Excercises
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult PostExcercise(Exercise excercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Exercises.Add(excercise);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = excercise.ExerciseId }, excercise);
        }

        // DELETE: api/Excercises/5
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult DeleteExcercise(int id)
        {
            Exercise excercise = db.Exercises.Find(id);
            if (excercise == null)
            {
                return NotFound();
            }

            db.Exercises.Remove(excercise);
            db.SaveChanges();

            return Ok(excercise);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExcerciseExists(int id)
        {
            return db.Exercises.Count(e => e.ExerciseId == id) > 0;
        }
    }
}