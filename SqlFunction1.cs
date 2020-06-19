using System.Data.SqlTypes;
using System.Text.RegularExpressions;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlString cfn_RegexReplace(SqlString expression, SqlString pattern, SqlString replace)
    {
        if (expression.IsNull || pattern.IsNull || replace.IsNull)
            return SqlString.Null;

        Regex r = new Regex(pattern.ToString());

        return new SqlString(r.Replace(expression.ToString(), replace.ToString()));

    } // public static SqlString cfn_RegexReplace

} // End public partial class UserDefinedFunctions
