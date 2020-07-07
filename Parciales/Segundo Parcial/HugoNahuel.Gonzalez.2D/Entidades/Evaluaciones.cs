using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Evaluaciones
    {
        #region Atributtes
        private int idAlumno;
        private int idDocente;
        private int idAula;
        private int Nota_1;
        private int Nota_2;
        private float NotaFinal;
        private string Observaciones;
        private Random random = new Random();
        #endregion

        #region Properties
        public int IdAlumno
        {
            get
            {
                return this.idAlumno;
            }
            set
            {
                this.idAlumno = value;
            }
        }

        public int IdDocente
        {
            get
            {
                return this.idDocente;
            }
            set
            {
                this.idDocente = value;
            }
        }

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

        public int Nota1
        {
            get
            {
                return this.Nota_1;
            }
            set
            {
                this.Nota_1 = value;
            }
        }

        public int Nota2
        {
            get
            {
                return this.Nota_2;
            }
            set
            {
                this.Nota_2 = value;
            }
        }

        public float Notafinal
        {
            get
            {
                return this.NotaFinal;
            }
            set
            {
                this.NotaFinal = value;
            }
        }

        public string observaciones
        {
            get
            {
                return this.Observaciones;
            }
            set
            {
                this.Observaciones = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la clase por defecto
        /// </summary>
        public Evaluaciones()
        {

        }

        /// <summary>
        /// Overload de la clase
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="idDocente"></param>
        /// <param name="idAula"></param>
        /// <param name="Nota_1"></param>
        /// <param name="Nota_2"></param>
        /// <param name="notaFinal"></param>
        /// <param name="observacion"></param>
        public Evaluaciones(int idAlumno, int idDocente, int idAula, int Nota_1, int Nota_2, float notaFinal, string observacion) 
            : this()
        {
            this.idAlumno = idAlumno;
            this.idDocente = idDocente;
            this.idAula = idAula;
            this.Nota_1 = Nota_1;
            this.Nota_2 = Nota_2;
            this.NotaFinal = notaFinal;
            this.Observaciones = observacion;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Método que evalúa al alumno con una sala y docente al azar
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="docente"></param>
        /// <param name="aula"></param>
        public float Evaluar(Alumno alumno, Docente docente, Aula aula)
        {
            Thread.Sleep(8000);

            int auxNota1 = random.Next(1, 10);
            int auxNota2 = random.Next(1, 10);
            float auxNotaFinal = (auxNota1 + auxNota2) / 2;
            string auxObser = String.Empty;

            if (auxNotaFinal < 4)
            {
                auxObser = "DESAPROBADO";
            }
            else
            {
                auxObser = "APROBADO";
            }

            Evaluaciones evaluado = new Evaluaciones(alumno.IdAlumno,docente.Id,aula.IdAula,auxNota1, auxNota2, auxNotaFinal, auxObser);

            DataSQL.GrabarEvaluacionSQL(evaluado);
            DataFiles.SerializarAlumno(alumno, auxObser);

            return auxNotaFinal;
        }
        #endregion
    }
}
