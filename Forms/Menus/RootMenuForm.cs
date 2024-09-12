using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01
{
    public partial class RootMenuForm : Form
    {
        private IDatabase<Book> _bookDatabase;

        public RootMenuForm(IDatabase<Book> bookDatabase)
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
            this._bookDatabase = bookDatabase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administrationMenu = new AdministrationMenuForm(this._bookDatabase);
            administrationMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}