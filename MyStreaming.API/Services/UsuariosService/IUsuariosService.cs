using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.UsuariosService
{
    public interface IUsuarioService
    {
        Usuarios AddUsuario(Usuarios usuario);
        List<Usuarios> GetUsuarios();
        void UpdateUsuario(Usuarios usuario);
        string DeleteUsuario(int id);
        Usuarios LoginUsuario(string usu, string pass);
        Usuarios LoginAdm(string usu, string pass);
        Usuarios GetUsuario(int id);

    }
}
