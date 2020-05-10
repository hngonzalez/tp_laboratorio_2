using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        #region Atributtes
        private DateTime horaEntrada;
        private DateTime horaSalida;
        #endregion

        #region Properties
        public DateTime HoraEntrada
        {
            get
            {
                return this.horaEntrada;
            }
            set
            {
                this.horaEntrada = value;
            }
        }

        public DateTime HoraSalida
        {
            get
            {
                return this.horaSalida;
            }
            set
            {
                this.horaSalida = value;
            }
        }

        public double Salario
        {
            get
            {
                return CalcularSalario();
            }
        }
        #endregion

        #region Constructors
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida)
            : base(nombre, apellido, dni, femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida  = horaSalida;
        }
        #endregion

        #region Methods
        protected abstract double CalcularSalario();
        #endregion
    }
}
