using Microsoft.AspNetCore.Mvc;
using MyStreaming.API.Model;
using MyStreaming.API.UsuariosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuariosService;
        public UsuariosController(IUsuarioService usuariosService)
        {
            _usuariosService = usuariosService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Usuarios/IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Usuarios/GetUsuarios")]
        public IEnumerable<Usuarios> GetUsuarios()
        {
            return _usuariosService.GetUsuarios();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Usuarios/GetUsuario")]
        public Usuarios GetUsuario(int id)
        {
            return _usuariosService.GetUsuario(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Usuarios/AddUsuario")]
        public IActionResult AddUsuario(Usuarios usuario)
        {
            _usuariosService.AddUsuario(usuario);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Usuarios/UpdateUsuario")]
        public IActionResult DeleteUsuario(Usuarios usuario)
        {
            _usuariosService.UpdateUsuario(usuario);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Usuarios/DeleteUsuario")]
        public IActionResult DeleteUsuario(int id)
        {
            string mensaje = _usuariosService.DeleteUsuario(id);
            return Ok(mensaje);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Usuarios/LoginUsuario")]
        public IActionResult LoginUsuario(string usu, string pass)
        {
            Usuarios mensaje = _usuariosService.LoginUsuario(usu,pass);
            return Ok(mensaje);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Usuarios/LoginAdm")]
        public IActionResult LoginAdm(string usu, string pass)
        {
            Usuarios mensaje = _usuariosService.LoginAdm(usu, pass);
            return Ok(mensaje);
        }
    }
}
