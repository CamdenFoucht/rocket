using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rocket.CodeAnalysis.Compilation;

namespace Rocket.CodeAnalysis
{
    public sealed class EvaluationResult
    {
        public EvaluationResult(IEnumerable<Diagnostic> diagnostics, object value)
        {
            Diagnostics = diagnostics.ToArray();
            Value = value;
        }

        public IReadOnlyList<Diagnostic> Diagnostics { get; private set; }
        public object Value { get; }
    }
}
