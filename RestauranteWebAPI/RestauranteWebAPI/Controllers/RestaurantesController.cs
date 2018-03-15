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
using RestauranteWebAPI.Models;
using RestauranteWebAPP.DAL;

namespace RestauranteWebAPI.Controllers
{
    public class RestaurantesController : ApiController
    {
        //Objeto responsavel pela manipulação dos dados
        private Context db = new Context();

        // GET: api/Restaurantes
        public IQueryable<Restaurantes> GetRestaurantes()
        {
            return db.Restaurantes;
        }

        // GET: api/Restaurantes/5
        [ResponseType(typeof(Restaurantes))]
        public IHttpActionResult GetRestaurantes(string id)
        {
            Restaurantes restaurantes = db.Restaurantes.Find(id);
            if (restaurantes == null)
            {
                return NotFound();
            }

            return Ok(restaurantes);
        }

        // PUT: api/Restaurantes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRestaurantes(string id, Restaurantes restaurantes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != restaurantes.NomeRestauranteID)
            {
                return BadRequest();
            }

            db.Entry(restaurantes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantesExists(id))
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

        // POST: api/Restaurantes
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                Restaurantes novo = new Restaurantes();
                novo.NomeRestauranteID = nome;
                db.Restaurantes.Add(novo);
                db.SaveChanges();
            }

        }

        // DELETE: api/Restaurantes/5
        [ResponseType(typeof(Restaurantes))]
        public IHttpActionResult DeleteRestaurantes(string id)
        {
            Restaurantes restaurantes = db.Restaurantes.Find(id);
            if (restaurantes == null)
            {
                return NotFound();
            }

            db.Restaurantes.Remove(restaurantes);
            db.SaveChanges();

            return Ok(restaurantes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RestaurantesExists(string id)
        {
            return db.Restaurantes.Count(e => e.NomeRestauranteID == id) > 0;
        }
                        
    }
}




