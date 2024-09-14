using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users;
using ChallengeOneLibraryDAS01.Forms.Menus.Reports;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        private IDatabase<Book> _bookDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;
        private IDatabase<User> _usersDatabase;
        public AdministrationMenuForm(IDatabase<Book> database, IDatabase<BookLoan> databaseLoan, IDatabase<User> studentDatabase)
        {
            InitializeComponent();
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();

            this._bookDatabase = database;
            this._bookLoanDatabase = databaseLoan;
            this._usersDatabase = studentDatabase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var booksRegistryMenu = new BooksRegistryForm(this._bookDatabase, this);
            booksRegistryMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userRegistry = new UsersRegistry(this._bookDatabase, this._usersDatabase, this._bookLoanDatabase, this);
            userRegistry.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var reportsCharts = new ReportsChartForm(this._bookDatabase, this._bookLoanDatabase, this._usersDatabase, this);
            reportsCharts.Show();
            this.Hide();
        }
    }
}
