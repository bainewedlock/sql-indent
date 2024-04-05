using System.Text;
using PoorMansTSqlFormatterRedux.Formatters;
using PoorMansTSqlFormatterRedux.Parsers;
using PoorMansTSqlFormatterRedux.Tokenizers;

string? s;
var sql = new StringBuilder();
while ((s = Console.ReadLine()) != null)
{
    sql.AppendLine(s);
}

var tokenizer = new TSqlStandardTokenizer();
var parser = new TSqlStandardParser();
var formatter = new TSqlStandardFormatter();

var tokens = tokenizer.TokenizeSQL(sql.ToString());
var tree = parser.ParseSQL(tokens);
var formatted = formatter.FormatSQLTree(tree);

Console.WriteLine(formatted);

