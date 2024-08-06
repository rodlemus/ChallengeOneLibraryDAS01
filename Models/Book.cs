namespace ChallengeOneLibraryDAS01.Models
{
    internal class Book
    {
        private int id;
        private string title;
        private string author;
        private string portraitUrl;
        private string editorial;
        private DateTime datePublished;
        private short availableItems;


        public Book(int id, string title, string author, string portraitUrl, string editorial, DateTime datePublished, short availableItems)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.portraitUrl = portraitUrl;
            this.editorial = editorial;
            this.datePublished = datePublished;
            this.availableItems = availableItems;
        }
    }
}
