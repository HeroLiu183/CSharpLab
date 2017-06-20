using System;

namespace CSharpLab.ExtensionMethod
{
    public static class ParsStringToNumber
    {
        public static int ParsToInt(this string intString )
        {
            return Int32.Parse(intString);
        }
    }
}