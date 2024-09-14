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

        private GraphsQuerieService _graphQueryService;

        public ReportsChartForm(IDatabase<Book> bookDatabase, IDatabase<BookLoan> bookLoanDatabase, IDatabase<User> studentDatabase)
        {
            InitializeComponent();

            _bookDatabase = bookDatabase;
            _bookLoanDatabase = bookLoanDatabase;
            _studentDatabase = studentDatabase;
            this.BackColor = AppPaletteColors.GetPrincipalBackgroundColor();
            this.panel1.BackColor = AppPaletteColors.GetSecondaryAccentBackgroundColor();
            this._graphQueryService = new GraphsQuerieService(bookDatabase, bookLoanDatabase, studentDatabase);
            this.generateBooksPerAuthorGraph();
        }

        //Este metood construye la grafica, setea el titulo limpia las series agredas por default por el autor
        private void generateBooksPerAuthorGraph()
        {
            string booksPerAuthorSeries = "Autores";

            var booksPerAuthor = this._graphQueryService.GetBooksPerAuthor();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Número de libros por Autor");
            this.chart1.Series.Add(booksPerAuthorSeries);

            int count = 0;

            foreach (var book in booksPerAuthor)
            {
                //DataPoint representa a cada barra de la grafica, le asignamos los valor como el indice y el Valor de Y
                var charDataPoint = new DataPoint();
                charDataPoint.SetValueXY(count + 1, book.BooksStockNumber);
                charDataPoint.AxisLabel = book.Author;

                //luego agregamos ese punto a la serie correspondiente
                this.chart1.Series[booksPerAuthorSeries].Points.Add(charDataPoint);
                count += 1;
            }
        }

        //Encapsulamos la logica para genera la data que alimentara las charts
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

            public IList<BookPerAuthor> GetBooksPerAuthor()
            {

                //agrupamos los libros por author, luego mapeamos los valores y hacemos la suma del stock de cada sub coleccion
                return this._bookDatabase.GetAll().GroupBy(book => book.Author).Select(authors =>
                {
                    var bookPerAuthor = new BookPerAuthor();
                    bookPerAuthor.Author = authors.Key;
                    bookPerAuthor.BooksStockNumber = authors.Sum(book => book.Stock);

                    return bookPerAuthor;
                }).ToList();
            }
        }

        public class BookPerAuthor
        {
            public string Author { get; set; }
            public int BooksStockNumber { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
