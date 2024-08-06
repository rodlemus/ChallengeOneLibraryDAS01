using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook
{
    public partial class AddNewBookForm : Form
    {
        public AddNewBookForm()
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
            foreach (var item in panel1.Controls.OfType<Label>())
            {
                item.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bookUrlTxtBox_TextChanged(object sender, EventArgs e)
        {
            bookPortraitPictureBx.ImageLocation = bookUrlTxtBox.Text;
        }
    }
}
