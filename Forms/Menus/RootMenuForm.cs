using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class RootMenuForm : Form
    {
        private IDatabase<Book> _bookDatabase;
        private IDatabase<User> _studentsDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;

        public RootMenuForm(IDatabase<Book> bookDatabase, IDatabase<User> studentDatabase, IDatabase<BookLoan> loanDatabase)
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
            this._bookDatabase = bookDatabase;
            this._studentsDatabase = studentDatabase;
            this._bookLoanDatabase = loanDatabase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administrationMenu = new AdministrationMenuForm(this._bookDatabase, this._bookLoanDatabase, this._studentsDatabase);
            administrationMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}