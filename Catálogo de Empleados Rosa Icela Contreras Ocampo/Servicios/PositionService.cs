using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Servicios
{
    public class PositionService
    {
        public static List<PositionsRosa> getAll()
        {
            try
            {
                List<PositionsRosa> listPositions = new List<PositionsRosa>();
                using (var db = new DB_ITSEntities()) 
                {
                    listPositions = db.PositionsRosa.ToList();
                }
                return listPositions;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error al intentar traer la lista de posiciones");
                throw;
            }
        }
    }
}