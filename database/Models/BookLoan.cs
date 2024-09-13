namespace ChallengeOneLibraryDAS01.database.Models
{
    public class BookLoan
    {
        public int Id { get; }
        public DateTime InitDateBookLoan { get; }
        public DateTime FinalDateBookLoan { get; set; }

        public bool IsPendingLoan { get; set; }

        public Book BookInLoan { get; set; }

        public BookLoan()
        {
            // inicializamos la propiedades bascias cuando creemos una nueva instancia de Prestamo de libro
            Id = Random.Shared.Next(1000, 100001);
            InitDateBookLoan = DateTime.Now;
            IsPendingLoan = true;
        }
    }
}
