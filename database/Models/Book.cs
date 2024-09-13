namespace ChallengeOneLibraryDAS01.database.Models
{
    public class Book : DatabaseElement
    {
        public Book() : base()
        {
        }

        private string _title;
        public string Title
        {
            get { return _title; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error: Título del libro es requerido.");
                }
                _title = value;
            }
        }

        private string _author;
        public string Author
        {
            get { return _author; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error:El autor del libro es requerido.");
                }
                _author = value;
            }
        }

        private string _portraitUrl;
        public string PortraitUrl
        {
            get { return _portraitUrl; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error: La Url de la Portada del libro es requerida.");
                }
                _portraitUrl = value;
            }
        }

        private string _editorial;
        public string Editorial
        {
            get { return _editorial; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("error: El nombre de la Editorial es requerida.");
                }
                _editorial = value;
            }
        }

        private short _stock;
        public short Stock
        {
            get { return _stock; }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("error: El stock tiene que ser mayor a Cero.");
                }
                _stock = value;
            }
        }

        private DateTime _publicationDate;
        public DateTime PublicationDate
        {
            get { return _publicationDate; }

            set
            {
                _publicationDate = value;
            }
        }

    }
}
