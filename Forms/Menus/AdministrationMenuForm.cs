using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        private IDatabase<Book> _bookDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;
        private IDatabase<User> _studentDatabase;
        public AdministrationMenuForm(IDatabase<Book> database, IDatabase<BookLoan> databaseLoan, IDatabase<User> studentDatabase)
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
            this._bookDatabase = database;
            this._bookLoanDatabase = databaseLoan;
            this._studentDatabase = studentDatabase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var booksRegistryMenu = new BooksRegistryForm(this._bookDatabase, this);
            booksRegistryMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rootMenu = new RootMenuForm(this._bookDatabase, this._studentDatabase, this._bookLoanDatabase);
            rootMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userRegistry = new UsersRegistry(this._bookDatabase, this._studentDatabase, this._bookLoanDatabase, this);
            userRegistry.Show();
            this.Hide();
        }
    }
}
