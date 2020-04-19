using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto
    {
        public Moto(EMarca marca, string chasis, ConsoleColor color)
        {
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected short Tamanio
        {
            get
            {
                return 0;
            }
        }

        private override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(this.Mostrar());
            sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb;
        }
    }
}
