using System.Runtime.CompilerServices;

namespace Tools
{
    public class TextTool
    {
        public static string RedColorName => GetColorName();
        public static string OrangeColorName => GetColorName();
        public static string YellowColorName => GetColorName();
        public static string GreenColorName => GetColorName();
        public static string CyanColorName => GetColorName();
        public static string BlueColorName => GetColorName();
        public static string PinkColorName => GetColorName();
        public static string VioletColorName => GetColorName();
        public static string WhiteColorName => GetColorName();
        public static string BlackColorName => GetColorName();

        private static string GetColorName([CallerMemberName] string propertyName = null)
            => propertyName?.Replace("ColorName", string.Empty);

        public static string ToCapital(string text) => text?.ToUpper();
        public static int FindPosition(string text, string findingText) => (text ?? "").IndexOf(findingText);
    }

}
