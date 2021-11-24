using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T> where T : class
    {
        #region Enumerado

        /// <summary>
        /// Enumerado del tipo de archivo
        /// </summary>
        public enum ETipoArchivo
        {
            XML,
            JSON
        }

        #endregion

        #region Firma Guardar

        /// <summary>
        /// Firma de interfaz generica para guardar un archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        void Guardar(string path, T dato);

        #endregion

        #region Firma Leer

        /// <summary>
        /// Firma de interfaz generica para leer un archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns> Retornara un tipo generico </returns>
        T Leer(string path);

        #endregion

    }
}
