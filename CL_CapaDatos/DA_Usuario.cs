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
using System.Windows.Forms;

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

        public static DataTable ConsultarUsuarios()
        {
            String codigo = "select * from usuario;";

            return ConsultarDatos(codigo);
        }

        public static DataTable ConsultarUsuarioPorDocumento(int documento)
        {
            String codigo = "select * from usuario where noDocumento="+documento+";";

            return ConsultarDatos(codigo);
        }

        public static bool ActualizarUsuario(CE_Usuario objUsuario)
        {
            String codigo = "update usuario set correo='"+objUsuario.correo+"',direccion='"+objUsuario.direccion+"',telefono="+objUsuario.telefono+",contraseña='"+objUsuario.contraseña+"' where noDocumento="+objUsuario.noDocumento+";";

            return RealizarTransaccion(codigo);
        }


        public static bool RegistrarUsuario(CE_Usuario objUsuario)
        {
            String insertar= "insert into usuario(noDocumento,tipoDocumento, nombre, apellido, direccion, telefono, correo, cargo, nivelRiesgo, imagen, contraseña, idRol)values(@noDocumento,@tipoDocumento, @nombre, @apellido, @direccion, @telefono, @correo, @cargo,@nivelRiesgo,@imagen,@contraseña, @idRol)";
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@noDocumento", MySqlDbType.Int64) { Value=objUsuario.noDocumento});
            parametros.Add(new MySqlParameter("@tipoDocumento", MySqlDbType.VarChar) { Value=objUsuario.tipoDocumento});
            parametros.Add(new MySqlParameter("@nombre", MySqlDbType.VarChar) { Value=objUsuario.nombre});
            parametros.Add(new MySqlParameter("@apellido", MySqlDbType.VarChar) { Value=objUsuario.apellido});
            parametros.Add(new MySqlParameter("@direccion", MySqlDbType.VarChar) { Value=objUsuario.direccion});
            parametros.Add(new MySqlParameter("@telefono", MySqlDbType.Int64) { Value=objUsuario.telefono});
            parametros.Add(new MySqlParameter("@correo", MySqlDbType.VarChar) { Value=objUsuario.correo});
            parametros.Add(new MySqlParameter("@cargo", MySqlDbType.VarChar) { Value=objUsuario.cargo});
            parametros.Add(new MySqlParameter("@nivelReisgo", MySqlDbType.Int64) { Value=objUsuario.nivelRiesgo});
            parametros.Add(new MySqlParameter("@imagen", MySqlDbType.LongBlob) { Value=objUsuario.imagen});
            parametros.Add(new MySqlParameter("@contraseña", MySqlDbType.VarChar) { Value=objUsuario.contraseña});
            parametros.Add(new MySqlParameter("@idRol", MySqlDbType.Int64) { Value=objUsuario.rol});
            return RealizarTransaccion2(insertar,parametros);
        }



        
        



    }

    public static DataTable ConsultarLogin(string IdentificaciónInicioSesion, string ContraseñaInicioSesion)
    {
        string codigo = "select * from usuario WHERE noDocumento='" + IdentificaciónInicioSesion + "' and contraseña='" + ContraseñaInicioSesion + "'";

        return ConsultarDatos(codigo);
    }
}
