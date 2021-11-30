using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.Services.SuscripcionesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuscripcionesController : Controller
    {
        private readonly ISuscripcionService _suscripcionService;
        public SuscripcionesController(ISuscripcionService suscripcionService)
        {
            _suscripcionService = suscripcionService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Suscripciones/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Suscripciones/DeleteSuscripcion")]
        public IActionResult DeleteSuscripcion(int id)
        {
            string mensaje = _suscripcionService.DeleteSuscripcion(id);
            return Ok(mensaje);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Suscripciones/GetSuscripciones")]
        public IEnumerable<Suscripciones> GetSuscripciones()
        {
            return _suscripcionService.GetSuscripciones().ToList();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Suscripciones/GetSuscripcionesPorUsu")]
        public IEnumerable<Suscripciones> GetSuscripcionesPorUsu(int idUsu)
        {
            return _suscripcionService.GetSuscripcionesPorUsu(idUsu).ToList();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Suscripciones/UpdateSuscripcion")]
        public IActionResult UpdateSuscripcion(Suscripciones suscripcion)
        {
            _suscripcionService.UpdateSuscripcion(suscripcion);
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Suscripciones/GetNumSus")]
        public int GetNumSus()
        {
            return _suscripcionService.GetNumSus();
        }
    }
}
