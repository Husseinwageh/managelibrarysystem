namespace managelibrarysystem
{
    class Book
    {
        /*
        book attributes
            */
        public string title;
        public string author;
        public int isbn;
        public bool available;
        /*
          book constructor
        */
        public Book(string title, string author, int isbn)
        {

            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.available = true;
        }
        /*
        book methods
        */
        //title methods
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        //author methods
        public string GetAuthor()
        {
            return this.author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        //ISBN methods
        public int Getisbn()
        {
            return this.isbn;
        }
        public void Setlsbn(int isbn)
        {
            this.isbn = isbn;
        }
        public bool IsAvailbal()
        {
            return true;
        }
        public bool NotAvailabl()
        {
            return false;
        }
    }
    class library
    {
        public List<Book> books;
        public library()
        {
            this.books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void BorrowBook(string title)
        {
            for (inti = 0; i < books.Count; i++)
            {
                if (books[i].title == title && books[i].availabl == true)
                {
                    books[i].available = books[i].Notavailable();
                    Console.WriteLine("the book is borrowing successfully");
                    Console.WriteLine(books[i].available);
                }
            }
        }

    }
    internal class program
    {
        static void Main(string[] args)
        {
            library library = new library();
            //Adding books to the library library.Add Book(new Book("The Great Gatsby",97543213));
            //print books
            for (inti = 0;< library.books.Count; i++)
            {
                Console.WriteLine(library.books[i].title);
                //searching and borrowing book library.BorrowBook(console.Readline());
                //Returning books library.ReturnBook(console.Readline());
            }
        }
    }