using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributtes
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Enumerators
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad Apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad DNI
        /// </summary>
        public int DNI
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
        /// Propiedad Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad StringToDNI
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDNI(this.Nacionalidad,value);
            }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Overload de la clase persona
        /// </summary>
        /// <param name="nombre">Elemento a cargar como atributo</param>
        /// <param name="apellido">Elemento a cargar como atributo</param>
        /// <param name="nacionalidad">Elemento a cargar como atributo</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Overload de la clase persona
        /// </summary>
        /// <param name="nombre">Elemento a cargar como atributo</param>
        /// <param name="apellido">Elemento a cargar como atributo</param>
        /// <param name="nacionalidad">Elemento a cargar como atributo</param>
        /// <param name="dni">Elemento a cargar como atributo</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) 
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Overload de la clase persona, recibe DNI como string
        /// </summary>
        /// <param name="nombre">Elemento a cargar como atributo</param>
        /// <param name="apellido">Elemento a cargar como atributo</param>
        /// <param name="nacionalidad">Elemento a cargar como atributo</param>
        /// <param name="dni">Elemento a cargar como atributo</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Verifica que el dato recibido sea un DNI válido
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre);
            sb.AppendFormat("\nNACIONALIDAD: {0}", this.Nacionalidad);

            return sb.ToString();
        }

        /// <summary>
        /// Verifica que el dato recibido sea un DNI válido
        /// </summary>
        /// <param name="nacionalidad">Elemento a verificar</param>
        /// <param name="dato">Elemento a verificar</param>
        private int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad is ENacionalidad.Argentino)
            {
                if (dato > 1 && dato < 89999999)
                {
                    return dato;
                }
            }

            if (nacionalidad is ENacionalidad.Extranjero)
            {
                if (dato > 90000000 && dato < 99999999)
                {
                    return dato;
                }
            }

            throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
        }

        /// <summary>
        /// Parsea el dato recibido por parámetro y luego valida el DNI 
        /// </summary>
        /// <param name="nacionalidad">Elemento a verificar</param>
        /// <param name="dato">Elemento a parsear</param>
        private int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            int datoInt = 0;

            if (int.TryParse(dato, out datoInt))
            {
                datoInt = ValidarDNI(nacionalidad, datoInt);
            }
            else
            {
                throw new DniInvalidoException();
            }

            return datoInt;
        }

        /// <summary>
        /// Valida que el dato recibido por parámetro sean únicamente caracteres
        /// </summary>
        /// <param name="dato">Elemento a verificar</param>
        private string ValidarNombreApellido(string dato)
        {
            foreach (Char caracter in dato)
            {
                if (!char.IsLetter(caracter))
                {
                    return "";
                }
            }

            return dato;
        }
        #endregion

    }
}
