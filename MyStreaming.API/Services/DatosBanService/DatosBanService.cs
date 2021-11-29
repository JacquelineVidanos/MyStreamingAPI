using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.DatosBanService
{
    public class DatoBanService : IDatoBanService
    {
        public MyStreamingContext _myStreamingDbContext;
        public DatoBanService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        public DatoBan AddDatoBan(DatoBan dtoBan)
        {
            _myStreamingDbContext.datos_bancarios.Add(dtoBan);
            _myStreamingDbContext.SaveChanges();
            return dtoBan;
        }

        public string DeleteDatoBan(int id)
        {
            string mensaje = "";
            DatoBan DtB = _myStreamingDbContext.datos_bancarios.FirstOrDefault(x => x.id == id);
            if (DtB != null)
            {
                DtB.activo = false;
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;
        }

        public DatoBan GetDatoBan(int id)
        {
            DatoBan DtB = _myStreamingDbContext.datos_bancarios.Where(x => x.id == id&& x.activo == true).First();
            if (DtB == null)
            {
                return null;
            }

            return DtB;
        }

        public List<DatoBan> GetDatosBan()
        {
            return _myStreamingDbContext.datos_bancarios.Where(x => x.activo == true).ToList();
        }

        public List<DatoBan> GetDatosBanPorUsuario(int idUsu)
        {
            List<DatoBan> DtB = _myStreamingDbContext.datos_bancarios.Where(x => x.id_usuario == idUsu && x.activo == true).ToList();
            if (DtB == null)
            {
                return null;
            }

            return DtB;
        }

        public void UpdateDatoBan(DatoBan dtoBan)
        {
            _myStreamingDbContext.datos_bancarios.Update(dtoBan);
            _myStreamingDbContext.SaveChanges();
        }
        #endregion
    }
}
