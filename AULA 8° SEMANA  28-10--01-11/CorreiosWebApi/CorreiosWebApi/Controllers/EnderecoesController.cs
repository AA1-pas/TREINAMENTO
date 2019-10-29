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
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecoesController : ApiController
    {
        private CorreiosContext db = new CorreiosContext();

        // GET: api/Enderecoes
        public IQueryable<Endereco> GetCorreios()
        {
            return db.Correios;
        }

        [HttpGet]
        [Route("Api/Enderecos/{cep}/Info")]
        public IQueryable<Endereco> EnderecosByCep(int cep)
        {
            return db.Correios.Where(x => x.CEP == cep);
        }

        [HttpGet]
        [Route("Api/Enderecos/{bairro}/InfoBairro")]
        public IQueryable<Endereco> EnderecosByBairro(string bairro)
        {
            return db.Correios.Where(x => x.Bairro == bairro);
        }

        [HttpGet]
        [Route("Api/Enderecos/{Logradouro}/InfoLogradouro")]
        public IQueryable<Endereco> EnderecosByLogradouro(string logradouro)
        {
            return db.Correios.Where(x => x.Logradouro == logradouro);
        }


        [HttpGet]
        [Route("Api/Enderecos/{Complemento}/InfoComplemento")]
        public IQueryable<Endereco> EnderecosByComplemento(string complemento)
        {
            return db.Correios.Where(x => x.Complemento == complemento);
        }


        [HttpGet]
        [Route("Api/Enderecos/{Municipio}/InfoMunicipio")]
        public IQueryable<Endereco> EnderecosByMunicipio(string municipio)
        {
            return db.Correios.Where(x => x.Municipio == municipio);
        }

        [HttpGet]
        [Route("Api/Enderecos/{Uf}/InfoUf")]
        public IQueryable<Endereco> EnderecosByUf(string uf)
        {
            return db.Correios.Where(x => x.UF == uf);
        }

        // GET: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Correios.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Key)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update Realizado com sucesso!");
        }

        // POST: api/Enderecoes
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Correios.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Key }, endereco);
        }

        // DELETE: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Correios.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Correios.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Correios.Count(e => e.Key == id) > 0;
        }
    }
}