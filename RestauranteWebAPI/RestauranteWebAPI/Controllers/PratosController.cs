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
    public class PratosController : ApiController
    {
        //Objeto responsavel pela manipulação dos dados
        private Context db = new Context();

        // GET: api/Pratos
        public IQueryable<Pratos> GetPratos()
        {
            return db.Pratos;
        }

        // GET: api/Pratos/5
        [ResponseType(typeof(Pratos))]
        public IHttpActionResult GetPratos(string id)
        {
            Pratos pratos = db.Pratos.Find(id);
            if (pratos == null)
            {
                return NotFound();
            }

            return Ok(pratos);
        }

        // PUT: api/Pratos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPratos(string id, Pratos pratos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pratos.NomePrato)
            {
                return BadRequest();
            }

            db.Entry(pratos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PratosExists(id))
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

        // POST: api/Pratos
        public void Post(string nome, float preco, string nome_restaurante)
        {
            Restaurantes auxiliar = new Restaurantes();
            auxiliar = db.Restaurantes.Find(nome_restaurante);

            if (auxiliar != null)
            {
                Pratos novo = new Pratos();
                novo.NomePrato = nome;
                novo.NomeRestauranteID = auxiliar.NomeRestauranteID;
                novo.PrecoPrato = preco;


                db.Pratos.Add(novo);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("restaurante não existe, tente com um nome valido");
            }

        }

        // DELETE: api/Pratos/5
        [ResponseType(typeof(Pratos))]
        public IHttpActionResult DeletePratos(string id)
        {
            Pratos pratos = db.Pratos.Find(id);
            if (pratos == null)
            {
                return NotFound();
            }

            db.Pratos.Remove(pratos);
            db.SaveChanges();

            return Ok(pratos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PratosExists(string id)
        {
            return db.Pratos.Count(e => e.NomePrato == id) > 0;
        }

        
        }
    }



