using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciadas
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        static Random random;
        #endregion

        #region Constructors
        static Profesor()
        {

        }

        private Profesor()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            random = new Random();
            this._randomClases();
            this._randomClases();
        }
        #endregion


        #region Methods
        /// <summary>
        /// Inserta una clase a claseDelDia aleatoriamente.
        /// </summary>
        public void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(Enum.GetNames(typeof(Universidad.EClases)).Length));
        }

        /// <summary>
        /// Muestra cuales son las clases del dia del Profesor.
        /// </summary>
        /// <returns>Las clases del dia</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nCLASES DEL DIA: ");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos del Profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }
        #endregion


        #region Overloads
        /// <summary>
        /// Verifica si el Prfesor da una clase especifica.
        /// </summary>
        /// <param name="i"></param>Profesor a verificar.
        /// <param name="clase"></param>Clase a verificar.
        /// <returns>True si el Profesor da la clase, False caso contrario</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases claseAux in i.clasesDelDia)
            {
                if (claseAux == clase)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el Prfesor No da una clase especifica.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>True si el Profesor No da la clase, False caso contrario</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        /// <summary>
        /// Hace publicos los datos de Profesor.
        /// </summary>
        /// <returns>Todos los datos del Profesor</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion 
    }
}
