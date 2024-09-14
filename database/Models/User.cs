namespace ChallengeOneLibraryDAS01.database.Models
{
    public class User : DatabaseElement
    {
        public User() : base()
        {
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error: Name es requerido.");
                }
                _name = value;
            }
        }

    }
}
