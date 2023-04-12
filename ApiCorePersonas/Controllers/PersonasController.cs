using ApiCorePersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorePersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;

        public PersonasController() 
        {
            this.personas = new List<Persona>
            {
                new Persona {IdPersona = 1, Nombre ="Luis", 
                    Email = "luis@gmail.com",Edad = 40},
                new Persona {IdPersona = 2, Nombre ="Sara",
                    Email = "sara@gmail.com",Edad = 20},
                new Persona {IdPersona = 3, Nombre ="Jose",
                    Email = "jose@gmail.com",Edad = 33},
                new Persona {IdPersona = 4, Nombre ="Marta",
                    Email = "marta@gmail.com",Edad = 16},

            };
        
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;
        }

        [HttpGet("{ID}")]
        public ActionResult<Persona> FindPersona(int id) 
        {
            return this.personas.FirstOrDefault(x => x.IdPersona == id);
        }


    }
}
