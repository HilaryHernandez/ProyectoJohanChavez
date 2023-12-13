using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CE_CapaEntidades
{
    public class CE_Usuario
    {
        public int noDocumento { get; set; }
        public string tipoDocumento { get; set; }
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string direccion {  get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string cargo { get; set; }   
        public int nivelRiesgo { get; set; }
        public byte[] imagen { get; set; }
        public string contraseña { get; set; }
        public int rol {  get; set; }
    }
}
