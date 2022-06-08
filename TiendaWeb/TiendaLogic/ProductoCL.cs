using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDatos;
using TiendaOnline;

namespace TiendaLogic
{
    public class ProductoCL
    {
        public static List<PRODUCTO> Listar()
        {
            using(var db = new DB_CARRITOEntities())
            {
                return db.PRODUCTO.ToList();
            }
        }
    }
}
