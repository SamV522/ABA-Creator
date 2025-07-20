using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Creator.ABA.Extensions
{
    internal class AggregateValidationException : Exception
    {
        public IReadOnlyList<ValidationResult> ValidationResults { get; }

        public AggregateValidationException(IEnumerable<ValidationResult> results)
            : base("Validation failed with one or more errors.")
        {
            ValidationResults = results.ToList();
        }
    }
}
