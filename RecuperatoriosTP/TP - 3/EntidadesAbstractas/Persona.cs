using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        #region Enumerators
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion


        #region Atributtes
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion 


        #region Properties
        /// <summary>
        /// Propiedad del nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {

                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad del Apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {

                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad del DNI
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }

        /// <summary>
        /// Propiedad del DNI
        /// </summary>
        public string stringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }


        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        #endregion 


        #region Constructors
        /// <summary>
        /// Constructor de la clase por Defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Overload del constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Overload del constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido,
            nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Overload del constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido,
            nacionalidad)
        {
            this.stringToDNI = dni;
        }
        #endregion


        #region Overloads
        /// <summary>
        /// Retorna la informacion de la persona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre);
            sb.AppendFormat("\nNACIONALIDAD: {0}", this.Nacionalidad);

            return sb.ToString();
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Método para validar DNI de la persona
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">El DNI a validar</param>
        /// <returns>DNI validado</returns> 
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
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
        /// Método para validar DNI de la perso na
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">El DNI a validar</param>
        /// <returns>DNI validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoDNI;

            if (!int.TryParse(dato, out datoDNI))
            {
                throw new DniInvalidoException();
            }

            return ValidarDni(nacionalidad, datoDNI);
        }

        /// <summary>
        /// Valida si el nombre/apellido es una cadena valida.
        /// </summary>
        /// <param name="dato"></param>Cadena Nombre/Apellido a Validar.
        /// <returns>retorna 1 si es correcto, 0 sino lo es</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char letra in dato)
            {
                if (!(char.IsLetter(letra)))
                {
                    return "";
                }
            }
            return dato;
        }
    }
    #endregion

}