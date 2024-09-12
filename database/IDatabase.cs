namespace ChallengeOneLibraryDAS01.database
{
    // Interfaz base para las clases que van controlar el manejo de las base de datos, para usarios, libros, prestamos
    // Cuenta con las consultas basicas de un repositorio
    public interface IDatabase<T>
    {
        public T GetById(int id);
        public T RemoveById(int id);
        public T UpdateById(T entity, int id);
        public IList<T> GetAll();
        public T Insert(T entity);
    }
}