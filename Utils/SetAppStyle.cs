namespace ChallengeOneLibraryDAS01.Utils
{
    internal class SetAppStyle
    {
        public static void SetDefaultWindowsStyle(Form form, Panel panel)
        {
            form.BackColor = AppPaletteColors.GetSecondaryBackgroundColor();
            panel.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
        }
    }
}
