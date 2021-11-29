using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.AlertasService
{
    public class AlertaService : IAlertaService
    {
        public MyStreamingContext _myStreamingDbContext;
        public AlertaService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        public Alertas AddAlerta(Alertas alerta)
        {
            _myStreamingDbContext.alertas.Add(alerta);
            _myStreamingDbContext.SaveChanges();
            return alerta;
        }

        public string DeleteAlerta(int id)
        {
            string mensaje = "";
            Alertas ale = _myStreamingDbContext.alertas.FirstOrDefault(x => x.id == id);
            if (ale != null)
            {
                ale.estatus = false;
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;
        }

        public List<Alertas> GetAlertas()
        {
            return _myStreamingDbContext.alertas.Where(x => x.estatus == true).ToList();
        }

        public void UpdateAlerta(Alertas alerta)
        {
            _myStreamingDbContext.alertas.Update(alerta);
            _myStreamingDbContext.SaveChanges();
        }
        #endregion
    }
}
