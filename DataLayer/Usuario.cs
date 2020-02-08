using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Bio { get; set; }
        public string Localizacion { get; set; }
        public decimal Patrimonio { get; set; }
        public char Genero { get; set; }
        public byte[] Imagen { get; set; }
    }
}
