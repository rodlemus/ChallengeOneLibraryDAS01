using ChallengeOneLibraryDAS01.database;
using ChallengeOneLibraryDAS01.database.Models;

namespace ChallengeOneLibraryDAS01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var userdb = new BiblioRepository<User>();
            var bookdb = new BiblioRepository<Book>();

            var book = new Book();
            var book2 = new Book();
            var book3 = new Book();
            var book4 = new Book();
            var user = new User();
            var user2 = new User();

            book.Id = 1000;
            book.Title = "el principito";
            book.Author = "Antoine de Saint-Exupéry";
            book.Stock = 3;
            book.PublicationDate = new DateTime(1954, 9, 15);
            book.PortraitUrl = "https://m.media-amazon.com/images/I/71AVK5VIAzL._AC_UF1000,1000_QL80_.jpg";
            book.Editorial = "Roble";

            book4.Id = 1004;
            book4.Title = "el señor de los anillos";
            book4.Author = "J. R. R. Tolkien";
            book4.Stock = 9;
            book4.PublicationDate = new DateTime(1954, 9, 15);
            book4.PortraitUrl = "https://m.media-amazon.com/images/I/71oVTrHAylL._AC_UF894,1000_QL80_.jpg";
            book4.Editorial = "Roble";

            book2.Id = 1002;
            book2.Title = "el extranjero";
            book2.Author = "Albert Camus";
            book2.Stock = 6;
            book2.PublicationDate = new DateTime(1942, 9, 15);
            book2.PortraitUrl = "https://images.cdn2.buscalibre.com/fit-in/360x360/0d/30/0d30665fd8b3d4e5860cd17a4d9fddcd.jpg";
            book2.Editorial = "Roble";

            book3.Id = 1003;
            book3.Title = "el señor de los anillos - El retorno del rey";
            book3.Author = "J. R. R. Tolkien";
            book3.Stock = 10;
            book3.PublicationDate = new DateTime(1956, 9, 15);
            book3.PortraitUrl = "www.urlincorrecta.prueba.com";
            book3.Editorial = "Roble";


            user.Id = 1001;
            user.Name = "Rodrigo Lemus";

            user2.Id = 1010;
            user2.Name = "Nelson Hernández";

            userdb.Insert(user);
            userdb.Insert(user2);

            bookdb.Insert(book);
            bookdb.Insert(book2);
            bookdb.Insert(book3);
            bookdb.Insert(book4);
            Application.Run(new AdministrationMenuForm(bookdb, new BiblioRepository<BookLoan>(), userdb));
        }
    }
}