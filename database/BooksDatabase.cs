using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.database.NewFolder;

namespace ChallengeOneLibraryDAS01.database
{
    internal class BooksDatabase : IDatabase<Book>
    {

        private IList<Book> _databaseMemory = new List<Book>();

        public IList<Book> GetAll()
        {
            return _databaseMemory;
        }

        public Book GetById(int id)
        {
            return this._databaseMemory.FirstOrDefault(book => book.Id == id) ?? throw new EntityNotFoundException("El libro con ID: " + id + ", no existe.");
        }

        public Book Insert(Book entity)
        {
            this._databaseMemory.Add(entity);
            return entity;
        }

        public Book RemoveById(int id)
        {
            Book bookToDelete = this._databaseMemory.FirstOrDefault(book => book.Id == id) ?? throw new EntityNotFoundException("El libro con ID: " + id + ", no existe.");

            this._databaseMemory.Remove(bookToDelete);
            return bookToDelete;
        }

        public Book UpdateById(Book entity, int id)
        {
            Book target = this._databaseMemory.FirstOrDefault(book => book.Id == id) ?? throw new EntityNotFoundException("El libro con ID: " + id + ", no existe.");

            int index = this._databaseMemory.IndexOf(target);

            this._databaseMemory[index] = entity;

            return entity;
        }
    }
}
