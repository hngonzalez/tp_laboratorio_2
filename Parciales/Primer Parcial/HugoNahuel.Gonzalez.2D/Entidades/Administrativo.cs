using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        #region Atributtes
        private ECargo cargo;
        static double salarioBase;
        #endregion

        #region Properties
        #endregion

        #region Constructors
        static Administrativo()
        {
            salarioBase = 30000;
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo) 
            : base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.cargo = cargo;
        }
        #endregion

        #region Methods
        protected override double CalcularSalario()
        {
            switch (this.cargo)
            {
                case ECargo.Cocina:
                    salarioBase = (salarioBase * 110) / 100;
                    break;
                case ECargo.Dirección:
                    salarioBase = (salarioBase * 180) / 100;
                    break;
                case ECargo.Portería:
                    salarioBase = (salarioBase * 100) / 100;
                    break;
                case ECargo.Tesorería:
                    salarioBase = (salarioBase * 240) / 100;
                    break;
                case ECargo.Secretaría:
                    salarioBase = (salarioBase * 140) / 100;
                    break;
                default:
                    break;
            }

            return salarioBase;
        }
        #endregion
    }
}
