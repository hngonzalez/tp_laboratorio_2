using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
        #region Atributtes
        private EParentesco parentesco;
        private string telefono;
        private int legajo;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad del parentesco
        /// </summary>
        public EParentesco Parentesco
        {
            get
            {
                return this.parentesco;
            }
            set
            {
                this.parentesco = value;
            }
        }

        /// <summary>
        /// Propiedad de telefono
        /// </summary>
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Overload del constructor de la clase
        /// </summary>
        /// <param name="nombre"> El nombre asignado a su atributo
        /// <param name="apellido"> Apellido que será asignado a su atributo
        /// <param name="dni"> Dni que será asignado a su atributo
        /// <param name="femenino"> Dni que será asignado a su atributo
        /// <param name="parentesco"> Dni que será asignado a su atributo
        /// <param name="telefono"> Dni que será asignado a su atributo
        private Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono, int legajo) 
            : base(nombre,apellido,dni,femenino)
        {
            this.parentesco = parentesco;
            this.telefono   = telefono;
        }
        #endregion
    }
}
