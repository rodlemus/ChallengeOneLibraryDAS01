using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        public AdministrationMenuForm()
        {
            InitializeComponent();
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryBackgroundColor();

            var buttons = this.panel1.Controls.OfType<Button>().Concat(Controls.OfType<Button>());

            foreach (var item in buttons)
            {
                item.ForeColor = AppPaletteColors.GetPrincipalBackgroundColor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rootMenu = new RootMenuForm();
            rootMenu.Show();
            this.Hide();
        }
    }
}
