using Cl_capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_CapaEntidades;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Drawing;

namespace CL_CapaDatos
{
    public class DA_Usuario:DA_BASE
    {
        public static String CadenaConexion = "Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD=";
        public static MySqlConnection conexion = new MySqlConnection(CadenaConexion);
        public static DataTable ConsultaImagen(CE_CapaEntidades.CE_Usuario objUsuario)
        {
            String consulta = "select imagen from usuario WHERE noDocumento=" + objUsuario.noDocumento + ";";
            
            return ConsultarDatos(consulta);
        }

        

        public static bool InsertarImagen()
        {
            string rutaImagen = "prueba.jpg";

            // Convierte la imagen a un array de bytes
            byte[] bytesImagen = ObtenerBytesDeImagen(rutaImagen);

            // Sube la imagen a la base de datos
            return SubirImagenABaseDeDatos(bytesImagen);

        }

        static byte[] ObtenerBytesDeImagen(string rutaImagen)
        {
            // Lee la imagen como un array de bytes
            return File.ReadAllBytes(rutaImagen);
        }



        
    }
}
