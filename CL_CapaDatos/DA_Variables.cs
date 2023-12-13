using Cl_capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaDatos
{
    public class DA_Variables : DA_BASE
    {
        public static DataTable consultarVariables()
        {
            string code = "select * from variables;";
            return DA_BASE.ConsultarDatos(code);
        }
        public static bool actualizarVariables(string nombre, string porcentaje)
        {
            string cod = "update variables set porcentaje = "+porcentaje+" where nombre = '"+nombre+"';";
            return DA_BASE.RealizarTransaccion(cod);
        }
    }
}
