using System;
using System.Collections.Generic;
using System.Linq;
using MyStreaming.API.Model;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.CapitulosService
{
    public interface ICapituloService
    {
        Capitulos AddCapitulo(Capitulos capitulo);
        List<Capitulos> GetCapitulos();
        List<Capitulos> GetCapsPorTemp(int idTem);
        Capitulos GetCapitulo(int id);
        void UpdateCapitulo(Capitulos capitulo);
        string DeleteCapitulo(int id);
    }
}
