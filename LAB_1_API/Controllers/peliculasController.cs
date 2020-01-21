using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace LAB_1_API.Controllers
{
    public class peliculasController : ControllerBase
    {
        [HttpGet]
        [Route("api/Pelicula")]
        public ActionResult<string> Peliculas()
        {
            var peli = Estructuras.Almacenamiento.Instance.mostrar();

            var json = JsonConvert.SerializeObject(peli);
            return json;
        }
        //[HttpPost]
        //public void llenado(string name, int date, string manager)
        //{
        //    Estructuras.Almacenamiento.Instance.llenado_pila(name, date, manager);
        //}
        [HttpPost]
        public void post([FromBody] object info)
        {
           
        }
    }
}