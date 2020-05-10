using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {

        #region Propeties
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Overload del constructor de la clase
        /// </summary>
        /// <param name="marca">Objeto donde se agregará el elemento</param>
        /// <param name="chasis">Objeto donde se agregará el elemento</param>
        /// <param name="color">Objeto donde se agregará el elemento</param>
        public Moto(EMarca marca, string chasis, ConsoleColor color) 
            : base(chasis,marca,color)
        {

        }
        #endregion

        #region Methods
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
