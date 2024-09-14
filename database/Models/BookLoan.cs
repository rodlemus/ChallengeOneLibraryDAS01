namespace ChallengeOneLibraryDAS01.database.Models
{
    public class BookLoan : DatabaseElement
    {
        public DateTime InitDateBookLoan { get; }
        public DateTime? FinalDateBookLoan { get; set; }

        public bool IsPendingLoan { get; set; }

        public Book BookInLoan { get; set; }

        public User User { get; set; }

        public BookLoan() : base()
        {
            // inicializamos la propiedades bascias cuando creemos una nueva instancia de Prestamo de libro
            InitDateBookLoan = DateTime.Now;
            IsPendingLoan = true;
        }
    }
}
