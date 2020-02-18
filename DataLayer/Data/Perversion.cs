using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    class Perversion
    {
        public Usuario Usuario { get; set; }
        public Fetiche Fetiche { get; set; }
        public enum NivelConsentimiento { Alto, Medio, Bajo }
    }
}
