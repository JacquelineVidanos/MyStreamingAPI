using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.SuscripcionesService
{
    public class SuscripcionService : ISuscripcionService
    {
        public MyStreamingContext _myStreamingDbContext;
        public SuscripcionService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        
        public string DeleteSuscripcion(int id)
        {
            string mensaje = "";
            Suscripciones sus = _myStreamingDbContext.suscripcion.FirstOrDefault(x => x.id == id);
            if (sus != null)
            {
                sus.pagado = false;
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;
        }

        public List<Suscripciones> GetSuscripciones()
        {
            return _myStreamingDbContext.suscripcion.Where(x => x.pagado == true).ToList();
        }

        public List<Suscripciones> GetSuscripcionesPorUsu(int idUsu)
        {
            List<Suscripciones> cap = _myStreamingDbContext.suscripcion.Where(x => x.id_usuario == idUsu).ToList();
            if (cap == null)
            {
                return null;
            }

            return cap;
        }

        public void UpdateSuscripcion(Suscripciones suscripcion)
        {
            _myStreamingDbContext.suscripcion.Update(suscripcion);
            _myStreamingDbContext.SaveChanges();
        }
        #endregion
    }
}
