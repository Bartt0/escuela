using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escuela.Models;
using Microsoft.AspNetCore.Mvc;

namespace escuela.Controllers
{
    [ApiController]
    [Route("api/alumno")]
    public class AlumnoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Alumno>>Get()
        {
            return new List<Alumno>()
            {
                new Alumno(){Id = 1, Nombre = "Fidel"},
                new Alumno(){Id = 2, Nombre = "Serena"},

            };
        }
    }
}