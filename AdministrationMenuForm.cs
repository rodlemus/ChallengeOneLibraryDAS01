namespace ChallengeOneLibraryDAS01
{
    public partial class AdministrationMenuForm : Form
    {
        public AdministrationMenuForm()
        {
            InitializeComponent();
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
