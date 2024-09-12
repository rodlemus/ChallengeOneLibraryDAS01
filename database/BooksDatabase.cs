using ChallengeOneLibraryDAS01.Models;

namespace ChallengeOneLibraryDAS01.database
{
    internal class BooksDatabase : IDatabase<Book>
    {
        IList<Book> IDatabase<Book>.GetAll()
        {
            throw new NotImplementedException();
        }

        Book IDatabase<Book>.getById(int id)
        {
            throw new NotImplementedException();
        }

        Book IDatabase<Book>.removeById(int id)
        {
            throw new NotImplementedException();
        }

        Book IDatabase<Book>.updateById(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
