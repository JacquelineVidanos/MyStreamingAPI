using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.AlertasService
{
    //el nombre de la interfaz tiene que ser singular para que no cree conflicto con el namespace
    public interface IAlertaService
    {
        Alertas AddAlerta(Alertas alerta);
        List<Alertas> GetAlertas();
        void UpdateAlerta(Alertas alerta);
        string DeleteAlerta(int id);
    }
}
