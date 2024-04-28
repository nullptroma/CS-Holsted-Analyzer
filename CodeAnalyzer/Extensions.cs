namespace CodeAnalyzer;

public static class Extensions
{
    public static string? AddSpacesRightToLen(this object obj, int targetLen)
    {
        var str = obj.ToString();
        if (str == null)
            return null;
        var diff = targetLen - str.Length;
        if (diff <= 0)
            return str;
        return str + new string(' ', diff);
    }
}