using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        #region Atributtes
        private int idAula;
        private string salita;
        #endregion


        #region Properties
        public int IdAula
        {
            get
            {
                return this.idAula;
            }
            set
            {
                this.idAula = value;
            }
        }

        public string Salita
        {
            get
            {
                return this.salita;
            }
            set
            {
                this.salita = value;
            }
        }
        #endregion


        #region Constructors
        public Aula(int idAula, string salita)
        {
            this.IdAula = IdAula;
            this.Salita = salita;
        }
        #endregion
    }
}
