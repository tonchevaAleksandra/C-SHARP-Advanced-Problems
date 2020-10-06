using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
   public class Library:IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort(new BookComparator());
        }
        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return  new LibraryIterator(this.books);
            //foreach (var book in this.books)
            //{
            //    yield return book;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;
            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }
            public Book Current 
            {
                get
                {
                    return this.books[this.index];
                }
            }
            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                return ++this.index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}
