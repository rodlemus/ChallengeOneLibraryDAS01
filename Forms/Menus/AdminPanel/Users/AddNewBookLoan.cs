using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users
{
    public partial class AddNewBookLoan : Form
    {

        private IDatabase<Book> _booksDatabase;
        private IDatabase<User> _usersDatabase;
        private IDatabase<BookLoan> _booksLoanDatabase;

        //Si ya hay un usuario cargado en el form se le asigna el id para facilitar la tarea de registrar prestamo
        private string _defaultId;

        //ya que el defaultid es un valor no podemos fiarnos de el debemos revisar el id con el que se genera la transaccacion a ultima instancia
        private User _userProceded;
        public AddNewBookLoan(IDatabase<Book> bookDatabase, IDatabase<User> studentDatabase, IDatabase<BookLoan> booksLoanDatabase, string defaultId)
        {
            InitializeComponent();
            this._booksDatabase = bookDatabase;
            this._usersDatabase = studentDatabase;
            this._booksLoanDatabase = booksLoanDatabase;
            this._defaultId = defaultId;
            this.textBox2.Text = this._defaultId;

            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();
        }

        private void handleLoanRegistrationEvent(object sender, EventArgs e)
        {
            // Verificamos que los 2 IDs ingresados en el formulario existan
            User user = this._usersDatabase.GetById(Int32.Parse(this.textBox2.Text));
            Book book = this._booksDatabase.GetById(Int32.Parse(this.textBox1.Text));
            if (!(book != null))
            {
                MessageBox.Show($"El usuario con ID: {this.textBox1.Text}, no existe.");
                return;
            }
            if (!(user != null))
            {
                MessageBox.Show($"El usuario con ID: {this.textBox1.Text}, no existe.");
                return;
            }

            //si ya no hay stock abortamos el proceso, de lo contrario continuamos
            bool existStock = this.checkIfExistBookStock(book);
            if (!existStock)
            {
                DialogResult = DialogResult.Abort;
                return;
            }


            this._userProceded = user;
            BookLoan newBookLoan = new BookLoan();
            newBookLoan.BookInLoan = book;
            newBookLoan.User = user;
            newBookLoan.FinalDateBookLoan = null;

            this._booksLoanDatabase.Insert(newBookLoan);
            DialogResult = DialogResult.OK;

        }

        //Verificamos que exista stock, de lo contrario no podra realizar el prestamo, y decrecemos el valor cada que se hace un prestamo y lo actualizamos
        // en nuestra base de datos
        private bool checkIfExistBookStock(Book book)
        {
            if (book.Stock <= 0)
            {
                return false;
            }
            book.Stock = book.Stock - 1;
            this._booksDatabase.UpdateById(book, book.Id);
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public User GetUserIdLoanAdded()
        {
            return this._userProceded;
        }
    }
}
