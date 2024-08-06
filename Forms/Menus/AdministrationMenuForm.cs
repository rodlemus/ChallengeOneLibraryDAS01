using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        public AdministrationMenuForm()
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var booksRegistryMenu = new BooksRegistryForm();
            booksRegistryMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rootMenu = new RootMenuForm();
            rootMenu.Show();
            this.Hide();
        }
    }
}
