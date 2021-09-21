
using FluentValidation;
using Tp4.Domain.Models;

namespace Tp4.AccesData.Validations
{
    public class ShipperValidator : AbstractValidator<Shippers>
    {
        public ShipperValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("El nombre de la compania no puede estar vacio");
            RuleFor(x => x.CompanyName).MaximumLength(40).WithMessage("El nombre de la compania no puede ser mayor de 40 caracteres");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("El telefono de la compania no puede estar vacio");
            RuleFor(x => x.Phone).MaximumLength(24).WithMessage("El telefono no puede ser mas de 24 caracteres");
        }

    }
}
