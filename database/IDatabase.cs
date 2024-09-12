namespace ChallengeOneLibraryDAS01.database
{
    internal interface IDatabase<T>
    {
        public T getById(int id);
        public T removeById(int id);
        public T updateById(T entity);
        public IList<T> GetAll();
        public T insert(T entity);
    }
}