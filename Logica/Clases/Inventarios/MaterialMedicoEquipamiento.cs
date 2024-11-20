using Datos;

namespace Logica.Clases.Historiales
{
    public class MaterialMedicoEquipamiento
    {
        public string Nombre;
        public string Descripcion;
        public int Cantidad;
        public DateTime Fecha_Mantenimiento;
        public decimal Precio_Unitario;

        public MaterialMedicoEquipamiento(
            string nombre,
            string descripcion,
            int cantidad,
            DateTime fechaMantenimiento,
            decimal precioUnitario)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Fecha_Mantenimiento = fechaMantenimiento;
            Precio_Unitario = precioUnitario;
        }

        Connection connection = new();

        public bool agregarMaterialMedicoEquipamiento()
        {
            return connection.AgregarMaterialMedico(Nombre, Descripcion, Cantidad, Fecha_Mantenimiento, Precio_Unitario);
        }
    }
}
