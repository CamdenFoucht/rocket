using System;

namespace Rocket.CodeAnalysis.Binding
{
    internal abstract class BoundExpression: BoundNode
    {
        public abstract Type Type { get; }
    }
}