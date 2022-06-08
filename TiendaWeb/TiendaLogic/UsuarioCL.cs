using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnline;
using TiendaDatos;

namespace TiendaLogic
{
   public class UsuarioCL
    {
        //MÉTODO LISTAR
        public static List<USUARIO> Listar()
        {
            using(var db = new DB_CARRITOEntities())
            {
                return db.USUARIO.ToList();
            }
        }

      

        //MÉTODO BUSCAR
        public static USUARIO Buscar(int id)
        {
            using (var db = new DB_CARRITOEntities())
            {
                return db.USUARIO.Find(id);
            }
        }
    }
}
