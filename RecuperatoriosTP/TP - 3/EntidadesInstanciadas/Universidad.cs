using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace EntidadesInstanciadas
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
        /// <summary>
        /// Propiedad de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        /// <summary>
        /// Propiedad de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        /// <summary>
        /// Propiedad JOrnada
        /// </summary>
        public List<Jornada> Jornada
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        /// <summary>
        /// Propiedad de JOrnada
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get { return jornada[i]; }
            set { jornada[i] = value; }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de la clase Universidad
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Overloads
        /// <summary>
        /// Verifica que la universidad cuente con ese Alumno
        /// </summary>
        /// <param name="g">Univerisdad a revisar</param>
        /// <param name="a">Alumno que se buscará en la universidad</param>
        /// <returns>True si el Alumno ya esta en la Univ. False caso contrario</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumnoAux in g.Alumnos)
            {
                if (alumnoAux == a)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica que la universidad no cuente con ese Alumno.
        /// </summary>
        /// <param name="g">Univerisdad a revisar</param>
        /// <param name="a">Alumno a buscar en la Universidad</param>
        /// <returns>True si el Alumno No esta en la Univ. False caso contrario</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Verfica si el Profesor ya esta en la Universidad
        /// </summary>
        /// <param name="g">Universidad a revisar</param>
        /// <param name="i">Profesor a buscar en la uni</param>
        /// <returns>True si esta en la Univ. False caso contrario</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesorAux in g.Instructores)
            {
                if (profesorAux == i)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verfica si el Profesor No esta en la Universidad
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="i">Profesor a buscar en la universidad</param>
        /// <returns>True si No esta en la Univ. False caso contrario</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Verifica si hay algun Profesor para dar la clase.
        /// </summary>
        /// <param name="u">Universidad en la que se consulta</param>
        /// <param name="clase">Clase a la que se le busca Profesor</param>
        /// <returns>Primer Profesor que de la clase, caso contrario lanza la Excpetion SinProfesorException</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profeAux in u.Instructores)
            {
                if (profeAux == clase)
                {
                    return profeAux;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Verifica si No hay algun Profesor para dar la clase.
        /// </summary>
        /// <param name="u">Universidad en la que se consulta</param>
        /// <param name="clase">Clase a la que se le busca Profesor</param>
        /// <returns>Primer Profesor que no da la clase, caso contrario Exception SinProfesorException</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profeAux in u.Instructores)
            {
                if (profeAux != clase)
                {
                    return profeAux;
                }
            }
            throw new SinProfesorException();

        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, g == clase);
            g.Jornada.Add(jornada);
            foreach (Alumno alumnoAux in g.Alumnos)
            {
                if (alumnoAux == clase)
                {
                    jornada += alumnoAux;
                }
            }

            return g;
        }

        /// <summary>
        /// Agrega Alumno a la Universidad si este no se encuentra ya en la misma
        /// </summary>
        /// <param name="u">Universidad que se agregará el alumno</param>
        /// <param name="a">Alumno que se agregará a la universidad</param>
        /// <returns>Universidad con el Alumno</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            return u;
        }

        /// <summary>
        /// Agrega un Profesor a la Universidad si este no se encuetra ya en la misma
        /// </summary>
        /// <param name="u">Universidad que se agregará el profesor</param>
        /// <param name="i">Profesor que se agregará a la universidad</param>
        /// <returns>Univ. con Profesor</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }
            return u;
        }

        /// <summary>
        /// Hace publicos los datos de la Universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion


        #region Methods
        /// <summary>
        /// Lee el archivo que contiene la universidad en xml
        /// </summary>
        /// <returns>la Universidad</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> leerXml = new Xml<Universidad>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Universidad.xml";
            if (leerXml.Leer(archivo, out Universidad uni))
            {
                return uni;
            }
            return uni;

        }

        /// <summary>
        /// Guarda la universidad en Xml
        /// </summary>
        /// <param name="uni">Universidad a Guardar</param>
        /// <returns>True si logro Guardar, False caso contrario</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xmlGuardar = new Xml<Universidad>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Universidad.xml";
            if (xmlGuardar.Guardar(archivo, uni))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Muestra los datos de la Universidad.
        /// </summary>
        /// <param name="uni">Universidad a mostrar</param>
        /// <returns>Los datos de la universidad</returns>
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
