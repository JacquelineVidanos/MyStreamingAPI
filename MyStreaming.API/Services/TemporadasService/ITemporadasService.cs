using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.TemporadasService
{
    public interface ITemporadaService
    {
        Temporadas AddTemporada(Temporadas temporada);
        List<Temporadas> GetTemporadas();
        Temporadas GetTemporada(int id);
    }
}
