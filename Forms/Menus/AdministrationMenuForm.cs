using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        private IDatabase<Book> _bookDatabase;
        public AdministrationMenuForm(IDatabase<Book> database)
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
            this._bookDatabase = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var booksRegistryMenu = new BooksRegistryForm(this._bookDatabase);
            booksRegistryMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rootMenu = new RootMenuForm(this._bookDatabase);
            rootMenu.Show();
            this.Hide();
        }
    }
}
