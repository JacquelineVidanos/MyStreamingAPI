using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.Services.DatosBanService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosBanController : Controller
    {
        private readonly IDatoBanService _datosBanService;
        public DatosBanController(IDatoBanService datosBanService)
        {
            _datosBanService = datosBanService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosBan/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosBan/GetDatosBan")]
        public IEnumerable<DatoBan> GetDatosBan()
        {
            return _datosBanService.GetDatosBan();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosBan/GetDatoBan")]
        public DatoBan GetDatoBan(int id)
        {
            return _datosBanService.GetDatoBan(id);
        }
        //obtener datosbancario de un usuario
        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosBan/GetDatosBanPorUsuario")]
        public List<DatoBan> GetDatosBanPorUsuario(int idUsu)
        {
            return _datosBanService.GetDatosBanPorUsuario(idUsu).ToList();
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosBan/AddDatoBan")]
        public IActionResult AddDatoBan(DatoBan dtoBan)
        {
            _datosBanService.AddDatoBan(dtoBan);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/DatosBan/UpdateDatoBan")]
        public IActionResult UpdateDatoBan(DatoBan dtoBan)
        {
            _datosBanService.UpdateDatoBan(dtoBan);
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/DatosBan/DeleteDatoBan")]
        public IActionResult DeleteDatoBan(int id)
        {
            string mensaje = _datosBanService.DeleteDatoBan(id);
            return Ok(mensaje);
        }
    }
}
