using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class RootMenuForm : Form
    {
        public RootMenuForm()
        {
            InitializeComponent();
            //Form Backgrounds colors
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryBackgroundColor();

            //Buttons text color
            this.button1.ForeColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.button2.ForeColor = AppPaletteColors.GetPrincipalBackgroundColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administrationMenu = new AdministrationMenuForm();
            administrationMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}