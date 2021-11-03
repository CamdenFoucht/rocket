using System;

namespace Rocket.CodeAnalysis.Binding
{
    internal sealed class BoundBinaryExpression: BoundExpression
    {
        public BoundBinaryExpression(BoundExpression left, BoundBinaryOperator op, BoundExpression right) {
            Left = left;
            Op = op;
            Right = right;
        }

        public override BoundNodeKind Kind =>  BoundNodeKind.BinaryExpression; 
         public override Type Type => Op.Type;
        public BoundExpression Left { get; }
        public BoundBinaryOperator Op { get; private set; }
        public BoundExpression Right { get; }
    }
}
