using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMostrar<T>
    {

        #region Methods
        /// <summary>
        /// Método de la interfaz que se ejecutará para mostrar datos del obj recibido
        /// </summary>
        /// <param name="elemento">El obj que recibe dicha interfaz</param>
        /// <returns>Un string de datos</returns>
        string MostrarDatos(IMostrar<T> elemento);
        #endregion

    }
}
