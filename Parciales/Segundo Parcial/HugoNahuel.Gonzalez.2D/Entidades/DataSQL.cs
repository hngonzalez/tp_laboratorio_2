using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class DataSQL
    {
        #region Atributtes
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor que instancia y setea atributos para lectura
        /// </summary>
        static DataSQL()
        {
            conexion = new SqlConnection("Data Source = DESKTOP-RLNJE2L; Initial Catalog = JardinUtn; Integrated Security=True ");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Método que realiza el insert en la DB 
        /// </summary>
        /// <param name="docente"></param>
        /// <returns></returns>
        public static void GrabaXMLaSQL(List<Docente> docentes)
        {
            try
            {
                conexion.Open();

                foreach (Docente docente in docentes)
                {
                    comando.CommandText = "SET IDENTITY_INSERT Docentes ON insert into Docentes (idDocente, Nombre, Apellido, Edad, Sexo, Dni, Direccion, Email) " +
                                          "values ('" + docente.Id + "','" + docente.Nombre + "','" + docente.Apellido + "','"
                                                      + docente.Edad + "','" + docente.Sexo + "','" + docente.Dni + "','" 
                                                      + docente.Direccion + "','" + docente.Email + "') SET IDENTITY_INSERT Docentes OFF";    
                    comando.ExecuteNonQuery();
                }
            }
            catch (GrabaXMLSQLException)
            {
                throw new GrabaXMLSQLException("Error al grabar en la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lectura de los alumnos en la base de datos
        /// </summary>
        /// <returns>Lista de alumnos</returns>
        public static Queue<Alumno> LeerAlumnosSQL()
        {
            Queue<Alumno> auxLista = new Queue<Alumno>();

            try
            {
                conexion.Open();

                comando.CommandText = "select * from Alumnos";

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Alumno auxAlumno = new Alumno(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                  reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5));
                    
                    auxLista.Enqueue(auxAlumno);
                }

                return auxLista;
            }
            catch (LecturaSQLException)
            {
                throw new LecturaSQLException("Error al leer Alumno en la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lectura de las aulas en la base de datos
        /// </summary>
        /// <returns>Lista de aulas</returns>
        public static List<Aula> LeerAulasSQL()
        {
            List<Aula> auxLista = new List<Aula>();

            try
            {
                conexion.Open();

                comando.CommandText = "select * from Aulas";

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Aula auxAula = new Aula(reader.GetInt32(0),
                                            reader.GetString(1));

                    auxLista.Add(auxAula);
                }

                return auxLista;
            }
            catch (LecturaSQLException)
            {
                throw new LecturaSQLException("Error al leer Aula en la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lee los Docentes que hay cargados en la db
        /// </summary>
        /// <returns>Lista de aulas</returns>
        public static List<Docente> LeerDocentesSQL()
        {
            List<Docente> auxLista = new List<Docente>();

            try
            {
                conexion.Open();

                comando.CommandText = "select * from Docentes";

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Docente auxDocente = new Docente( reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                      reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5),
                                                      reader.GetString(6), reader.GetString(7));

                    auxLista.Add(auxDocente);
                }

                return auxLista;
            }
            catch (LecturaSQLException)
            {
                throw new LecturaSQLException("Error al leer Docente en la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Graba la evaluación del alumno en la db
        /// </summary>
        public static void GrabarEvaluacionSQL(Evaluaciones evaluacion)
        {
            try
            {
                conexion.Open();

                comando.CommandText = "insert into Evaluaciones " +
                                    " values ('"+ evaluacion.IdAlumno + "','"+ evaluacion.IdDocente + "','" + evaluacion.IdAula + "','"
                                                + evaluacion.Nota1+ "','" + evaluacion.Nota2 + "','"+ evaluacion.Notafinal + "','"
                                                + evaluacion.observaciones + "')";

                comando.ExecuteNonQuery();
            }
            catch (GrabaEnSQLException)
            {
                throw new GrabaEnSQLException("Error al grabar evaluación en la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion
    }
}

