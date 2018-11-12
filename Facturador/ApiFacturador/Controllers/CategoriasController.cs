using Core.Service;
using Core.Serviceimpl;
using Infaestructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiFacturador.Controllers
{
    public class CategoriasController : ApiController
    {
        private CategoriaService categoriasService;

        public CategoriasController()
        {
            categoriasService = new CategoriaServiceImpl();
        }


        // GET: api/Categorias
        public IEnumerable<Categoria> GetCategoria()
        {
            return categoriasService.FindAll();
        }

        // GET: api/Categorias/5
        public IHttpActionResult GetCategoria(int id)
        {

            Categoria categoria = categoriasService.FindById(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // PUT: api/Categorias/5
        public IHttpActionResult PutCategoria(int id, [FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            Categoria cate = categoriasService.FindById(id);

            if (cate != null)
            {
                cate.Id = id;
                cate.Nombre = categoria.Nombre;
                categoriasService.Update(cate);
                return Ok("OK");
            }
            else
            {
                return StatusCode(HttpStatusCode.NoContent);
            }

        }

        // POST: api/Categorias
        public IHttpActionResult PostCategoria([FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            categoriasService.Save(categoria);
            return CreatedAtRoute("DefaultApi", new { id = categoria.Id }, categoria);
        }

        // DELETE: api/Categorias/5
        public IHttpActionResult DeleteCategoria(int id)
        {
            Categoria categoria = categoriasService.FindById(id);
            if (categoria == null)
            {
                return NotFound();
            }

            categoriasService.Delete(categoria);

            return Ok(categoria);
        }
    }
}
