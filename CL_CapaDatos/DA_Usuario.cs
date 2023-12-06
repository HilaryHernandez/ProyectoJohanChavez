using Cl_capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaDatos
{
    public class DA_Usuario:DA_BASE
    {
        public int idUsuario { get; set; }
        public int noDocumento { get; set; }
        public string tipoDocumento { get;set; }
        public string nombre { get; set; }


    }
}
