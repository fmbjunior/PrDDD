using FluentValidation;
using PrDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrDDD.Service.Validators
{
    public class ProductValidator : AbstractValidator<Produto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Campo nome não pode ser vazio.")
                .NotNull().WithMessage("Campo nome não pode ser nulo")
                .Length(1, 50).WithMessage("Campo Nome deve ter o tamanho máximo de 50 caracteres");

            RuleFor(x => x.DataEntrega)
                .NotEmpty().WithMessage("Campo DataEntrada não pode ser vazio.")
                .NotNull().WithMessage("Campo DataEntrada não pode ser nulo")
                .Must(DataMenorQueHoje).WithMessage("DataEntrada tem que ser maior que a data atual.");

            RuleFor(x => x.Quantidade)
                .NotEmpty().WithMessage("Campo Quantidade não pode ser vazio.")
                .NotNull().WithMessage("Campo Quantidade não pode ser nulo")
                .GreaterThan(0).WithMessage("Campo Quantidade tem que ser maior que zero.");

            RuleFor(x => x.ValorUnitario)
                .NotEmpty().WithMessage("Campo ValorUnitario não pode ser vazio.")
                .NotNull().WithMessage("Campo ValorUnitario não pode ser nulo")
                .GreaterThan(0.0M).WithMessage("Campo ValorUnitario tem que ser maior que zero."); ;
        }

        private static bool DataMenorQueHoje(DateTime dataEntrega)
        {
            return (dataEntrega <= DateTime.Now);
        }
    }
}
