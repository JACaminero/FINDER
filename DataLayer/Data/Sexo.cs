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
        
        public Sexo(int idSexo)
        {
            BusinessSexo businessSexo = new BusinessSexo();

            Sexo sexo = businessSexo.GetByID(idSexo);

            sexo.ID_Sexo = ID_Sexo;
            sexo.NombreSexo = NombreSexo;
        }

    }
}
