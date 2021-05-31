using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gonzalez_Rodrigo_lppa_parcial1.RG.Business
{
    public class AfiliadoBiz
    {

        public void Agregar(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Create(model);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Afiliados> Listar()
        {
            var db = new BaseDataService<Afiliados>();
            var lista = db.Get();
            return lista;
        }

        public Afiliados Get(int id)
        {
            var db = new BaseDataService<Afiliados>();
            return db.GetById(id);
        }

        public void Eliminar(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Delete(model);
        }

        public void Update(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Update(model);
        }
    }
}