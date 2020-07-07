using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente
    {
        #region Atributtes
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;
        private string direccion;
        private int id;
        private string sexo;
        private string email;
        #endregion


        #region Properties
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

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Docente()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="id"></param>
        /// <param name="sexo"></param>
        /// <param name="email"></param>
        public Docente(int id,string nombre, string apellido, int edad, string sexo, int dni, string direccion, string email)
            : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Id = id;
            this.Sexo = sexo;
            this.Email = email;
        }
        #endregion


        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int ValidateStringToInt(string data)
        {
            int auxInt;

            if (!int.TryParse(data, out auxInt))
            {
                auxInt = 0;
            }

            return auxInt;
        }

        public void EvaluarAlumno()
        {

        }
        #endregion

    }
}
