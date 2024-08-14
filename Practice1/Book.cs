namespace Practice1
{
    public class Book
    {
        string title;
        string author;
        string isbn;

        public Book() { }
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string getIsbn() { return isbn; }
        public string getTitle() { return title; }
        public string getAuthor() { return author; }
        public void bookDetails()
        {
            Console.WriteLine("Book Title: {0} Author: {1} ISBN: {2}", this.title, this.author, this.isbn);
        }

        public override bool Equals(object? obj)
        {
            var bookN = obj as Book;
            return this.isbn.Equals(bookN.getIsbn());
        }

        public override string? ToString()
        {
            return "Book Title: " + this.title + " Author: "+ this.author + "ISBN: " + this.isbn;
        }
    }
 }
