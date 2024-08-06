using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books
{
    public partial class BooksRegistryForm : Form
    {
        public BooksRegistryForm()
        {
            InitializeComponent();
            SetAppStyle.SetDefaultWindowsStyle(this, panel1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.searchTxtBox.Text);
            searchResultsListBox.Visible = true;
            searchResultsListBox.Items.Add(this.searchTxtBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddNewBookForm addNewBookForm = new AddNewBookForm())
            {
                addNewBookForm.ShowDialog();
                if (addNewBookForm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Libro creado");
                }
            }
        }
    }
}
