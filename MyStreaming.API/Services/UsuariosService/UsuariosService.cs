using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStreaming.API.UsuariosService
{
    
    public class UsuarioService : IUsuarioService
    {
        public MyStreamingContext _myStreamingDbContext;
        public UsuarioService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        public Usuarios AddUsuario(Usuarios usuario)
        {
            _myStreamingDbContext.usuario.Add(usuario);
            _myStreamingDbContext.SaveChanges();
            return usuario;
        }
        public List<Usuarios> GetUsuarios()
        {
            return _myStreamingDbContext.usuario.ToList();
        }
        public void UpdateUsuario(Usuarios usuario)
        {
            _myStreamingDbContext.usuario.Update(usuario);
            _myStreamingDbContext.SaveChanges();            
        }
        public string DeleteUsuario(int id)
        {
            string mensaje = "";
            Usuarios cap = _myStreamingDbContext.usuario.FirstOrDefault(x => x.id == id);
            if (cap != null)
            {
                cap.estatus = false;
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;
            /*string mensaje = "";
            Usuarios usu = _myStreamingDbContext.usuario.FirstOrDefault(x => x.id == id);
            if(usu != null)
            {
                _myStreamingDbContext.Remove(id);
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;*/
        }
        public Usuarios LoginUsuario(string usu, string pass)
        {
            try
            {
                Usuarios us = _myStreamingDbContext.usuario.Where(b => b.correo == usu && b.contrasenia == pass&& b.tipo_usuario==2 && b.estatus == true).First();
                return us;                
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        public Usuarios LoginAdm(string usu, string pass)
        {
            try
            {
                Usuarios us = _myStreamingDbContext.usuario.Where(b => b.correo == usu && b.contrasenia == pass && b.tipo_usuario == 1 && b.estatus == true).First();
                return us;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public Usuarios GetUsuario(int id)
        {
            //Capitulos cap = _myStreamingDbContext.capitulo.Find(id);
            Usuarios usu = _myStreamingDbContext.usuario.Where(x => x.id == id).First();
            if (usu == null)
            {
                return null;
            }

            return usu;
        }

        #endregion
    }
}
