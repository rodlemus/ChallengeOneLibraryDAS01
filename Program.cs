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
            var user = new User();

            book.Id = 1000;
            book.Title = "el principito";
            book.Author = "jose jose";
            book.Stock = 20;
            book.PublicationDate = DateTime.Now;
            book.PortraitUrl = "www.josejose.img";
            book.Editorial = "bacacho";

            user.Id = 1001;
            user.Name = "rodrigo lemus";

            userdb.Insert(user);
            bookdb.Insert(book);
            Application.Run(new RootMenuForm(bookdb, userdb, new BiblioRepository<BookLoan>()));
        }
    }
}