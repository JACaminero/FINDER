using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FluentValidation;

namespace DataLayer
{
    [FluentValidation.Attributes.Validator(typeof(UsuarioValidator))]
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Bio { get; set; }
        public string Localizacion { get; set; }
        public decimal Patrimonio { get; set; }
        public Sexo Sexo { get; set; }
        public Atraccion Atraccion { get; set; }
        public byte[] Imagen { get; set; }
    }

    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.ID).NotEmpty().WithMessage("Inserte un ID");
            RuleFor(u => u.Nombre)
                .NotEmpty().WithMessage("Especifique un nombre")
                .Length(1, 60).WithMessage("Problema de Overflow");

            RuleFor(u => u.FechaNacimiento).NotEmpty()
                .WithMessage("Especifique una fecha de nacimiento").Must(BeAValidDate)
                .WithMessage("Especifique una fecha de nacimiento valida");
            
            RuleFor(u => u.Sexo).NotEmpty().WithMessage("Especifique un Genero");
            RuleFor(u => u.Localizacion).NotEmpty().WithMessage("Especifique una localizacion");
            RuleFor(u => u.Patrimonio).NotEmpty().WithMessage("Especifique un patrimonio");


            RuleSet("Insert", () =>
            {
                RuleFor(u => u.Nombre)
                .NotEmpty().WithMessage("Especifique un nombre")
                .Length(0, 60).WithMessage("problema de Overflow");

                RuleFor(u => u.FechaNacimiento)
                .NotEmpty().WithMessage("Especifique una fecha de nacimiento")
                .Must(BeAValidDate).WithMessage("Especifique una fecha de nacimiento valida");

                RuleFor(u => u.Sexo).NotEmpty().WithMessage("Especifique un Genero");
                RuleFor(u => u.Localizacion).NotEmpty().WithMessage("Especifique una localizacion");
                RuleFor(u => u.Patrimonio).NotEmpty().WithMessage("Especifique un patrimonio");
            });


            RuleSet("GetByID", () =>
            {
                RuleFor(m => m.ID).NotEmpty().WithMessage("Inserte un ID");
            });
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

    }

}

