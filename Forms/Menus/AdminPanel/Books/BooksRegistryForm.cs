using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook;
using ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.UpdateBook;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books
{
    public partial class BooksRegistryForm : Form
    {
        private IDatabase<Book> _booksDatabase;
        private Form _prevForm;

        // guardamos lo resultados de la busqueda, nos serviran para buscar por el index el libro clickeado
        private IList<Book> _booksInMemory = new List<Book>();
        private Book? _selectedBookFromListBox;
        public BooksRegistryForm(IDatabase<Book> database, Form prevForm)
        {
            InitializeComponent();
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.button2.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this._booksDatabase = database;

            //Formulario anterior
            this._prevForm = prevForm;
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
                this.searchResultsListBox.Visible = false;
                this.searchResultsListBox.Items.Clear();
            }
            else
            {
                foreach (var radioButtonControl in groupBox3.Controls)
                {
                    if (radioButtonControl is RadioButton r && r.Checked)
                    {
                        //Limpiamos resultados anteriores
                        searchResultsListBox.Items.Clear();

                        if (r.Text == "Título")
                        {
                            this.searchByTitle();
                        }

                        if (r.Text == "ID")
                        {
                            this.searchById();
                        }
                    }
                }
            }
        }


        private void searchByTitle()
        {


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

        private void searchById()
        {

            try
            {

                //Buscamos en base a que el texto ingresado coincida con el inicio del titulo
                var bookSearch = _booksDatabase.GetById(Int32.Parse(this.searchTxtBox.Text));

                var auxList = new List<Book>();
                auxList.Add(bookSearch);

                this._booksInMemory = auxList;



                IList<string> titles = this._booksInMemory.Select(book => $"ID: {book.Id} - {book.Title}").ToList();

                foreach (string title in titles)
                {
                    searchResultsListBox.Items.Add(title);
                }

                searchResultsListBox.Visible = true;
                searchTxtBox.Focus();
            }
            catch (Exception ex)
            {
                searchResultsListBox.Visible = false;
                MessageBox.Show(ex.Message);
            }
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

        // despliega el listbox si vuelve el focus y si el listbox tiene items
        private void handleEnterSearchFocus(object sender, EventArgs e)
        {
            if (this.searchResultsListBox.Items.Count > 0)
            {
                this.searchResultsListBox.Visible = true;
            }
        }

        //Cuando clickea un item del listbox lo buscamos por index en la varible de los booksInMemory
        //lo obetemos por indice y le asignamos las propiedades a los label
        private void handleSelectedBook(object sender, EventArgs e)
        {
            if (this.searchResultsListBox.SelectedIndex >= 0)
            {
                this.searchResultsListBox.Visible = false;
                this._selectedBookFromListBox = this._booksInMemory[searchResultsListBox.SelectedIndex];
                label3.Text = this._selectedBookFromListBox.Title;
                label4.Text = this._selectedBookFromListBox.Author;
                label5.Text = this._selectedBookFromListBox.Editorial;
                label6.Text = this._selectedBookFromListBox.PublicationDate.ToShortDateString();
                label7.Text = this._selectedBookFromListBox.Stock.ToString();
                pictureBox1.ImageLocation = this._selectedBookFromListBox.PortraitUrl;
                label8.Text = $"ID: {this._selectedBookFromListBox.Id}";

                //Elementos para editar y elimar libro
                panel1.Visible = true;
                button9.Visible = true;
                button3.Visible = true;
            }
        }

        // Encapsulamos la logica para reutilizarla en las diferentes propiedadas ya que lo unico que varía es la propiedad del libro a actualizar
        private void updateBookProperty(string propertyToUpdate)
        {
            using (UpdateBookPropertiesDialog updateBookProperty = new UpdateBookPropertiesDialog(this._booksDatabase, propertyToUpdate, ref this._selectedBookFromListBox))
            {
                updateBookProperty.ShowDialog();
                if (updateBookProperty.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Libro actualizado con éxito!.");

                    //despues actualizar sastifacotiramente el campo prodecemos a actualizar los labels y los items del form padre

                    label3.Text = this._selectedBookFromListBox.Title;
                    label4.Text = this._selectedBookFromListBox.Author;
                    label5.Text = this._selectedBookFromListBox.Editorial;
                    label6.Text = this._selectedBookFromListBox.PublicationDate.ToShortDateString();
                    label7.Text = this._selectedBookFromListBox.Stock.ToString();
                    pictureBox1.ImageLocation = this._selectedBookFromListBox.PortraitUrl;

                    this.searchResultsListBox.Items.Clear();
                }
            }
        }
        private void handleUpdateTitleEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("title");
        }

        private void handleUpdateAuthorEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("author");
        }

        private void handleUpdateEditorialEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("editorial");
        }

        private void handleUpdatePublicationDateEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("date");
        }

        private void handleUpdateStockEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("stock");
        }

        private void handleUpdatePortraitUrlEvent(object sender, EventArgs e)
        {
            this.updateBookProperty("url");
        }

        private void handleDeleteBookEvent(object sender, EventArgs e)
        {
            try
            {
                //validamos que haya un libro seleccionado
                if (this._selectedBookFromListBox != null)
                {
                    using (ConfirmDialog confirmDialog = new ConfirmDialog())
                    {
                        confirmDialog.ShowDialog();
                        //Le pedimos una confirmacion al usuario para descartar que haya presionado eliminar por error
                        if (confirmDialog.DialogResult == DialogResult.OK)
                        {
                            this._booksDatabase.RemoveById(this._selectedBookFromListBox.Id);
                            this.searchResultsListBox.Items.Clear();
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            pictureBox1.ImageLocation = "";

                            this._selectedBookFromListBox = null;

                            panel1.Visible = false;
                            button9.Visible = false;
                            button3.Visible = false;

                            MessageBox.Show("Libro borrado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Proceso cancelado.");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, intentelo más tarde.");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._prevForm.ShowDialog();

        }
    }
}
