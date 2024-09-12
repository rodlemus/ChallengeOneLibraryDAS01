using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books
{
    public partial class BooksRegistryForm : Form
    {
        private IDatabase<Book> _booksDatabase;

        // guardamos lo resultados de la busqueda, nos serviran para buscar por el index el libro clickeado
        private IList<Book> _booksInMemory = new List<Book>();
        public BooksRegistryForm(IDatabase<Book> database)
        {
            InitializeComponent();
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.button2.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this._booksDatabase = database;

            // ponemos como busqueda default la que es por titulo
            this.rdBtnTitle.Checked = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verficamos que haya texto ingresado, sino no podrahacer la busqueda
            bool isTextToSearch = this.searchTxtBox.Text.Length > 0;
            if (!isTextToSearch)
            {
                MessageBox.Show("Tiene que ingresar texto en el campo de busqueda.");
            }
            else
            {
                foreach (var radioButtonControl in groupBox3.Controls)
                {
                    if (radioButtonControl is RadioButton r && r.Checked)
                    {
                        if (r.Text == "Título")
                        {
                            this.searchByTitle();
                        }
                    }
                }
            }
        }


        private void searchByTitle()
        {
            //Limpiamos resultados anteriores
            searchResultsListBox.Items.Clear();

            //Buscamos en base a que el texto ingresado coincida con el inicio del titulo
            this._booksInMemory = _booksDatabase.GetAll().Where((book) => book.Title.StartsWith(this.searchTxtBox.Text)).ToList();

            if (this._booksInMemory.Count == 0)
            {
                MessageBox.Show("No hay resultados para el texto ingresado.");
                searchResultsListBox.Visible = false;
                return;
            }

            IList<string> titles = this._booksInMemory.Select(book => $"ID: {book.Id} - {book.Title}").ToList();

            foreach (string title in titles)
            {
                searchResultsListBox.Items.Add(title);
            }
            searchResultsListBox.Visible = true;
            searchTxtBox.Focus();
        }

        private void searchByID()
        {
            MessageBox.Show("No hay resultados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddNewBookForm addNewBookForm = new AddNewBookForm(this._booksDatabase))
            {
                addNewBookForm.ShowDialog();
                if (addNewBookForm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Libro creado");
                }
            }
        }

        private void handleLeaveSearchFocus(object sender, EventArgs e)
        {

        }

        private void handleEnterSearchFocus(object sender, EventArgs e)
        {
            if (this.searchResultsListBox.Items.Count > 0)
            {
                this.searchResultsListBox.Visible = true;
            }
        }

        //le asignamos el evento al listbox para cuando clickamos un item
        private void handleSelectedBook(object sender, EventArgs e)
        {
            if (this.searchResultsListBox.SelectedIndex >= 0)
            {
                this.searchResultsListBox.Visible = false;
                Book selectedBook = this._booksInMemory[searchResultsListBox.SelectedIndex];
                label3.Text = selectedBook.Title;
                label4.Text = selectedBook.Author;
                label5.Text = selectedBook.Editorial;
                label6.Text = selectedBook.PublicationDate.ToShortDateString();
                label7.Text = selectedBook.Stock.ToString();
                pictureBox1.ImageLocation = selectedBook.PortraitUrl;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
