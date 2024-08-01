namespace ChallengeOneLibraryDAS01.Utils
{
    internal class AppPaletteColors
    {
        private const string PrincipalBackgroundColor = "#3b5998";
        private const string SecondaryBackgroundColor = "#8b9dc3";
        private const string PrimaryAccentBackgroundColor = "#dfe3ee";
        private const string SecondaryAccentBackgroundColor = "#f7f7f7";


        public static Color GetPrincipalBackgroundColor()
        {
            return ColorConverterUtils.FromHexColor(PrincipalBackgroundColor);
        }

        public static Color GetSecondaryBackgroundColor()
        {
            return ColorConverterUtils.FromHexColor(SecondaryBackgroundColor);
        }
        public static Color GetPrimaryAccentBackgroundColor()
        {
            return ColorConverterUtils.FromHexColor(PrimaryAccentBackgroundColor);
        }

        public static Color GetSecondaryAccentBackgroundColor()
        {
            return ColorConverterUtils.FromHexColor(SecondaryAccentBackgroundColor);
        }
    }
}
