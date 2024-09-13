namespace ChallengeOneLibraryDAS01.Forms
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
