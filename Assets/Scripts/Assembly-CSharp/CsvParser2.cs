using System.Collections.Generic;
using System.IO;
using System.Text;

public class CsvParser2
{
	private abstract class ParserState
	{
		public static readonly LineStartState LineStartState;

		public static readonly ValueStartState ValueStartState;

		public static readonly ValueState ValueState;

		public static readonly QuotedValueState QuotedValueState;

		public static readonly QuoteState QuoteState;

		public abstract ParserState AnyChar(char ch, ParserContext context);

		public abstract ParserState Comma(ParserContext context);

		public abstract ParserState Quote(ParserContext context);

		public abstract ParserState EndOfLine(ParserContext context);
	}

	private class LineStartState : ParserState
	{
		public override ParserState AnyChar(char ch, ParserContext context)
		{
			return null;
		}

		public override ParserState Comma(ParserContext context)
		{
			return null;
		}

		public override ParserState Quote(ParserContext context)
		{
			return null;
		}

		public override ParserState EndOfLine(ParserContext context)
		{
			return null;
		}
	}

	private class ValueStartState : LineStartState
	{
		public override ParserState EndOfLine(ParserContext context)
		{
			return null;
		}
	}

	private class ValueState : ParserState
	{
		public override ParserState AnyChar(char ch, ParserContext context)
		{
			return null;
		}

		public override ParserState Comma(ParserContext context)
		{
			return null;
		}

		public override ParserState Quote(ParserContext context)
		{
			return null;
		}

		public override ParserState EndOfLine(ParserContext context)
		{
			return null;
		}
	}

	private class QuotedValueState : ParserState
	{
		public override ParserState AnyChar(char ch, ParserContext context)
		{
			return null;
		}

		public override ParserState Comma(ParserContext context)
		{
			return null;
		}

		public override ParserState Quote(ParserContext context)
		{
			return null;
		}

		public override ParserState EndOfLine(ParserContext context)
		{
			return null;
		}
	}

	private class QuoteState : ParserState
	{
		public override ParserState AnyChar(char ch, ParserContext context)
		{
			return null;
		}

		public override ParserState Comma(ParserContext context)
		{
			return null;
		}

		public override ParserState Quote(ParserContext context)
		{
			return null;
		}

		public override ParserState EndOfLine(ParserContext context)
		{
			return null;
		}
	}

	private class ParserContext
	{
		private readonly StringBuilder _currentValue;

		private readonly List<string[]> _lines;

		private readonly List<string> _currentLine;

		public int MaxColumnsToRead { get; set; }

		public void AddChar(char ch)
		{
		}

		public void AddValue()
		{
		}

		public void AddLine()
		{
		}

		public List<string[]> GetAllLines()
		{
			return null;
		}
	}

	private const char CommaCharacter = ',';

	private const char QuoteCharacter = '"';

	public bool TrimTrailingEmptyLines { get; set; }

	public int MaxColumnsToRead { get; set; }

	public string[][] Parse(TextReader reader)
	{
		return null;
	}

	public static string[][] Parse(string input)
	{
		return null;
	}
}
