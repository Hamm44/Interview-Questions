namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Tom Sawyer", "Mark Twein", 1955);
            book.DisplayDetail();
            Book book1 = new Book("Valeri", "Valerika", 2005);
            book1.DisplayDetail();
        }

    }

    class Book : Library
    {
        public string title;
        public string author;
        public int year;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900)
                {
                    throw new Exception("Error");
                }
                year = value;
            }
        }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public string GetInfo()
        {

            return $"{Title} {Author} {Year} {ID}";
        }

        public override void DisplayDetail()
        {
            Console.WriteLine($"{GetInfo()}");
        }
    }

    public abstract class Library
    {
        public static int _counter = 0;
        public int ID { get; }

        public Library()
        {

            ID = ++_counter;
        }
        public abstract void DisplayDetail();

    }
}
