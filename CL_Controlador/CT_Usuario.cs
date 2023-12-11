using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
