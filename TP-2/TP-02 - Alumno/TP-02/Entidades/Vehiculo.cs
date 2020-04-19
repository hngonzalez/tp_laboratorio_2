using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public sealed class Vehiculo
    {
        enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda
        }
        enum ETamanio
        {
            Chico, Mediano, Grande
        }
        EMarca marca;
        string chasis;
        ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        abstract ETamanio Tamanio { get; set; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        sealed string Mostrar()
        {
            return this;
        }

        private static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CHASIS: {0}\r\n", p.chasis);
            sb.AppendLine("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendLine("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb;
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
    }
}
