using CL_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Controlador
{
    public class CT_Variables
    {
        public static DataTable CTconsultarVariables()
        {
            return DA_Variables.consultarVariables();
        }
        public static bool CTactualizarVariables(string nombre, string porcentaje)
        {
            return DA_Variables.actualizarVariables(nombre, porcentaje);
        }
       
    }
}
