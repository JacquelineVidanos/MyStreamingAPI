using MyStreaming.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Services.CapitulosService
{
    public class CapituloService : ICapituloService
    {
        public MyStreamingContext _myStreamingDbContext;
        public CapituloService(MyStreamingContext myStreamingDbContext)
        {
            _myStreamingDbContext = myStreamingDbContext;
        }
        #region Metodos
        public Capitulos AddCapitulo(Capitulos capitulo)
        {
            _myStreamingDbContext.capitulo.Add(capitulo);
            _myStreamingDbContext.SaveChanges();
            return capitulo;
        }

        public string DeleteCapitulo(int id)
        {
            /*var cap = new Capitulos { id = id, estatus = 0 };
            _myStreamingDbContext.capitulo.Attach(cap).Property(x => x.estatus).IsModified = true;
            _myStreamingDbContext.SaveChanges();*/

            string mensaje = "";
            Capitulos cap = _myStreamingDbContext.capitulo.FirstOrDefault(x => x.id == id);
            if (cap != null)
            {
                cap.estatus = 0;
                _myStreamingDbContext.SaveChanges();
                mensaje = "Operación exitosa";
            }
            else
            {
                mensaje = "Este usuario no existe";
            }
            return mensaje;
        }

        public List<Capitulos> GetCapitulos()
        {
            return _myStreamingDbContext.capitulo.Where(x => x.estatus == 1).ToList();
        }

        public Capitulos GetCapitulo(int id)
        {
            //Capitulos cap = _myStreamingDbContext.capitulo.Find(id);
            Capitulos cap = _myStreamingDbContext.capitulo.Where(x => x.id == id).First();
            if (cap == null)
            {
                return null;
            }

            return cap;
        }

        public List<Capitulos> GetCapsPorTemp(int idTem)
        {
            //Capitulos cap = _myStreamingDbContext.capitulo.Find(id);
            List<Capitulos> cap = _myStreamingDbContext.capitulo.Where(x => x.id_temporada == idTem).ToList();
            if (cap == null)
            {
                return null;
            }

            return cap;
        }
        public void UpdateCapitulo(Capitulos capitulo)
        {
            _myStreamingDbContext.capitulo.Update(capitulo);
            _myStreamingDbContext.SaveChanges();
        }
        #endregion
    }
}
