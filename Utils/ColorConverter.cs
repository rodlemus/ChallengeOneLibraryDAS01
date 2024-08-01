namespace ChallengeOneLibraryDAS01.Utils
{
    internal class ColorConverterUtils
    {
        public static Color FromHexColor(string hexColor)
        {
            return ColorTranslator.FromHtml(hexColor);
        }
    }
}
