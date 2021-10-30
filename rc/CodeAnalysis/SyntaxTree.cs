
using System.Linq;
using System.Collections.Generic;

namespace Rocket.CodeAnalysis
{
    sealed class SyntaxTree {
        public SyntaxTree(IEnumerable<string> diagnostics, ExpressionSyntax root, SyntaxToken endOfFileToken) {
            Root = root;
            EndOfFileToken = endOfFileToken;
            Diagnostics = diagnostics.ToArray();
        }

        public IReadOnlyList<string> Diagnostics { get; }
        public ExpressionSyntax Root { get; }
        public SyntaxToken EndOfFileToken { get; }

        public static SyntaxTree Parse(string text) {
            var parser = new Parser(text);
            return parser.Parse();
        }
    }
}




