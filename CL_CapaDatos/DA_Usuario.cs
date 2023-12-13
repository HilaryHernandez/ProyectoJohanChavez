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
                String insertar = "insert into usuario(noDocumento,tipoDocumento, nombre, apellido, direccion, telefono, correo, cargo, nivelRiesgo, contraseña, idRol)values("+objUsuario.noDocumento+",'"+objUsuario.tipoDocumento+"', '"+objUsuario.nombre+"', '"+objUsuario.apellido+"', '"+objUsuario.direccion+"', "+objUsuario.telefono+", '"+objUsuario.correo+"', '"+objUsuario.cargo+"','"+objUsuario.nivelRiesgo+"','"+objUsuario.contraseña+"', "+objUsuario.rol+")";

            return RealizarTransaccion(insertar);
        }


        public static DataTable ConsultarLogin(string IdentificaciónInicioSesion, string ContraseñaInicioSesion)
        {
            string codigo = "select * from usuario WHERE noDocumento='" + IdentificaciónInicioSesion + "' and contraseña='" + ContraseñaInicioSesion + "'";

            return ConsultarDatos(codigo);
        }
    }





}

    
