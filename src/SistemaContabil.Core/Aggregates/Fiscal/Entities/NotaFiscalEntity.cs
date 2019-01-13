using FluentValidation;
using SistemaContabil.Core.SharedKernel.Entities;
using System;

namespace SistemaContabil.Core.Aggregates.Fiscal.Entities
{
    public class NotaFiscalEntity : BaseEntity<NotaFiscalEntity>
    {
        public int NumeroNf { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime DataNf { get; set; }

        public string CnpjEmissorNf { get; set; }

        public string CnpjDestinatarioNf { get; set; }

        public override bool IsValid()
        {
            RuleFor(x => x.NumeroNf)
                .Empty()
                .WithMessage("O valor do campo 'NumeroNF' não pode ser vazio.");

            RuleFor(x => x.ValorTotal)
                .LessThanOrEqualTo(0)
                .WithMessage("O valor do campo 'Valor Total' deve ser maior que zero.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
