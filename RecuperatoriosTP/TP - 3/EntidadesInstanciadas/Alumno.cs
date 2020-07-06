using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciadas
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion


        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #region Constructores
        public Alumno()
        {

        }


        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }


        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,
            EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion


        #region Sobrecargas
        /// <summary>
        /// Verifica que el alumno tome una clase.
        /// </summary>
        /// <param name="a"></param>Alumno a verificar.
        /// <param name="clase"></param>Clase a verificar.
        /// <returns>true si toma esa clase, false caso contrario</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que el alumno no tome la clase.
        /// </summary>
        /// <param name="a"></param>Alumno a verificar
        /// <param name="clase"></param>Clase a verificar
        /// <returns>True si no toma la clase, False caso contrario</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Hace publicos los datos del alumno.
        /// </summary>
        /// <returns>Retorna los datos del alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Muestra los datos del Alumno.
        /// </summary>
        /// <returns>Retorna los datos del Alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("\n\nESTADO DE CUENTA {0}", this.estadoCuenta);
            sb.AppendFormat("\n{0}", this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Muestra la clase que toma el alumno.
        /// </summary>
        /// <returns>la clase que toma el alumno</returns>
        protected override string ParticiparEnClase()
        {
            return string.Format("TOMA CLASE DE {0}", this.claseQueToma);
        }
        #endregion



    }
}
