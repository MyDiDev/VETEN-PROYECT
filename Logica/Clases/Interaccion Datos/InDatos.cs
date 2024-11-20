using Datos;
using System.Data;

namespace Logica.Clases.Interaccion_Datos
{
    public class InDatos
    {
        public InDatos() { }

        Connection connection = new();

        public bool eliminarRegistro(string tabla, string columnId, int id)
        {
            return connection.EliminarRegistro(tabla, columnId, id);
        }

        public DataTable buscarRegistro(string tabla, string orColumn, string orValue, string orColumnId, int orId)
        {
            return connection.SearchRegistro(tabla, orColumn, orValue, orColumnId, orId);
        }

        public DataTable buscarRegistro(string tabla, string orColumnId, int orId)
        {
            return connection.SearchRegistro(tabla, orColumnId, orId);
        }
    }
}