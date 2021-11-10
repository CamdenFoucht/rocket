namespace Rocket.CodeAnalysis.Syntax
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhiteSpaceToken,
        NumberToken,
        PlusToken,
        MinusToken,
        SlashToken,
        StarToken,
        OpenParanthesisToken,
        CloseParenthesisToken,
        IdentifierToken,
        BangToken,
        AmpersandAmpersandToken,
        PipePipeToken,

        // Keywords
        TrueKeyword,
        FalseKeyword,

        // Expressions
        BinaryExpression,
        ParenthesizedExpression,
        LiteralExpression,
        UnaryExpression,
        EqualsEqualToken,
        BangEqualsToken,
        NameExpression,
        AssignmentExpression,
        EqualsToken,
    }
}
