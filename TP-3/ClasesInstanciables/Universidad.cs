using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Enumerators
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion


        #region Atributtes
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion


        #region Properties

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
            }
        }

        public List<Profesor> Jornadas
        {
            get
            {
                return myVar;
            }
            set
            {
                myVar = value;
            }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de la clase Universidad
        /// </summary>
        public Universidad()
        {

        }
        #endregion


        #region Methods
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            foreach (Jornada auxJornada in uni.Jornada)
            {
                sb.AppendFormat(auxJornada.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }
}
