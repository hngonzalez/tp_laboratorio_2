using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributtes
        private string apellido;
        private string nombre;
        private int dni;
        private bool femenino;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad para el Apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = Validaciones.ValidateOnlyLetters(value);
            }
        }

        /// <summary>
        /// Propiedad para el Nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = Validaciones.ValidateOnlyLetters(value);
            }
        }

        /// <summary>
        /// Propiedad para el Dni
        /// </summary>
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

        /// <summary>
        /// Propiedad para Femenino
        /// </summary>
        public bool Femenino
        {
            get
            {
                return this.femenino;
            }
            set
            {
                this.femenino = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        protected Persona()
        {
            this.nombre = String.Empty;
            this.apellido = String.Empty;
            this.dni = 0;
        }

        /// <summary>
        /// Overload del constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"> El nombre asignado a su atributo
        /// <param name="apellido"> Apellido que será asignado a su atributo
        /// <param name="dni"> Dni que será asignado a su atributo
        protected Persona (string nombre, string apellido, int dni) 
            : this()
        {
            this.nombre     = nombre;
            this.apellido   = apellido;
            this.dni        = dni;
        }

        /// <summary>
        /// Overload del constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"> El nombre asignado a su atributo
        /// <param name="apellido"> Apellido que será asignado a su atributo
        /// <param name="dni"> Dni que será asignado a su atributo
        /// <param name="femenino"> Sera asignado a su atributo
        protected Persona(string nombre, string apellido, int dni, bool femenino) 
            : this(nombre, apellido, dni)
        {
            this.femenino = femenino;
        }
        #endregion

        #region Methods
        #endregion
    }
}
