using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Estacionamiento
    {
        #region Enumerators
        /// <summary>
        /// Enumerador
        /// </summary>
        public enum ETipo
        {
            Moto, Automovil, Camioneta, Todos
        }
        #endregion

        #region Atributtes
        /// <summary>
        /// Atributos
        /// </summary>
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de la clase por defecto
        /// </summary>
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Overload de la clase por defecto
        /// </summary>
        public Estacionamiento(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Estacionamiento.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="estacionamiento">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Estacionamiento estacionamiento, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", estacionamiento.vehiculos.Count, estacionamiento.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                    case ETipo.Moto:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                    case ETipo.Automovil:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                    default:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento c, Vehiculo p)
        {
            int cant = c.vehiculos.Count();

            foreach (Vehiculo v in c.vehiculos)
            {
                if (v == p)
                    return c;
            }

            if (cant < c.espacioDisponible)
            {
               c.vehiculos.Add(p);
            }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Estacionamiento operator -(Estacionamiento c, Vehiculo p)
        {
            if (c.vehiculos.Count() > 0)
            {
                foreach (Vehiculo v in c.vehiculos)
                {
                    if (v == p)
                    {
                        c.vehiculos.Remove(p);
                        break;
                    }
                }
            }          

            return c;
        }
        #endregion
    }
}
