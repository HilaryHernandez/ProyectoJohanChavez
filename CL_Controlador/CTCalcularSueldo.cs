using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Controlador
{
    public class CTCalcularSueldo
    {
        public static String CalcularIbc(int sueldo, int horasEx)
        {
            int valorHoraNormal = 6000;

            int valorHoraEx = (((valorHoraNormal * 25) / 100) + valorHoraNormal) * horasEx;
            int resultado = ((sueldo + valorHoraEx) * 40) / 100;

            return resultado.ToString();
        }

        public static String CalcularPension(int ibc)
        {
            return ((ibc*12)/100).ToString();

            
    
    
    
        }

        public static String CalcularArl(double ibc, String nivelRiesgo)
        {
            switch (nivelRiesgo)
            {
                case "Nivel l": return (ibc * 0.00522) + "";
                    
                case "Nivel ll": return (ibc * 0.01044) + "";
                    
                case "Nivel lll": return (ibc * 0.02436) + "";
                    
                case "Nivel lV": return (ibc * 0.0435) + "";
                    
                case "Nivel V": return (ibc * 0.0696) + "";
                    
                default: return "Error en el calculo";
            }
        }

        public static String CalcularEps(int ibc)
        {
            return ((ibc * 8.5) / 100).ToString();
        }

        public static String CalcularCajaCompensacion(int sueldoTotal)
        {
            return ((sueldoTotal * 4) / 100).ToString();
        }

        public static String CalcularICBF(int sueldoTotal)
        {
            return ((sueldoTotal * 3) / 100).ToString();
        }

        public static String CalcularSENA(int sueldoTotal)
        {
            return ((sueldoTotal * 2) / 100).ToString();
        }
    }
}
