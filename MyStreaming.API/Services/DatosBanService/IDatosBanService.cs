using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.DatosBanService
{
    public interface IDatoBanService
    {
        DatoBan AddDatoBan(DatoBan dtoBan);
        List<DatoBan> GetDatosBan();
        void UpdateDatoBan(DatoBan dtoBan);
        string DeleteDatoBan(int id);
        DatoBan GetDatoBan(int id);
        List<DatoBan> GetDatosBanPorUsuario(int idUsu);
    }
}
