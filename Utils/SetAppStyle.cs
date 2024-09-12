namespace ChallengeOneLibraryDAS01.Utils
{
    internal class SetAppStyle
    {
        public static void SetDefaultWindowsStyle(Form form, Panel panel)
        {
            form.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            panel.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();
        }
    }
}
