using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region Atributtes
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private ETurno turno;
        private Responsable responsable;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de ColorSala
        /// </summary>
        public EColores ColorSala
        {
            get
            {
                return this.colorSala;
            }
            set
            {
                this.colorSala = value;
            }
        }

        /// <summary>
        /// Propiedad de Legajo
        /// </summary>
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        /// <summary>
        /// Propiedad de PrecioCuota
        /// </summary>
        public float PrecioCuota
        {
            get
            {
                return this.precioCuota;
            }
            set
            {
                this.precioCuota = value;
            }
        }

        /// <summary>
        /// Propiedad de Responsable
        /// </summary>
        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }

        /// <summary>
        /// Propiedad de Turno
        /// </summary>
        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Overload del constructor de la clase Alumno
        /// </summary>
        /// <param name="nombre"> El nombre asignado a su atributo
        /// <param name="apellido"> Apellido que será asignado a su atributo
        /// <param name="dni"> Dni que será asignado a su atributo
        /// <param name="femenino"> Femenino será asignado a su atributo
        /// <param name="legajo"> Legajo será asignado a su atributo
        /// <param name="precioCuota"> PrecioCuota que será asignado a su atributo
        public Alumno(string nombre, string apellido, int dni, bool femenino, int legajo, float precioCuota, ETurno turno)
            : base(nombre, apellido, dni, femenino)
        {
            this.legajo = legajo;
            this.precioCuota = precioCuota;
            this.turno = turno;
        }
        #endregion

        #region Operators
        /// <summary>
        /// 2 Alumnos son iguales si sus legajos son iguales
        /// </summary>
        /// <param name="a1"> Alumno a comparar
        /// <param name="a2"> Alumno a comparar
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.legajo == a2.legajo)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 2 Alumnos son distintos si sus legajos no son iguales
        /// </summary>
        /// <param name="a1"> Alumno a comparar
        /// <param name="a2"> Alumno a comparar
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return (!(a1 == a2));
        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        public string toString()
        {
            return "";
        }
        #endregion
    }
}
