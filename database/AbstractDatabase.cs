using ChallengeOneLibraryDAS01.database.Models;
using ChallengeOneLibraryDAS01.database.NewFolder;

namespace ChallengeOneLibraryDAS01.database
{

    public class AbstractRepository<T> : IDatabase<T> where T : DatabaseElement
    {

        private IList<T> _databaseMemory = new List<T>();

        public IList<T> GetAll()
        {
            return _databaseMemory;
        }

        public T GetById(int id)
        {
            return this._databaseMemory.FirstOrDefault(element => element.Id == id) ?? throw new EntityNotFoundException("El elemento con ID: " + id + ", no existe.");
        }

        public T Insert(T entity)
        {
            this._databaseMemory.Add(entity);
            return entity;
        }

        public T RemoveById(int id)
        {
            T elementToDelete = this._databaseMemory.FirstOrDefault(element => element.Id == id) ?? throw new EntityNotFoundException("El elemento con ID: " + id + ", no existe.");

            this._databaseMemory.Remove(elementToDelete);
            return elementToDelete;
        }

        public T UpdateById(T entity, int id)
        {
            T target = this._databaseMemory.FirstOrDefault(element => element.Id == id) ?? throw new EntityNotFoundException("El elemento con ID: " + id + ", no existe.");

            int index = this._databaseMemory.IndexOf(target);

            this._databaseMemory[index] = entity;

            return entity;
        }
    }
}
