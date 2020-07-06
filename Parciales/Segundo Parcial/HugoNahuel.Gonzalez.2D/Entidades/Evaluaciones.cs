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
        private int idEvaluacion;
        private int idAlumno;
        private int idDocente;
        private int idAula;
        private int Nota_1;
        private int Nota_2;
        private float NotaFinal;
        private string Observaciones;
        private Random random;
        private int auxIdEvalu = 0;
        #endregion

        #region Constructors
        public Evaluaciones(int idEvaluacion, int idAlumno, int idDocente, int idAula, int Nota_1, int Nota_2, float notaFinal, string observacion)
        {
            this.idEvaluacion = idEvaluacion;
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
        public void Evaluar(Alumno alumno, Docente docente, Aula aula)
        {
            Thread.Sleep(8000);

            this.auxIdEvalu++;
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

            Evaluaciones evaluado = new Evaluaciones(auxIdEvalu, alumno.IdAlumno,docente.Id,aula.IdAula,auxNota1, auxNota2, auxNotaFinal, auxObser);

        }
        #endregion
    }
}
