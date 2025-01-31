using System.Runtime.Intrinsics.X86;
using static assingment03adv.program;

namespace assingment03adv
{
    class program
    {
        #region Q1
        // Part 01:
        // 01 Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

        public class Book
        {

            private string isbn;
            private string title;
            private string author;
            private DateTime publicationDate;
            private double price;


            public Book(string isbn, string title, string author, DateTime publicationDate, double price)
            {
                this.isbn = isbn;
                this.title = title;
                this.author = author;
                this.publicationDate = publicationDate;
                this.price = price;
            }


            public string ISBN
            {
                get { return isbn; }
                set { isbn = value; }
            }

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

            public DateTime PublicationDate
            {
                get { return publicationDate; }
                set { publicationDate = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }


            public override string ToString()
            {
                return $"ISBN: {isbn}, Title: {title}, Author: {author}, Publication Date: {publicationDate.ToShortDateString()}, Price: ${price}";
            }

        }





        #endregion

        #region Q2
        // 1 You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 
        //Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
        //Use the Proper build in delegate. 
        //Anonymous Method (GetISBN).
        //Lambda Expression (GetPublicationDate)..



        public class BookFunctions
        {
            // This is the method we'll be using as reference
            public static string GetISBN(Book book)
            {
                return book.ISBN;
            }

            public static string GetPublicationDate(Book book)
            {
                return book.PublicationDate.ToString();
            }
        }

        List<Book> bookList = new List<Book>();
        // a) Create User Defined Delegate with the same signature of methods 

        public delegate string BookOperation(Book book);

        public static void ProcessBooks(List<Book> books, BookOperation operation)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(operation(book));
            }
        }


        // b) Use the Proper build in delegate.
        public static void ProcessBooks(List<Book> books, Func<Book, string> operation)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(operation(book));
            }
        }

        // c)  Anonymous Method(GetISBN).
        BookFunctions.ProcessBooks(bookList, delegate (Book book) { return BookFunctions.GetISBN(book); });

   // d ) Lambda Expression(GetPublicationDate).

BookFunctions.ProcessBooks(bookList, b => BookFunctions.GetPublicationDate(b));

	#endregion










}







}