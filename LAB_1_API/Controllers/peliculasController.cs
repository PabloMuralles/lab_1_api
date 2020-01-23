using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace LAB_1_API.Controllers
{
    public class peliculasController : ControllerBase
    {

        private static Estructuras.Almacenamiento estructura = new Estructuras.Almacenamiento();

        [HttpGet]
        [Route("api/Pelicula")]
        public ActionResult<string> Peliculas()
        {
            if (estructura == null)
                return NotFound("No hay datos.");
            var peli = estructura.mostrar();
            var json = JsonConvert.SerializeObject(peli);
            return json;
        }

        [HttpPost]
        [Route("api/post")]
        public ActionResult Create([FromBody] Peliculas pelicula)
        {
            if (ModelState.IsValid)
            {
                estructura.llenado_pila(pelicula.Name, pelicula.Year, pelicula.Director);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}