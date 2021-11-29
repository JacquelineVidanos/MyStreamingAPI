using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.SuscripcionesService
{
    public interface ISuscripcionService
    {
        List<Suscripciones> GetSuscripciones();
        void UpdateSuscripcion(Suscripciones suscripcion);
        string DeleteSuscripcion(int id);
        List<Suscripciones> GetSuscripcionesPorUsu(int idUsu);
    }
}
