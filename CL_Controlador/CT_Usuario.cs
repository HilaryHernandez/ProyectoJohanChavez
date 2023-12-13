using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_CapaEntidades;
using CL_CapaDatos;

namespace CL_Controlador
{
    public class CT_Usuario
    {
        public static DataTable CTconsultarImagen(CE_CapaEntidades.CE_Usuario objUsuario)
        {
            return DA_Usuario.ConsultaImagen(objUsuario);
        }

        public static bool CTInsertarImagen()
        {
            return DA_Usuario.InsertarImagen();
        }

        public static DataTable CTConsultarUsuario()
        {
            return DA_Usuario.ConsultarUsuarios();
        }
        
        public static DataTable CTConsultarUsuarioPorDocumento(int documento)
        {
            return DA_Usuario.ConsultarUsuarioPorDocumento(documento);
        }
        public static bool CTActualizarUsuario(CE_Usuario objUsuario)
        {
            return DA_Usuario.ActualizarUsuario(objUsuario);
        }

        public static DataTable CTConsultarLogin(string documento, string contraseña)
        {
            return DA_Usuario.ConsultarLogin(documento,contraseña);
        }

        public static bool CTRegistrarUsuario(CE_CapaEntidades.CE_Usuario objUsuario)
        {
            return DA_Usuario.RegistrarUsuario(objUsuario);
        }
    }
}
