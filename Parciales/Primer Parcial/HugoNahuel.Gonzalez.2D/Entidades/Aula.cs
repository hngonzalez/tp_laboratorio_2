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
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;
        #endregion

        #region Properties
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

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

        public Docente Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

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
        public Aula(EColores colorSala, ETurno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }
        #endregion

        #region Operators
        /*public static bool operator +(Aula aula, Alumno alumno)
        {
            
        }*/
    #endregion
}
}
