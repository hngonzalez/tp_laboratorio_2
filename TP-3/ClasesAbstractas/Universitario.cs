using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributtes
        private int legajo;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de Legajo
        /// </summary>
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Universitario()
        {

        }

        /// <summary>
        /// Overload del constructor
        /// </summary>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this()
        {
            this.Legajo = legajo;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Verifica si 2 obj son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }

        /// <summary>
        /// Método ParticiparEnClase
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Método que muestra info del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("LEGAJO NúMERO: {0}", this.legajo);

            return sb.ToString();
        }

        /// <summary>
        /// Operador para comparar 2 universitarios
        /// </summary>
        /// <param name="pg1">Elemento a comparar</param>
        /// <param name="pg2">Elemento a comparar</param>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (Equals(pg1, pg2) && ((pg1.Legajo == pg2.Legajo) || (pg1.DNI == pg2.DNI)))
            {
                throw new AlumnoRepetidoException();
            }

            return false;
        }

        /// <summary>
        /// Operador para comparar 2 universitarios (reutilizo ==)
        /// </summary>
        /// <param name="pg1">Elemento a comparar</param>
        /// <param name="pg2">Elemento a comparar</param>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return (!(pg1 == pg2));
        }
        #endregion
    }
}
