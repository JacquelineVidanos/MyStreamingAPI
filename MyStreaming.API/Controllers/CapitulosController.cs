using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.Services.CapitulosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapitulosController : Controller
    {
        private readonly ICapituloService _capituloService;
        public CapitulosController(ICapituloService capituloService)
        {
            _capituloService = capituloService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Capitulos/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Capitulos/GetCapitulos")]
        public IEnumerable<Capitulos> GetCapitulos()
        {
            return _capituloService.GetCapitulos();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Capitulos/GetCapitulo")]
        public Capitulos GetCapitulo(int id)
        {
            return _capituloService.GetCapitulo(id);
        }
        //obtener capitulos de una temporada
        [HttpGet]
        [Route("[action]")]
        [Route("api/Capitulos/GetCapsPorTemp")]
        public List<Capitulos> GetCapsPorTemp(int idTem)
        {            
            return _capituloService.GetCapsPorTemp(idTem);
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/Capitulos/AddCapitulo")]
        public IActionResult AddCapitulo(Capitulos capitulo)
        {
            _capituloService.AddCapitulo(capitulo);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Capitulos/UpdateCapitulo")]
        public IActionResult UpdateCapitulo(Capitulos capitulo)
        {
            _capituloService.UpdateCapitulo(capitulo);
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Capitulos/DeleteCapitulo")]
        public IActionResult DeleteCapitulo(int id)
        {
            string mensaje = _capituloService.DeleteCapitulo(id);
            return Ok(mensaje);
        }
    }
}
