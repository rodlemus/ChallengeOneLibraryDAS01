using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.Utils;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChallengeOneLibraryDAS01.Forms.Menus.Reports
{
    public partial class ReportsChartForm : Form
    {
        private IDatabase<Book> _bookDatabase;
        private IDatabase<BookLoan> _bookLoanDatabase;
        private IDatabase<User> _studentDatabase;

        private Form _prevForm;

        private GraphsQuerieService _graphQueryService;

        public ReportsChartForm(IDatabase<Book> bookDatabase, IDatabase<BookLoan> bookLoanDatabase, IDatabase<User> studentDatabase, Form prevForm)
        {
            InitializeComponent();

            _bookDatabase = bookDatabase;
            _bookLoanDatabase = bookLoanDatabase;
            _studentDatabase = studentDatabase;
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();
            this._graphQueryService = new GraphsQuerieService(bookDatabase, bookLoanDatabase, studentDatabase);
            this._prevForm = prevForm;

            this.generateBooksPerAuthorGraph();
            this.generateBooksByYearPublicationGraph();
            this.generateBooksLoansByUser();
        }

        //Este metood construye la grafica, setea el titulo limpia las series agredas por default por el autor
        private void generateBooksPerAuthorGraph()
        {
            string booksPerAuthorSeries = "Autores";

            var booksPerAuthor = this._graphQueryService.GetBooksPerAuthor();

            //este clear siempre se hace porque trae una serie por defecto la grafica
            this.chart1.Series.Clear();

            //título de la grafica
            this.chart1.Titles.Add("Número de libros por Autor");

            // nombre de la serie
            this.chart1.Series.Add(booksPerAuthorSeries);

            //Usamos la funcion select para acceder al index en la lista y no tener que declara una variable solo para contarla
            foreach (var item in booksPerAuthor.Select((value, index) => new { value, index }))
            {
                var book = item.value;
                var index = item.index;

                //DataPoint representa a cada barra de la grafica, le asignamos los valores como el indice y el Valor de Y
                var charDataPoint = new DataPoint();

                charDataPoint.SetValueXY(index, book.BooksStockNumber);

                //este es el texto que aparece debajo de cada barra
                charDataPoint.AxisLabel = book.Requirement;

                //luego agregamos ese punto a la serie correspondiente
                this.chart1.Series[booksPerAuthorSeries].Points.Add(charDataPoint);
            }
        }

        private void generateBooksByYearPublicationGraph()
        {
            string booksPerAuthorSeries = "Año de Publicación";

            var booksPerYear = this._graphQueryService.GetBooksPerYearPublication();

            this.chart2.Series.Clear();
            this.chart2.Titles.Add("Número de libros por Año de Publicación");
            this.chart2.Series.Add(booksPerAuthorSeries);


            foreach (var item in booksPerYear.Select((value, index) => new { value, index }))
            {
                var book = item.value;
                var index = item.index;

                //DataPoint representa a cada barra de la grafica, le asignamos los valor como el indice y el Valor de Y
                var charDataPoint = new DataPoint();
                charDataPoint.SetValueXY(index, book.BooksStockNumber);
                charDataPoint.AxisLabel = book.Requirement;

                //luego agregamos ese punto a la serie correspondiente
                this.chart2.Series[booksPerAuthorSeries].Points.Add(charDataPoint);
            }
        }

        private void generateBooksLoansByUser()
        {
            //Nombre clave de la serie
            string booksPerAuthorSeries = "Préstamos por usuario";

            var booksPerYear = this._graphQueryService.GetNumberOfLoanPerUser();

            this.chart3.Series.Clear();

            //titulo del chart
            this.chart3.Titles.Add("Número de préstamos por usuario");
            this.chart3.Series.Add(booksPerAuthorSeries);

            //Para una mejor descripccion le agregamos un titulo a la Axis X ya que solo los ids de los usuario no se puede llegar a comprender
            this.chart3.ChartAreas[0].AxisX.Title = "Usuarios ID's";

            foreach (var item in booksPerYear.Select((value, index) => new { value, index }))
            {
                var book = item.value;
                var index = item.index;

                //DataPoint representa a cada barra de la grafica, le asignamos los valor como el indice y el Valor de Y
                var charDataPoint = new DataPoint();

                charDataPoint.SetValueXY(index, book.BooksStockNumber);
                charDataPoint.AxisLabel = book.Requirement;

                //luego agregamos ese punto a la serie correspondiente
                this.chart3.Series[booksPerAuthorSeries].Points.Add(charDataPoint);
            }
        }

        //Encapsulamos la logica para generar la información que alimentara las charts
        private class GraphsQuerieService
        {

            private IDatabase<Book> _bookDatabase;
            private IDatabase<BookLoan> _bookLoanDatabase;
            private IDatabase<User> _studentDatabase;

            public GraphsQuerieService(IDatabase<Book> bookDatabase, IDatabase<BookLoan> bookLoanDatabase, IDatabase<User> studentDatabase)
            {
                _bookDatabase = bookDatabase;
                _bookLoanDatabase = bookLoanDatabase;
                _studentDatabase = studentDatabase;
            }

            public IList<BookPerRequirement> GetBooksPerAuthor()
            {

                //agrupamos los libros por author, luego mapeamos los valores y hacemos la suma del stock de cada sub coleccion
                return this._bookDatabase.GetAll().GroupBy(book => book.Author).Select(authors =>
                {
                    var bookPerAuthor = new BookPerRequirement();

                    //le asgignamos el nombre del autor
                    bookPerAuthor.Requirement = authors.Key;

                    // le asignamos la suma de los libro por author
                    bookPerAuthor.BooksStockNumber = authors.Sum(book => book.Stock);

                    return bookPerAuthor;
                }).ToList();
            }

            public IList<BookPerRequirement> GetBooksPerYearPublication()
            {

                //agrupamos los libros por Año de publicación, luego mapeamos los valores y hacemos la suma del stock de cada sub coleccion
                return this._bookDatabase.GetAll().GroupBy(book => book.PublicationDate.Year).Select(authors =>
                {
                    var bookPerAuthor = new BookPerRequirement();

                    //Le asignamos el año de publicacion
                    bookPerAuthor.Requirement = authors.Key.ToString();
                    // le asiganmos la suma de los libro de ese año
                    bookPerAuthor.BooksStockNumber = authors.Sum(book => book.Stock);

                    return bookPerAuthor;
                }).ToList();
            }

            public IList<BookPerRequirement> GetNumberOfLoanPerUser()
            {

                //agrupamos los prestamos por id de usuario, y agreagamos la cuenta de los prestamos agrupados
                return this._bookLoanDatabase.GetAll().GroupBy(loan => loan.User.Id).Select(authors =>
                {
                    var bookPerAuthor = new BookPerRequirement();
                    //le asignamos el ID del usario
                    bookPerAuthor.Requirement = authors.Key.ToString();
                    //le asignamos la cuenta de los prestamos
                    bookPerAuthor.BooksStockNumber = authors.Count();

                    return bookPerAuthor;
                }).ToList();
            }
        }

        //clase para ayudar a represantar la data de la grafica de numero de libros por el requerimiento que nos indiquen
        //El requirement puede ser el id de un usuario, el nombre de un libro, etc
        //ya que para graficar solo necesitamos esta estructura
        // {string: que sera el texto abajo de la barra, int: un entero que sera el valor de Y de la barra}
        // por eso se crea la clase BookPerRequirement, asi retornamos esos elementos en una lista y con eso alimentamos las graficas
        private class BookPerRequirement
        {
            public string Requirement { get; set; }
            public int BooksStockNumber { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._prevForm.Show();
            this.Hide();
        }
    }
}
