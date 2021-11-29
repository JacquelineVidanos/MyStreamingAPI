using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.TemporadasService
{
    public class TemporadaService : ITemporadaService
    {
        public MyStreamingContext _myStreamingDbContext;
        public TemporadaService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        public Temporadas AddTemporada(Temporadas temporada)
        {
            _myStreamingDbContext.temporadas.Add(temporada);
            _myStreamingDbContext.SaveChanges();
            return temporada;
        }

        public Temporadas GetTemporada(int id)
        {
            Temporadas tem = _myStreamingDbContext.temporadas.Where(x => x.id == id).First();
            if (tem == null)
            {
                return null;
            }

            return tem;
        }

        public List<Temporadas> GetTemporadas()
        {
            return _myStreamingDbContext.temporadas.ToList();
        }
        #endregion
    }
}
