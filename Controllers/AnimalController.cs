using ClaseAbstracta.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClaseAbstracta.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnimalController : Controller
    {
     
            private readonly Dictionary<string, Animal> _animales = new Dictionary<string, Animal>
    {
        { "perro", new Perro { Nombre = "Rex", Edad = 5 } },
        { "gato", new Gato { Nombre = "Miau", Edad = 3 } }
    };

            [HttpGet("{tipo}")]
            public ActionResult<string> GetAnimal(string tipo)
            {
                if (_animales.ContainsKey(tipo))
                {
                    var animal = _animales[tipo];
                    return animal.Datos();
                }
                return NotFound("Animal no encontrado.");
            }

            [HttpGet("{tipo}/dormir")]
            public ActionResult<string> Dormir(string tipo)
            {
                if (_animales.ContainsKey(tipo))
                {
                    var animal = _animales[tipo];
                    return animal.Dormir();
                }
                return NotFound("Animal no encontrado.");
            }

            [HttpGet("{tipo}/comer")]
            public ActionResult<string> Comer(string tipo)
            {
                if (_animales.ContainsKey(tipo))
                {
                    var animal = _animales[tipo];
                    return animal.Comer();
                }
                return NotFound("Animal no encontrado.");
            }
        }

    }

