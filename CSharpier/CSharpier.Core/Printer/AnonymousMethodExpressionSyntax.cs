using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.Core
{
    public partial class Printer
    {
        private Doc PrintAnonymousMethodExpressionSyntax(AnonymousMethodExpressionSyntax node)
        {
            var parts = new Parts();
            parts.Push(this.PrintSyntaxToken(node.AsyncKeyword, " "));
            parts.Push(this.PrintSyntaxToken(node.DelegateKeyword));
            if (node.ParameterList != null) {
                parts.Add(this.PrintParameterListSyntax(node.ParameterList));
            }
            // TODO 2 when will ExpressionBody ever exist? I can't find it in testing.
            parts.Add(this.PrintBlockSyntax(node.Block));
            
            return Concat(parts);
        }
    }
}