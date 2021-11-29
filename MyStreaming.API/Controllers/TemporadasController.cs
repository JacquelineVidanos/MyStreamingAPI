using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.Services.TemporadasService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporadasController : Controller
    {
        private readonly ITemporadaService _temporadaService;
        public TemporadasController(ITemporadaService temporadaService)
        {
            _temporadaService = temporadaService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Temporadas/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Temporadas/GetTemporadas")]
        public IEnumerable<Temporadas> GetTemporadas()
        {
            return _temporadaService.GetTemporadas();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Temporadas/GetTemporada")]
        public Temporadas GetTemporada(int id)
        {
            return _temporadaService.GetTemporada(id);
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Temporadas/AddTemporada")]
        public IActionResult AddTemporada(Temporadas temporada)
        {
            _temporadaService.AddTemporada(temporada);
            return Ok();
        }
    }
}
