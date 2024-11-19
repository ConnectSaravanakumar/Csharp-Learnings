using System.Diagnostics.CodeAnalysis;

namespace Csharp_Learnings.Class
{
    public static class StringExtensions
    {
        public static bool checkNullOrEmpty([NotNullWhen(false)] this string value)
        {

            return value == null || value.Length == 0;
        }

    }
}
