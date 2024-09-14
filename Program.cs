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

            book.Id = 1000;
            book.Title = "el principito";
            book.Author = "nelson  hdz";
            book.Stock = 3;
            book.PublicationDate = new DateTime(2017, 9, 15);
            book.PortraitUrl = "www.josejose.img";
            book.Editorial = "bacacho";


            book4.Id = 1004;
            book4.Title = "cuentos del ayeryhoy";
            book4.Author = "nelson  hdz";
            book4.Stock = 9;
            book4.PublicationDate = new DateTime(2015, 9, 15);
            book4.PortraitUrl = "www.nelsonhdz";
            book4.Editorial = "bacacho";

            book2.Id = 1002;
            book2.Title = "el principe de la cancion";
            book2.Author = "jose jose";
            book2.Stock = 6;
            book2.PublicationDate = new DateTime(2015, 9, 15);
            book2.PortraitUrl = "www.josejose.img";
            book2.Editorial = "bacacho";

            book3.Id = 1003;
            book3.Title = "el viaje de chihiro";
            book3.Author = "miyazaki";
            book3.Stock = 10;
            book3.PublicationDate = new DateTime(2016, 9, 15);
            book3.PortraitUrl = "www.josejose.img";
            book3.Editorial = "bacacho";


            user.Id = 1001;
            user.Name = "rodrigo lemus";

            userdb.Insert(user);

            bookdb.Insert(book);
            bookdb.Insert(book2);
            bookdb.Insert(book3);
            bookdb.Insert(book4);
            Application.Run(new AdministrationMenuForm(bookdb, new BiblioRepository<BookLoan>(), userdb));
        }
    }
}