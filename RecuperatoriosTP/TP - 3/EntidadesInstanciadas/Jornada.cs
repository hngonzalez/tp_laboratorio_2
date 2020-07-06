using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace EntidadesInstanciadas
{
    public class Jornada
    {
        #region Atributtes
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Properties
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Overload del constructor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
}
        #endregion

        #region Methods
        /// <summary>
        /// Método para leer del archivo
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto leerTxt = new Texto();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Jornada.txt";

            if (leerTxt.Leer(archivo, out string jornada))
            {
                return jornada;
            }
            return jornada;
        }

        /// <summary>
        /// Método para guardar en el archivo
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto guardaTxt = new Texto();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Jornada.txt";
            if (guardaTxt.Guardar(archivo, jornada.ToString()))
            {
                return true;
            }
            return false;
}
        #endregion

        #region Overloads
        /// <summary>
        /// Método para sabe
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno aAux in j.Alumnos)
            {
                if (a == aAux)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica que la Jornada y el Alumno no tengan la misma clase
        /// </summary>
        /// <param name="j">Jornada a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns>True si no coinciden, False caso contrario</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega el Alumno a la Jornada si este no esta ya en ella
        /// </summary>
        /// <param name="j">Jornada a agergar Alumno</param>
        /// <param name="a">Alumno a agregar a la Jornada</param>
        /// <returns>Retorna la Jornada con o sin el Alumno agregado</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }

        /// <summary>
        /// Muestra toda la informacion de la Jornada
        /// </summary>
        /// <returns>Retorna la informacion de la Jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}", this.Clase, this.Instructor);
            sb.AppendFormat("\nALUMNOS: \n");
            foreach (Alumno alumno in this.Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            sb.AppendLine("<------------------------------>");
            return sb.ToString();
        }
        #endregion
    }
}
