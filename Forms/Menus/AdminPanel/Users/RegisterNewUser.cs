using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users
{
    public partial class RegisterNewUser : Form
    {
        private IDatabase<User> _studentDatabase;
        private User newStudent;
        public RegisterNewUser(IDatabase<User> database)
        {
            InitializeComponent();
            this._studentDatabase = database;
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new User();
            student.Name = this.textBox1.Text;
            this._studentDatabase.Insert(student);
            this.newStudent = student;
            DialogResult = DialogResult.OK;
        }

        public User getNewStudent()
        {
            return this.newStudent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
