using Irony.Ast;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace Ebister.Parsing.Node
{
	public class LiteralNode : ExpressionNode
	{
		public EbiValueBase Value { get; }
		public LiteralNode(EbiValueBase value) => Value = value;

		public override string ToString() => Value.ToString() ?? "null";
	}
	public class IdentifierNode : ExpressionNode
	{
		public string Name { get; }
		public IdentifierNode(string name) => Name = name;

		public override string ToString() => $"(id {Name})";
	}
}
