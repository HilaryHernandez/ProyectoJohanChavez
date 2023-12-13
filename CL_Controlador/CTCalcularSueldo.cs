using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Controlador
{
    public class CTCalcularSueldo
    {
        static string porcentajeSalarioMinimo;
        static string porcentajeEpsEmpresa;
        static string porcentajeEpsEmpleado;
        static string porcentajeEpsIndependiente;
        static string porcentajePensionEmpresa;
        static string porcentajePensionEmpleado;
        static string porcentajePensionIndependiente;
        static string porcentajeArlClase1;
        static string porcentajeArlClase2;
        static string porcentajeArlClase3;
        static string porcentajeArlClase4;
        static string porcentajeArlClase5;
        public static void datos()
        {
            DataTable dt = new DataTable();
            dt = CT_Variables.CTconsultarVariables();
            porcentajeSalarioMinimo = dt.Rows[0]["porcentaje"].ToString();
            porcentajeEpsEmpresa = dt.Rows[1]["porcentaje"].ToString();
            porcentajeEpsEmpleado = dt.Rows[2]["porcentaje"].ToString();
            porcentajeEpsIndependiente = dt.Rows[3]["porcentaje"].ToString();
            porcentajePensionEmpresa = dt.Rows[4]["porcentaje"].ToString();
            porcentajePensionEmpleado = dt.Rows[5]["porcentaje"].ToString();
            porcentajePensionIndependiente = dt.Rows[6]["porcentaje"].ToString();
            porcentajeArlClase1 = dt.Rows[7]["porcentaje"].ToString();
            porcentajeArlClase2 = dt.Rows[8]["porcentaje"].ToString();
            porcentajeArlClase3 = dt.Rows[9]["porcentaje"].ToString();
            porcentajeArlClase4 = dt.Rows[10]["porcentaje"].ToString();
            porcentajeArlClase5 = dt.Rows[11]["porcentaje"].ToString();


            

        }
         

        public static String calcularSueldoConHorasExtras(int sueldo, int horasEX)
        {
            int valorHoraNormal = 6000;

            return (((((valorHoraNormal * 25) / 100)+valorHoraNormal)*horasEX)+sueldo).ToString();
        }


        public static String CalcularIbc(int sueldo, int horasEx)
        {
            int valorHoraNormal = 6000;

            int valorHoraEx = (((valorHoraNormal * 25) / 100) + valorHoraNormal) * horasEx;
            int resultado = ((sueldo + valorHoraEx) * 40) / 100;

            return resultado.ToString();
        }

        public static String CalcularPension(int ibc)
        {
            string resultado = "";
            if (double.TryParse(porcentajePensionEmpresa, out double numeroConvertido))
            {
                resultado = ((ibc * numeroConvertido)/100).ToString();
            }
            return resultado;

            

        }

        public static String CalcularArl(double ibc, String nivelRiesgo)
        {
            
            
            switch (nivelRiesgo)
            {
                case "Nivel l":
                    
                    string resultado = "";
                     if(double.TryParse(porcentajeArlClase1, out double numeroConvertido))
                    {
                         resultado = (ibc * numeroConvertido).ToString();
                    }
                     return resultado;
                    
                case "Nivel ll":
                    string resultado1 = "";
                    if (double.TryParse(porcentajeArlClase2, out double numeroConvertido1))
                    {
                        resultado1 = (ibc * numeroConvertido1).ToString();
                    }
                    return resultado1;

                case "Nivel lll":
                    string resultado2 = "";
                    if (double.TryParse(porcentajeArlClase3, out double numeroConvertido2))
                    {
                        resultado2 = (ibc * numeroConvertido2).ToString();
                    }
                    return resultado2;

                case "Nivel lV":
                    string resultado3 = "";
                    if (double.TryParse(porcentajeArlClase4, out double numeroConvertido3))
                    {
                        resultado3 = (ibc * numeroConvertido3).ToString();
                    }
                    return resultado3;

                case "Nivel V":
                    string resultado4 = "";
                    if (double.TryParse(porcentajeArlClase5, out double numeroConvertido4))
                    {
                        resultado4 = (ibc * numeroConvertido4).ToString();
                    }
                    return resultado4;

                default: return "Error en el calculo";
            }
        }

        public static String CalcularEps(int ibc)
        {
            string resultado = "";
            if (double.TryParse(porcentajeEpsEmpresa, out double numeroConvertido))
            {
                 resultado = ((ibc * numeroConvertido)/100).ToString();
            }
            return resultado;
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
        public static String calcularCesantias(int sueldoTotal, int diasTrabajados)
        {
            return ((sueldoTotal * diasTrabajados) / 360).ToString();
        }

        public static String calcularVacaciones(int sueldoTotal, int diasTrabajados)
        {
            return ((sueldoTotal * diasTrabajados) / 720).ToString();
        }

        public static String calcularInteresesCesantias(double cesantias, double diasTrabajados)
        {
            return (((cesantias*diasTrabajados)*0.12)/360).ToString();
        }

        public static String CalcularEpsEmpleado(int sueldoTotal)
        {
            string resultado = "";
            if (double.TryParse(porcentajeEpsEmpleado, out double numeroConvertido))
            {
                resultado = ((((sueldoTotal *40)/100)* numeroConvertido)/100).ToString();
            }
            return resultado;

        }

        public static String CalcularPensionEmpleado(int sueldoTotal)
        {
            string resultado = "";
            if (double.TryParse(porcentajePensionEmpleado, out double numeroConvertido))
            {
                resultado = ((((sueldoTotal *40)/100)* numeroConvertido)/100).ToString();
            }
            return resultado;
        }

        public static String CalcularPrima(int sueldoTotal, int diasTrabajados)
        {
            return ((sueldoTotal * diasTrabajados) / 360).ToString();
        }

        public static String CalcularLiquidacion(int sueldoTotal, int diasTrabajados)
        {
            return (((((sueldoTotal / 360) * diasTrabajados) * 12) / 100) + ((((sueldoTotal / 360) * diasTrabajados) * 833)/10000) + (sueldoTotal / 30 * 15)).ToString();
        }
        
        public static String CalcularEpsIndependiente(int sueldoTotal)
        {
            string resultado = "";
            if (double.TryParse(porcentajeEpsIndependiente, out double numeroConvertido))
            {
                resultado = ((((sueldoTotal *40)/100)* numeroConvertido)/100).ToString();
            }
            return resultado;
            
        }

        public static String CalcularPensionIndependiente(int sueldoTotal)
        {
            string resultado = "";
            if (double.TryParse(porcentajePensionIndependiente, out double numeroConvertido))
            {
                resultado = ((((sueldoTotal *40)/100)* numeroConvertido)/100).ToString();
            }
            return resultado;
            
        }
    }
}
