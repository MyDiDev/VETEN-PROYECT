using Datos;

namespace Logica.Clases.Inventarios
{
    public class MedicamentosVacunas
    {
        private string Nombre;
        private string Descripcion;
        private string Lote;
        private DateTime Fecha_Caducidad;
        private string Dosis_Recomendada;
        private int Cantidad;
        private decimal Precio_Unitario;

        public MedicamentosVacunas(
               string nombre,
               string descripcion,
               string lote,
               DateTime fechaCaducidad,
               string dosisRecomendada,
               int cantidad,
               decimal precioUnitario)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Lote = lote;
            Fecha_Caducidad = fechaCaducidad;
            Dosis_Recomendada = dosisRecomendada;
            Cantidad = cantidad;
            Precio_Unitario = precioUnitario;
        }

        Connection connection = new();

        public bool agregarMedicamentoVacuna()
        {
            return connection.AgregarMedicamentoVacuna(Nombre, Descripcion, Lote, Fecha_Caducidad, Dosis_Recomendada, Cantidad, Precio_Unitario);
        }
    }
}