namespace ChallengeOneLibraryDAS01
{
    public partial class RootMenuForm : Form
    {
        public RootMenuForm()
        {
            InitializeComponent();
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