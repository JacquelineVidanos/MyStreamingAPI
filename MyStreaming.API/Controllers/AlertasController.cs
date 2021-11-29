using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.Services.AlertasService;
using System.Collections.Generic;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertasController : Controller
    {
        private readonly IAlertaService _alertasService;
        public AlertasController(IAlertaService alertasService)
        {
            _alertasService = alertasService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Alertas/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Alertas/GetAlertas")]
        public IEnumerable<Alertas> GetAlertas()
        {
            return _alertasService.GetAlertas();
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/Alertas/AddAlerta")]
        public IActionResult AddAlerta(Alertas alerta)
        {
            _alertasService.AddAlerta(alerta);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Alertas/UpdateAlerta")]
        public IActionResult UpdateAlerta(Alertas alertas)
        {
            _alertasService.UpdateAlerta(alertas);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Alertas/DeleteAlerta")]
        public IActionResult DeleteAlerta(int id)
        {
            string mensaje = _alertasService.DeleteAlerta(id);
            return Ok(mensaje);
        }

    }
}
