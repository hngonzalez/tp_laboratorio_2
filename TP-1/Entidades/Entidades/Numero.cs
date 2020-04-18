using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        #region Attributes
        /// <summary>
        /// Atributos de la clase Número
        /// </summary>

        private double numero;
        #endregion

        #region Properties
        /// <summary>
        /// Atributos de la clase Número
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Atributos de la clase Número
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero) : this()
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Valida que sea un número
        /// </summary>
        private double ValidarNumero(string strNumero)
        {
            double aux;

            if (double.TryParse(strNumero, out aux))
            {
                return aux;
            }

            aux = 0;

            return aux;
        }

        /// <summary>
        /// Método que transforma un número decimal a binario
        /// </summary>
        public string BinarioDecimal(string binary)
        {
            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            int decimalNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, i);
                }
            }
            return decimalNumber.ToString();
        }

        /// <summary>
        /// Método que transforma un número binario a decimal
        /// </summary>
        public string DecimalBinario(double numero)
        {
            double number = Convert.ToInt32(numero);
            string binary = string.Empty;

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binary = "0" + binary;
                    }
                    else
                    {
                        binary = "1" + binary;
                    }

                    numero = (int)(numero / 2);
                }
            }
            else if (numero == 0)
            {
                binary = "0";
            }

            return binary;
        }
        #endregion

        #region Operators
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double resultado = 0;

            resultado = n1.numero * n2.numero;

            return resultado;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = 0;

            if (n1.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }
            else
            {
                resultado = double.MinValue;
            }

            return resultado;
        }
        #endregion
    }
}
