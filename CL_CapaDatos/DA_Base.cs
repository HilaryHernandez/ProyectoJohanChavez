using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_capa_datos
{
    public class DA_BASE
    {
        public static String CadenaConexion="Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD=";

        //sentencias insert,update y delete
        public static bool RealizarTransaccion(string strSQL) {

            bool resultado = false;

            try

            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlTransaction tr =conn.BeginTransaction())
                    {
                        try
                        {
                            using (MySqlCommand cmd=new MySqlCommand(strSQL, conn))
                            {
                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                            tr.Commit();
                            resultado = true;
                        }
                        catch (Exception)
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;
                        }
                    }

                }
            }
        catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        public static DataTable ConsultarDatos(String strsSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(strsSQL, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }catch (Exception)
            {
                throw;
            }
        }

        public static bool SubirImagenABaseDeDatos(byte[] bytesImagen)
        {
            // La cadena de conexión a la base de datos MySQL
            string cadenaConexion = "Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD="; // Reemplaza con tu cadena de conexión

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                // Abre la conexión a la base de datos
                conexion.Open();

                // Consulta SQL para insertar la imagen en la base de datos
                string consulta = "INSERT INTO usuario (imagen) VALUES (@DatosImagen)";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    // Añade parámetros a la consulta
                    comando.Parameters.Add("@DatosImagen", MySqlDbType.LongBlob).Value = bytesImagen;

                    // Ejecuta la consulta
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

    }
}
