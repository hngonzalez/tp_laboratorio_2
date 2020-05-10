using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        /// <summary>
        /// Verifica que el dato enviado por parámetro contenga únicamente letras
        /// </summary>
        /// <param name="dato"> string a verificar para que contenga letras únicamente
        public static string ValidateOnlyLetters(string dato)
        {
            foreach (char letra in dato)
            {
                if (!(char.IsLetter(letra)))
                {
                    return "";
                }
            }
            return dato;
        }

        /// <summary>
        /// Verifica que un dato string contenga números únicamente y devuelve este dato a entero
        /// </summary>
        /// <param name="dato"> string a verificar que sean el mismo contenta letras únicamente
        public static int ValidateStringToInt(string dato)
        {
            int aux = 0;

            if (int.TryParse(dato, out aux))
            {
                return aux;
            }

            return 0;
        }

        /// <summary>
        /// Verifica que un dato string contenga números únicamente y devuelve este dato a entero
        /// </summary>
        /// <param name="dato"> string a verificar que sean el mismo contenta letras únicamente
        public static float ValidateStringToFloat(string dato)
        {
            float aux = 0;

            if (float.TryParse(dato, out aux))
            {
                return aux;
            }

            return 0;
        }

        /// <summary>
        /// Verifica que un dato string contenga números únicamente y devuelve este dato a entero
        /// </summary>
        /// <param name="dato"> string a verificar que sean el mismo contenta letras únicamente
        public static bool ValidateStringToBool(string dato)
        {
            switch (dato)
            {
                case "Si":
                    return true;
                default:
                    return false;
            }
        }


        public static bool ValidateEmptyData(string txtAlumnoNombre, string txtAlumnoApellido, string txtAlumnoDNI)
        {
            if ((txtAlumnoNombre != "") && (txtAlumnoApellido != "") && (txtAlumnoDNI != ""))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica que un dato string contenga números únicamente y devuelve este dato a entero
        /// </summary>
        /// <param name="dato"> string a verificar que sean el mismo contenta letras únicamente
        public static string ValidateIntToString(int dato)
        {
            return dato.ToString();
        }

        public static double ValidateStringToDouble(string dato)
        {
            double aux = 0;

            if (double.TryParse(dato, out aux))
            {
                return aux;
            }

            return 0;
        }
    }
}
