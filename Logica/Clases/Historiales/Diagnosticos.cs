using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Logica.Clases.Historiales
{
    public class Diagnosticos
    {
        public int IdVisita;
        public string Descripcion;
        public DateTime FechaDiagnostico;

        public Diagnosticos(int idVisita, string descripcion, DateTime fechaDiagnostico)
        {
            IdVisita = idVisita;
            Descripcion = descripcion;
            FechaDiagnostico = fechaDiagnostico;
        }

        Connection connection = new();

        public bool agregarDiagnostico()
        {
            return connection.AgregarDiagnostico(IdVisita, Descripcion, FechaDiagnostico);
        }
    }
}
