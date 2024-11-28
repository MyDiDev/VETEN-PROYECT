using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices.Marshalling;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Datos
{
    public class Connection
    {
        public Connection(){}

        //VARIABLE PARA CAPITALIZAR UNA CADENA
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        public SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;");


        // INVENTARIOS, HISTORIALES Y REGISTROS

        public DataTable GetTable(string tableName)
        {
            using (conn)
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
            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new($"INSERT INTO Medicamentos_Vacunas (Nombre, Descripcion, Lote, Fecha_Caducidad, Dosis_Recomendada, Cantidad, Precio_Unitario) VALUES('{textInfo.ToTitleCase(nombre.ToLower())}', '{descripcion}', '{lote}', '{fechaCaducidad}', '{dosisRecomendada}', {cantidad}, {precioUnitario});",conn);
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
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new($"INSERT INTO Material_Medico_Equipamiento (Nombre, Descripcion, Cantidad, Fecha_Mantenimiento, Precio_Unitario) VALUES('{textInfo.ToTitleCase(nombre.ToLower())}', '{descripcion}', {cantidad}, '{fechaMantenimiento}', {precioUnitario});", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        //HISTORIAL MEDICO

        public string AgregarHistorialMedico(string nombrePaciente, DateTime fecha, string notasGenerales)
        {
            try
            {
                int idPaciente = -1;
                using (conn)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Paciente FROM Pacientes WHERE Nombre='{textInfo.ToTitleCase(nombrePaciente.ToLower())}'", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPaciente = reader.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo encontrar el identificador del paciente, intente agregando otra vez";
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO HistorialMedico (ID_Paciente, Fecha, Notas_Generales) VALUES ({idPaciente}, '{fecha}', '{notasGenerales}');", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }


        //DOCUMENTOS ADMINISTRATIVOS
        public string AgregarDocumentoAdmin(string nombre, string tipo, string descripcion, int cantidad, string formato, DateTime fechaCreacion, DateTime fechaActualizacion, string ubicacion, decimal precioUnitario, string nombreProveedor)
        {
            try
            {
                int idProveedor = -1;

                using (conn)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Proveedor FROM Proveedores WHERE Nombre_Proveedor='{nombreProveedor}'",conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProveedor = reader.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo localizar el identificador del proveedor, intente agregando nuevamente";
                            }
                        }
                    }

                    using (SqlCommand cmd = new($"INSERT INTO Documentos_Materiales_Administrativos (Nombre, Tipo, Descripcion, Cantidad, Formato, Fecha_Creacion, Fecha_Actualizacion, Ubicacion, Precio_Unitario, ID_Proveedor) VALUES ('{textInfo.ToTitleCase(nombre.ToLower())}', '{tipo}', '{descripcion}', {cantidad}, '{formato}', '{fechaCreacion}', '{fechaActualizacion}', '{textInfo.ToTitleCase(ubicacion.ToLower())}', {precioUnitario}, {idProveedor});", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }

                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }


        //ALIMENTOS Y SUPLEMENTOS 

        public bool AgregarAlimentoSuplemento(string nombre,
            string descripcion,
            int cantidad,
            decimal precioUnitario)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Alimentos_Suplementos (Nombre, Descripcion, Cantidad, Precio_Unitario) VALUES ('{textInfo.ToTitleCase(nombre.ToLower())}', '{descripcion}', {cantidad}, {precioUnitario});", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
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
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Proveedores (Nombre_Proveedor, Contacto, Telefono, Email, Direccion, Condiciones_Entrega) VALUES ('{textInfo.ToTitleCase(nombreProveedor.ToLower())}', '{contacto}', '{telefono}', '{email}', '{direccion}', '{condicionesEntrega}');", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }catch (Exception)
            {
                return false;
            }
        }

        //PRODUCTOS

        public string AgregarProducto(string nombre,
            string descripcion,
            string nombreProveedor,
            double precioUnitario,
            int cantidad)
        {
            try
            {
                int idProveedor = -1;

                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Proveedor FROM Proveedores WHERE Nombre_Proveedor='{textInfo.ToTitleCase(nombreProveedor.ToLower())}'",conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProveedor = reader.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo Econtrar el identificador del Proveedor, intente agregar el proveedor nuevamente";
                            }
                        }
                    }

                    using(SqlCommand cmd = new($"INSERT INTO Productos_Generales (Nombre, Descripcion, ID_Proveedor, Precio_Unitario, Cantidad) VALUES ('{textInfo.ToTitleCase(nombre.ToLower())}', '{descripcion}', {idProveedor}, {precioUnitario}, {cantidad});", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }

                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        //PACIENTES

        public string AgregarPaciente(string nombre, string especie, string raza, int edad, string genero, string nombreCliente)
        {
            try
            {
                int idCliente = -1;

                using (conn)
                {

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Cliente FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(nombreCliente.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idCliente = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo Econtrar el identificador del Cliente, intente agregar su nombre otra vez";
                            }
                        }
                    }


                    using (SqlCommand cmd = new($"INSERT INTO Pacientes (Nombre, Especie, Raza, Edad, Genero, ID_Cliente) VALUES ('{textInfo.ToTitleCase(nombre.ToLower())}', '{textInfo.ToTitleCase(especie.ToLower())}', '{textInfo.ToTitleCase(raza.ToLower())}', {edad}, '{textInfo.ToTitleCase(genero.ToLower())}', {idCliente});", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }
                }


            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        // CITAS

        public string PlanearCita(string nombreCliente, string nombreMascota, string nombrePersonal, DateTime Fecha, string TipoServicio, string Estado, string Observaciones)
        {
            try
            {
                int idCliente = -1;
                int idMascota = -1;
                int idPersonal = -1;

                using (conn)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Cliente FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(nombreCliente.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idCliente = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo Econtrar el identificador del Cliente, intente agregar el cliente nuevamente";
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Mascota FROM Mascotas WHERE Nombre='{textInfo.ToTitleCase(nombreMascota.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idMascota = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo encontrar el Identificador de la Mascota, agregue nuevamente el nombre de la mascota";
                            }
                        }
                    }

                    // TOMAR EN CUENTA: TipoServicio
                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Citas (ID_Cliente, ID_Mascota, ID_Personal, Fecha, Tipo_Servicio, Estado, Observaciones) VALUES({idCliente}, {idMascota}, {idPersonal}, '{Fecha}', '{textInfo.ToTitleCase(TipoServicio.ToLower())}', '{Estado}', '{Observaciones}');", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        //CITAS : CITAS/RECORDATORIOS

        public string AgregarCitaRecordatorio(DateTime fechaHora, string tipo, string nombreCliente, string nombreMascota,
                              string motivo, string descripcion, string estado)
        {
            try
            {
                int idCliente = -1;
                int idMascota = -1;

                using (conn)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Cliente FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(nombreCliente.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idCliente = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo Econtrar el identificador del Cliente, intente agregar su nombre otra vez";
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Paciente FROM Pacientes WHERE Nombre='{textInfo.ToTitleCase(nombreMascota.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idMascota = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo encontrar el Identificador del Paciente, Trate de agregar nuevamente el nombre de la mascota";
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Citas_Recordatorios WHERE ID_Paciente={idMascota} AND ID_Cliente={idCliente} ", conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 1)
                        {
                            conn.Close();
                            return "Ya Tienes una cita planeada, vuelve cuando termines a Cita despues de un plazo de 1 semana";
                        }
                    }

                    using (SqlCommand cmd = new($"INSERT INTO Citas_Recordatorios (Fecha_Hora, Tipo, ID_Cliente, ID_Paciente, Motivo, Descripcion, Estado) VALUES ('{fechaHora}', '{tipo}', {idCliente}, {idMascota}, '{motivo}', '{descripcion}', '{estado}');", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        public DataTable GetCitasRecordatorios(int ClientID, int PetID)
        {
            DataTable dataTable = new();
            
            try
            {
                using (conn)
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
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Diagnosticos (ID_Visita, Descripcion, Fecha_Diagnostico) VALUES({idVisita}, '{descripcion}', '{fechaDiagnostico}');", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //TRANSACCION

        public string AgregarTransaccion(string nombreCliente, DateTime fechaTransaccion, string tipo, string metodoPago, decimal monto, string descripcion, string estado)
        {
            try
            {
                int idCliente = -1;
                using (conn)
                {

                    conn.Open();


                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Cliente FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(nombreCliente.ToLower())}'", conn))
                    {
                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                idCliente = read.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo Econtrar el identificador del Cliente, intente agregar el cliente nuevamente";
                            }
                        }
                    }


                    using (SqlCommand cmd = new($"INSERT INTO Transacciones (ID_Cliente, Fecha_Transaccion, Tipo, Metodo_Pago, Monto, Descripcion, Estado) VALUES ({idCliente}, '{fechaTransaccion}', '{tipo}', '{metodoPago}', {monto}, '{descripcion}', '{estado}');", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        //VISITAS

        public bool AgregarVisita(DateTime fechaVisita, string motivo, decimal peso, decimal temperatura, string notas)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Visitas (Fecha_Visita, Motivo, Peso, Temperatura, Notas) VALUES('{fechaVisita}', '{motivo}', {peso}, {temperatura}, '{notas}');", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //PERSONAL

        public bool AgregarPersonal(string nombre, string cargo, string telefono, string email, string horario_Trabajo, string certificaciones)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"INSERT INTO Personal (Nombre, Cargo, Telefono, Email, Horario_Trabajo, Certificaciones) VALUES(@Nombre, @Cargo, @Telefono, @Email, @Horario_Trabajo, @Certificaciones);", conn);
                    cmd.Parameters.AddWithValue("@Nombre", textInfo.ToTitleCase(nombre.ToLower()));
                    cmd.Parameters.AddWithValue("@Cargo", textInfo.ToTitleCase(cargo.ToLower()));
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Horario_Trabajo", horario_Trabajo);
                    cmd.Parameters.AddWithValue("@Certificaciones", certificaciones);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
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
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=BaseDatosVeterinaria;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT Tipo_Usuario FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(userName.ToLower())}' AND Clave='{userPassword}';", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userType = reader.GetString(0);
                                return userType;
                            }
                            else
                            {
                                return "No se pudo encontrar el tipo de usuario, intente nuevamente";
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        // USUARIOS 

        //private string HashCont(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}

        public bool AgregarUsuario(string userType, string nombre, string direccion, string telefono, string email, string clave)
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    //string HashedClave = HashCont(clave);

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Clientes (Nombre, Direccion, Telefono, Email, Tipo_Usuario, Clave) VALUES ('{textInfo.ToTitleCase(nombre.ToLower())}', '{direccion}', '{telefono}', '{email}', '{userType}', '{clave}');", conn);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // MASCOTAS

        public string AgregarMascota(string nombreCliente, string Nombre, string Especie, string Raza, int Edad, string Genero)
        {
            try
            {
                int idCliente = -1;

                using (conn)
                {

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT ID_Cliente FROM Clientes WHERE Nombre='{textInfo.ToTitleCase(nombreCliente.ToLower())}';", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idCliente = reader.GetInt32(0);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo encontrar el Identificador del cliente, Intente ingresar el nombre del cliente nuevamente";
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Mascotas(Nombre, Especie, Raza, Edad, Genero, ID_Cliente) VALUES ('{textInfo.ToTitleCase(Nombre.ToLower())}', '{textInfo.ToTitleCase(Especie.ToLower())}', '{textInfo.ToTitleCase(Raza.ToLower())}', {Edad}, '{Genero}', {idCliente});", conn))
                    {
                        cmd.ExecuteNonQuery();
                        return "1";
                    }

                }
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }

        // GLOBAL

        public int ConseguirId(string Tabla, string ColumnaTarget, string ColumnaWhere, string ValorWhere)
        {
            using (conn)
            {
                int id = -1;

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"SELECT {ColumnaTarget} FROM {Tabla} WHERE {ColumnaWhere}='{ValorWhere}';", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = reader.GetInt32(0);
                            }
                        }
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
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new($"DELETE FROM {tabla} WHERE {columnId} = {id};", conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public DataTable SearchRegistro(string tabla, string orColumn, string orValue, string orColumnId, int orId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new($"SELECT * FROM {tabla} WHERE {orColumn} = '{orValue}' OR {orColumnId} = {orId};", conn))
                    {
                        SqlDataAdapter adapter = new(cmd);

                        adapter.Fill(dataTable);
                        return dataTable;
                    }

                }
            }catch (Exception)
            {
                return dataTable;
            }
        }

        //OVERLOAD

        public DataTable SearchRegistro(string tabla, string orColumnId, int orId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new($"SELECT * FROM {tabla} WHERE {orColumnId} = {orId};", conn))
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

        public List<string> GetPersonal(string Cargo)
        {
            List<string> data = new List<string>();
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new($"SELECT Nombre FROM Personal WHERE Cargo = '{Cargo}';", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
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
            catch (Exception)
            {
                return data;
            }
        }

        public string CheckCitaDate(DateTime date, int id)
        {
            try
            {
                DateTime appointmentDate;
                string motivo;
                using (conn)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Citas_Recordatorios WHERE ID={id};", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                appointmentDate = reader.GetDateTime(1);
                                motivo = reader.GetString(5);
                            }
                            else
                            {
                                conn.Close();
                                return "No se pudo encontrar el identificador de la cita, intente nuevamente";
                            }
                        }
                    }

                    if (date > appointmentDate)
                    {
                        using (SqlCommand cmd = new SqlCommand($"DELETE FROM Citas_Recordatorios WHERE ID={id};",conn))
                        {
                            cmd.ExecuteNonQuery();
                            return "";
                        }
                    }
                    else if (date == appointmentDate)
                    {
                        return $"!La Cita sobre: {motivo}, Es para Hoy a las {appointmentDate.ToString().Substring(10)}";
                    }
                }

                return "No se pudo realizar la operacion";
            }
            catch (Exception ex)
            {
                return $"{ex}";
            }
        }
    }
}