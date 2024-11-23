using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;


namespace Datos
{
    public class Connection
    {
        public Connection(){}

        // INVENTARIOS, HISTORIALES Y REGISTROS

        public DataTable GetTable(string tableName)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName};", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);  

                    return dataTable;  
                }
            }
        }

        //MEDICAMENTOS Y VACUNAS

        public bool AgregarMedicamentoVacuna(string nombre,
               string descripcion,
               string lote,
               DateTime fechaCaducidad,
               string dosisRecomendada,
               int cantidad,
               decimal precioUnitario)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand cmd = new($"INSERT INTO Medicamentos_Vacunas (Nombre, Descripcion, Lote, Fecha_Caducidad, Dosis_Recomendada, Cantidad, Precio_Unitario) VALUES('{nombre}', '{descripcion}', '{lote}', '{fechaCaducidad}', '{dosisRecomendada}', {cantidad}, {precioUnitario});",conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        //MATERIAL MEDICO Y EQUIPAMIENTO

        public bool AgregarMaterialMedico(string nombre,
            string descripcion,
            int cantidad,
            DateTime fechaMantenimiento,
            decimal precioUnitario)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Material_Medico_Equipamiento (Nombre, Descripcion, Cantidad, Fecha_Mantenimiento, Precio_Unitario) VALUES('{nombre}', '{descripcion}', {cantidad}, '{fechaMantenimiento}', {precioUnitario});", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        //HISTORIAL MEDICO

        public bool AgregarHistorialMedico(int idPaciente, DateTime fecha, string notasGenerales)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO HistorialMedico (ID_Paciente, Fecha, Notas_Generales) VALUES ({idPaciente}, '{fecha}', '{notasGenerales}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        //DOCUMENTOS ADMINISTRATIVOS
        public bool AgregarDocumentoAdmin(string nombre, string tipo, string descripcion, int cantidad, string formato, DateTime fechaCreacion, DateTime fechaActualizacion, string ubicacion, decimal precioUnitario, int iDProveedor)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Documentos_Materiales_Administrativos (Nombre, Tipo, Descripcion, Cantidad, Formato, Fecha_Creacion, Fecha_Actualizacion, Ubicacion, Precio_Unitario, ID_Proveedor) VALUES ('{nombre}', '{tipo}', '{descripcion}', {cantidad}, '{formato}', '{fechaCreacion}', '{fechaActualizacion}', '{ubicacion}', {precioUnitario}, {iDProveedor});", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        //ALIMENTOS Y SUPLEMENTOS 

        public bool AgregarAlimentoSuplemento(string nombre,
            string descripcion,
            int cantidad,
            decimal precioUnitario)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Alimentos_Suplementos (Nombre, Descripcion, Cantidad, Precio_Unitario) VALUES ('{nombre}', '{descripcion}', {cantidad}, {precioUnitario});", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //PROVEEDORES

        public bool AgregarProveedor(string nombreProveedor,
            string contacto,
            string telefono,
            string email,
            string direccion,
            string condicionesEntrega)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Proveedores (Nombre_Proveedor, Contacto, Telefono, Email, Direccion, Condiciones_Entrega) VALUES ('{nombreProveedor}', '{contacto}', '{telefono}', '{email}', '{direccion}', '{condicionesEntrega}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //PRODUCTOS

        public bool AgregarProducto(string nombre,
            string descripcion,
            int idProveedor,
            double precioUnitario,
            int cantidad)
        {
            try
            {
                using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Productos_Generales (Nombre, Descripcion, ID_Proveedor, Precio_Unitario, Cantidad) VALUES ('{nombre}', '{descripcion}', {idProveedor}, {precioUnitario}, {cantidad});", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }       
        }

        //PACIENTES

        public bool AgregarPaciente(string nombre, string especie, string raza, int edad, string genero, int idCliente)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Pacientes (Nombre, Especie, Raza, Edad, Genero, ID_Cliente) VALUES ('{nombre}', '{especie}', '{raza}', {edad}, '{genero}', {idCliente});", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // CITAS

        public bool PlanearCita(int IdCliente, int IdMascota, int IdPersonal, DateTime Fecha, string TipoServicio, string Estado, string Observaciones)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Citas (ID_Cliente, ID_Mascota, ID_Personal, Fecha, Tipo_Servicio, Estado, Observaciones) VALUES({IdCliente}, {IdMascota}, {IdPersonal}, '{Fecha}', '{TipoServicio}', '{Estado}', '{Observaciones}');", conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //CITAS : CITAS/RECORDATORIOS

        public bool AgregarCitaRecordatorio(DateTime fechaHora, string tipo, int idCliente, int idMascota,
                              string motivo, string descripcion, bool notificacionEnviada,
                              DateTime fechaNotificacion, string estado, DateTime creadoEn, DateTime actualizadoEn)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new("INSERT INTO Citas_Recordatorios (Fecha_Hora, Tipo, ID_Cliente, ID_Mascota, Motivo, Descripcion, Notificacion_Enviada, Fecha_Notificacion, Estado, Creado_en, Actualizado_en) VALUES (@FechaHora, @Tipo, @IDCliente, @IDMascota, @Motivo, @Descripcion, @NotificacionEnviada, @FechaNotificacion, @Estado, @CreadoEn, @ActualizadoEn)", conn))
                {
                    cmd.Parameters.AddWithValue("@FechaHora", fechaHora);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@IDCliente", idCliente);
                    cmd.Parameters.AddWithValue("@IDMascota", idMascota);
                    cmd.Parameters.AddWithValue("@Motivo", motivo);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@NotificacionEnviada", notificacionEnviada);
                    cmd.Parameters.AddWithValue("@FechaNotificacion",fechaNotificacion.Date);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@CreadoEn", creadoEn);
                    cmd.Parameters.AddWithValue("@ActualizadoEn", actualizadoEn);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
        }

        public DataTable GetCitasRecordatorios(int ClientID, int PetID)
        {

            DataTable dataTable = new();
            
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new($"SELECT * FROM Citas_Recordatorios WHERE ID_Cliente = {ClientID} AND ID_Mascota = {PetID};", conn))
                    {
                        SqlDataAdapter adapter = new(cmd);

                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception)
            {
                return dataTable;
            }
        }

        //DIAGNOSTICOS  

        public bool AgregarDiagnostico(int idVisita, string descripcion, DateTime fechaDiagnostico)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Diagnosticos (ID_Visita, Descripcion, Fecha_Diagnostico) VALUES({idVisita}, '{descripcion}', '{fechaDiagnostico}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //TRANSACCION

        public bool AgregarTransaccion(int idCliente, DateTime fechaTransaccion, string tipo, string metodoPago, decimal monto, string descripcion, string estado)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Transacciones (ID_Cliente, Fecha_Transaccion, Tipo, Metodo_Pago, Monto, Descripcion, Estado) VALUES ({idCliente}, '{fechaTransaccion}', '{tipo}', '{metodoPago}', {monto}, '{descripcion}', '{estado}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //VISITAS

        public bool AgregarVisita(DateTime fechaVisita, string motivo, decimal peso, decimal temperatura, string notas)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Visitas (Fecha_Visita, Motivo, Peso, Temperatura, Notas) VALUES('{fechaVisita}', '{motivo}', {peso}, {temperatura}, '{notas}');", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //PERSONAL

        public bool AgregarPersonal(string nombre, string cargo, string telefono, string email, string horario_Trabajo, string certificaciones)
        {
            using (SqlConnection conn = new("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Personal (Nombre, Cargo, Telefono, Email, Horario_Trabajo, Certificaciones) VALUES(@Nombre, @Cargo, @Telefono, @Email, @Horario_Trabajo, @Certificaciones);", conn);
                cmd.Parameters.AddWithValue("@Nombre",nombre);
                cmd.Parameters.AddWithValue("@Cargo", cargo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Horario_Trabajo", horario_Trabajo);
                cmd.Parameters.AddWithValue("@Certificaciones", certificaciones);
                cmd.ExecuteNonQuery();
                return true;
            }

        }

        // LOG IN

        //private bool VerifyCont(string password, string hashedPassword)
        //{
        //    return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        //}

        //private string GetHashedPassword(string Name)
        //{
        //    using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
        //    {
        //        conn.Open();
        //        using(SqlCommand cmd = new SqlCommand($"SELECT Clave FROM Clientes WHERE Nombre='{Name}';", conn))
        //        {
        //            object result = cmd.ExecuteScalar();
        //            string Resultado = result.ToString();

        //            conn.Close();

        //            return Resultado;
        //        }
        //    }
        //}

        public string UserType(string userName, string userPassword)
        {
            //string HashedPassword = GetHashedPassword(userName);


            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT Tipo_Usuario FROM Clientes WHERE Nombre='{userName}' AND Clave='{userPassword}';", conn))
                {
                    object result = cmd.ExecuteScalar();
                    string Resultado = result.ToString();
                    return Resultado;
                }
            }
        }

        // USUARIOS 

        //private string HashCont(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}

        public bool AgregarUsuario(string userType, string nombre, string direccion, string telefono, string email, string clave)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();

                //string HashedClave = HashCont(clave);

                SqlCommand cmd = new SqlCommand($"INSERT INTO Clientes (Nombre, Direccion, Telefono, Email, Tipo_Usuario, Clave) VALUES ('{nombre}', '{direccion}', '{telefono}', '{email}', '{userType}', '{clave}');", conn);
                
                cmd.ExecuteNonQuery();

                return true; 
            }
        }

        // MASCOTAS

        public bool AgregarMascota(int idDuenio, string Nombre, string Especie, string Raza, int Edad, string Genero)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Mascotas(Nombre, Especie, Raza, Edad, Genero, ID_Dueno) VALUES ('{Nombre}', '{Especie}', '{Raza}', {Edad}, '{Genero}', {idDuenio});", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // GLOBAL
        public int ConseguirId(string Tabla, string ColumnaTarget, string ColumnaWhere, string ValorWhere)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                int id = -1;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT {ColumnaTarget} FROM {Tabla} WHERE {ColumnaWhere}='{ValorWhere}';", conn);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
                catch (Exception)
                {
                    return 0;
                }

                conn.Close();

                return id;
            }

        }

        public bool EliminarRegistro(string tabla, string columnId, int id)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new($"DELETE FROM {tabla} WHERE {columnId} = {id};",conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //OVERLOAD

        public DataTable SearchRegistro(string tabla, string orColumn, string orValue, string orColumnId, int orId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new($"SELECT * FROM {tabla} WHERE {orColumn} = '{orValue}' OR {orColumnId} = {orId};", conn))
                {
                    SqlDataAdapter adapter = new(cmd);
                    DataTable dataTable = new();

                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }

        public DataTable SearchRegistro(string tabla, string orColumnId, int orId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new($"SELECT * FROM {tabla} WHERE {orColumnId} = {orId};", conn))
                {
                    SqlDataAdapter adapter = new(cmd);
                    DataTable dataTable = new();

                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }

        public List<string> GetPersonal(string Cargo)
        {
            List<string> data = new();
            using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = new($"SELECT Nombre FROM Personal WHERE Cargo = '{Cargo}';", conn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader["Nombre"].ToString());
                        }

                        return data;
                    }
                }
            }
        }
    }
}