namespace ChallengeOneLibraryDAS01.database.Models
{
    public class DatabaseElement
    {
        public int Id { get; set; }

        public DatabaseElement()
        {
            Id = Random.Shared.Next(1000, 100001);
        }
    }
}
