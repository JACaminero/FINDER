using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Business;

namespace DataLayer
{
    public class Sexo
    {
        public int ID_Sexo { get; set; }
        public string NombreSexo { get; set;  }

        /// <summary>
        /// Controlador default.
        /// </summary>
        public Sexo() { }
        
        /// <summary>
        /// Gets las propiedades de un sexo dado su id de base de datos
        /// </summary>
        /// <param name="idSexo"> El id del sexo en la base de datos </param>
        public Sexo(int idSexo)
        {
            BusinessSexo businessSexo = new BusinessSexo();

            Sexo sexo = businessSexo.GetByID(idSexo);

            ID_Sexo = sexo.ID_Sexo;
            NombreSexo = sexo.NombreSexo;
        }

    }
}
