using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Controlador
{
    public class CalcularSueldo
    {
        public static int CalcularIbc(int sueldo, int horasEx)
        {
            int valorHoraNormal = 6000;

            int valorHoraEx = (((valorHoraNormal*25)/100) +valorHoraNormal)*horasEx;
            int resultado = ((sueldo + valorHoraEx)*40)/100;

            return resultado;


        }
    }
}
