using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users
{
    public partial class UsersRegistry : Form
    {
        private IDatabase<Student> _studentsDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;
        public UsersRegistry(IDatabase<Student> database, IDatabase<BookLoan> database2)
        {
            InitializeComponent();
            this._studentsDatabase = database;
            this._bookLoanDatabase = database2;
        }

    }
}
