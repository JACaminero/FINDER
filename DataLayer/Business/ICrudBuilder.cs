using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface ICrudBuilder<T> where T: class
    {
        /// <summary>
        /// Inserta un dato en la base de datos
        /// </summary>
        /// <param name="obj"> El objeto que se va a insertar </param>
        void Insert(T sujeto);
        /// <summary>
        /// Actualiza un objeto en la base de datos
        /// </summary>
        /// <param name="sujeto"> El objeto que se va a modificar </param>
        void Update(T sujeto);
        /// <summary>
        /// Borra un objeto en la base de datos
        /// </summary>
        /// <param name="id"> el id de quien se va a eliminar </param>
        void Delete(int id);
        /// <summary>
        /// Busca todos los objetos de este tipo que estan almacenados en la base de datos
        /// </summary>
        /// <returns></returns>
        List<T> SelectAll();
        /// <summary>
        /// Gets un registro especifico de la base de datos dado su id
        /// </summary>
        /// <param name="id"> id de quien se va a buscar </param>
        /// <returns></returns>
        T GetWithId(int id);
    }
}
