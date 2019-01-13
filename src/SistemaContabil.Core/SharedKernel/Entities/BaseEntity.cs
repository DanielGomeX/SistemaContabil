using FluentValidation;
using FluentValidation.Results;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaContabil.Core.SharedKernel.Entities
{
    public abstract class BaseEntity<TEntity> : AbstractValidator<TEntity> where TEntity : class
    {
        public Guid Id { get; set; }

        protected BaseEntity()
        {
            ValidationResult = new ValidationResult();
        }

        [NotMapped]
        public ValidationResult ValidationResult { get; set; }

        [NotMapped]
        public string SequenceTable { get; set; }

        public abstract bool IsValid();
    }
}
