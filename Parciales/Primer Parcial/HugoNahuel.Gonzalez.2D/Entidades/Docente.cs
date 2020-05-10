using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        #region Atributtes
        private double valorHora;
        #endregion

        #region Properties
        public double ValorHora
        {
            get
            {
                return this.valorHora;
            }
            set
            {
                this.valorHora = value;
            }
        }

        public int HorasMensuales
        {
            get
            {
                return (int)CalcularSalario();
            }
        }
        #endregion

        #region Constructors
        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora)
            : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.valorHora = valorHora;
        }
        #endregion

        #region Methods
        protected override double CalcularSalario()
        {
            TimeSpan diferencia = this.HoraSalida - this.HoraEntrada;
            string dif1 = diferencia.Hours.ToString()+','+diferencia.Minutes.ToString();
            double min;

            double.TryParse(dif1, out min);

            min = (min*this.valorHora) * 20;

            return min;
        }
        #endregion
    }
}
