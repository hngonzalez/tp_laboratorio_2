using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alumno
    {
        #region Atributtes
        private int idAlumno;
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;
        private string direccion;
        #endregion

        #region Properties
        public int IdAlumno
        {
            get
            {
                return this.idAlumno;
            }
            set
            {
                this.idAlumno = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase Alumno
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Overload del constructor por default
        /// </summary>
        /// <param name="idalumno"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        public Alumno(int idalumno, string nombre, string apellido, int edad, int dni, string direccion)
        {
            this.IdAlumno = idalumno;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Dni = dni;
            this.Direccion = direccion;
        }
        #endregion

    }
}
