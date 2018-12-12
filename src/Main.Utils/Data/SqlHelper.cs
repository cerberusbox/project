using System.Linq;

namespace Main.Utils.Data
{
    public static class SqlHelper
    {
        public static string As => "AS";
        public static string Distinct => "DISTINCT";
        public static string Top(int many) => $"TOP({many})";
        public static string Min(string what) => $"MIN({what})";
        public static string Max(string what) => $"MAX({what})";
        public static string Avg(string what) => $"AVG({what})";
        public static string Sum(string what) => $"SUM({what})";
        public static string Count(string what) => $"COUNT({what})";
        public static string From => "FROM";
        public static string Where => "WHERE";
        public static string Like => "LIKE";
        public static string And => "AND";
        public static string Or => "OR";
        public static string Not => "NOT";
        public static string Between(string paramA, string paramB) => $"Between {paramA} {And} {paramB}";
        public static string In => "IN";
        public static string InArrayNumber(int[] itens) => $"IN ({string.Join(',', itens)})";
        public static string InArrayString(string[] itens) => $"IN ({string.Join(',', itens.Select(c => "'" + c + "'"))})";
        public static string Join => "JOIN";
        public static string Inner => "INNER JOIN";
        public static string Left => "LEFT JOIN";
        public static string Right => "RIGHT JOIN";
        public static string Full => "FULL JOIN";
        public static string Union => "UNION";
        public static string Having => "HAVING";
        public static string Exists => "EXISTS";
        public static string Select => "SELECT";
        public static string On => "ON";
        public static string GroupBy(string what) => $"GROUP BY {what}";
        public static string OrderBy(string what) => $"ORDER BY {what}";
        public static string Insert => "INSERT";
        public static string InsertInto => "INSERT INTO";
        public static string Values => "VALUES";
        public static string Update => "UPDATE";
        public static string Into => "INTO";
        public static string Exec => "EXEC";
        public static string IfNull(string param, string value) => $"IFNULL({param}, {value})";
        public static string Coalesce(string param, string value) => $"COALESCE({param}, {value})";
        public static string IIF(string condition, string valueA, string valueB) => $"IIF({condition}, {valueA},{valueB})";
        public static string EndLine => ";";
        public static string Go => "GO";
        public static string Declare => "DECLARE";
        public static string Procedure => "PROCEDURE";
    }
}
