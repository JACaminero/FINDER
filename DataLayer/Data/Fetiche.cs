using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Business;
namespace DataLayer.Data
{
    public class Fetiche
    {
        public int ID_Fetiche { get; set; }
        public string NombreFetiche { get; set; }

        public Fetiche() { }
        public Fetiche(int idFetiche)
        {
            BusinessFetiche businessFetiche = new BusinessFetiche();

            Fetiche Fetiche = businessFetiche.GetById(idFetiche);

            Fetiche.ID_Fetiche = ID_Fetiche;
            Fetiche.NombreFetiche = NombreFetiche;
        }

    }
}
