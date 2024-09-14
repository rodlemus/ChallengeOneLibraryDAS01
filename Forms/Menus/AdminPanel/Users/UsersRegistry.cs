using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;

namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users
{
    public partial class UsersRegistry : Form
    {
        private IDatabase<Book> _bookDatabase;
        private IDatabase<User> _usersDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;

        private User? _currentUser;

        private Form _prevForm;

        //Clase anidada contiene la logica para trabajar el DataGridView
        private BooksLoanDgv _bookLoanDgv;



        public UsersRegistry(IDatabase<Book> booksDatabase, IDatabase<User> database, IDatabase<BookLoan> database2, Form prevForm)
        {
            InitializeComponent();
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this._usersDatabase = database;
            this._bookDatabase = booksDatabase;
            this._bookLoanDatabase = database2;
            this._bookLoanDgv = new BooksLoanDgv(this.dataGridView1, this._bookLoanDatabase, this._bookDatabase);
            this._bookLoanDgv.initCols();

            //manenejamos el evento cuadno clickeamos una celda desde la clase padre
            this.dataGridView1.CellContentClick += this._bookLoanDgv.HandleFinishLoanCellClick;
            this._prevForm = prevForm;
        }


        private void handleUserSearchById(object sender, EventArgs e)
        {
            try
            {
                if (this.searchTxtBox.Text.Length > 0)
                {
                    this._currentUser = this._usersDatabase.GetById(Int32.Parse(this.searchTxtBox.Text));
                    this.label3.Text = this._currentUser.Id.ToString();
                    this.label4.Text = this._currentUser.Name;

                    this._bookLoanDgv.loadLoansByUserId(this._currentUser.Id);
                }
                else
                {
                    MessageBox.Show("Necesita proveer un ID de un estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._prevForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // si hay un usario cargado ponemos el id sino un string vacio
            string defaultId = this._currentUser != null ? this._currentUser.Id.ToString() : "";

            using (AddNewBookLoan addNewBookLoanDialog = new AddNewBookLoan(this._bookDatabase, this._usersDatabase, this._bookLoanDatabase, defaultId))
            {
                addNewBookLoanDialog.ShowDialog();
                if (addNewBookLoanDialog.DialogResult == DialogResult.OK)
                {
                    var userProceded = addNewBookLoanDialog.GetUserIdLoanAdded();
                    this._bookLoanDgv.loadLoansByUserId(userProceded.Id);
                    this.label3.Text = userProceded.Id.ToString();
                    this.label4.Text = userProceded.Name;
                }

                if (addNewBookLoanDialog.DialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("Lo sentimos, no contamos con existencias por el momento, vuelva otro día.");
                }
            }

        }




        //Ya que la logica de un DGV es mas compleja que otra coas en la aplicacion creamos una NestedClass para separar la logica 
        private class BooksLoanDgv
        {
            private DataGridView _loanDgv;
            private IDatabase<BookLoan> _loanDatabase;
            private IDatabase<Book> _booksDatabase;

            //Alamacenamos cada cargamos los prestamos de un usuario para estar listos cuando cancele uno y manipular la lista
            private IList<BookLoan> _booksLoanInMemory;
            public BooksLoanDgv(DataGridView dgv, IDatabase<BookLoan> database, IDatabase<Book> booksDatabase)
            {
                this._loanDgv = dgv;
                this._loanDatabase = database;
                this._booksDatabase = booksDatabase;
            }

            //inicializamos las columnas
            public void initCols()
            {
                this._loanDgv.Columns.Add("loanId", "Préstamo (ID)");
                this._loanDgv.Columns.Add("loanInitDate", "Fecha inicial");
                this._loanDgv.Columns.Add("bookId", "Libro (ID)");
                this._loanDgv.Columns.Add("title", "Título");
                this._loanDgv.Columns.Add("isActive", "Préstamo Estado");
                this._loanDgv.Columns.Add("closeLoan", "Cerrar Préstamo");

                // hacemos que las celdas no se puedan editar, solo seran para lectura
                this._loanDgv.ReadOnly = true;
            }

            //cargamos todo el historial de prestamos del usuario
            public void loadLoansByUserId(int userId)
            {

                this._loanDgv.Rows.Clear();
                this._booksLoanInMemory = this._loanDatabase.GetAll().Where(loan => loan.User.Id == userId).ToList();
                foreach (var loanIterator in this._booksLoanInMemory.Select((value, index) => new { index, value }))
                {
                    var loan = loanIterator.value;
                    var currentIndex = loanIterator.index;

                    string loanState = loan.IsPendingLoan ? "PENDIENTE" : "ENTREGADO";

                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();




                    // en la columna que cancelamos los prestamos si ya esta cancelado, no mostramos un boton para cancelar
                    var cellToCancelOrNotLoan = loan.IsPendingLoan ? buttonCell : null;
                    this._loanDgv.Rows.Add(loan.Id, loan.InitDateBookLoan.ToString(), loan.BookInLoan.Id, loan.BookInLoan.Title, loanState, cellToCancelOrNotLoan);

                    if (loanState == "PENDIENTE")
                    {
                        this._loanDgv.Rows[currentIndex].Cells[5].Value = "Finalizar";
                    }
                }
            }


            public void HandleFinishLoanCellClick(object sender, DataGridViewCellEventArgs e)
            {

                // Validamos que sea un click proveniente de la columna de Cancelar Prestamo
                if (e.ColumnIndex == 5)
                {
                    try
                    {
                        var loanId = Int32.Parse(this._loanDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var bookId = Int32.Parse(this._loanDgv.Rows[e.RowIndex].Cells[2].Value.ToString());

                        var book = this._booksDatabase.GetById(bookId);
                        var loanClicked = this._loanDatabase.GetById(loanId);

                        book.Stock = book.Stock + 1;
                        this._booksDatabase.UpdateById(book, bookId);

                        loanClicked.IsPendingLoan = false;
                        this._loanDatabase.UpdateById(loanClicked, loanId);
                        this.loadLoansByUserId(loanClicked.User.Id);

                        MessageBox.Show("Préstamo finalizado con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //Formulario para registrar estudiante
            using (RegisterNewUser registerUserDialog = new RegisterNewUser(this._usersDatabase))
            {
                try
                {
                    registerUserDialog.ShowDialog();
                    if (registerUserDialog.DialogResult == DialogResult.OK)
                    {
                        this._currentUser = registerUserDialog.getNewStudent();
                        this.label3.Text = this._currentUser.Id.ToString();
                        this.label4.Text = this._currentUser.Name;
                        this._bookLoanDgv.loadLoansByUserId(this._currentUser.Id);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
