namespace ChallengeOneLibraryDAS01.database.Models
{
    public class Student : DatabaseElement
    {
        private string _carnet;
        public string Carnet
        {
            get => _carnet;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error: Carnet es requerido.");
                }
                _carnet = value;
            }
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

        public Student(string carnet, string name)
        {
            Carnet = carnet;
            Name = name;
        }
    }
}
