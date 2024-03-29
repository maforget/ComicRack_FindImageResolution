﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolutionNET.ComicRack
{
    internal class BookCollection
    {
        private List<Book> collection;

        public int Length => collection.Count;

        public BookCollection(object[] books)
        {
            collection = new List<Book>();
            for (int i = 0; i < books.Length; i++)
            {
                var book = new Book(books[i]);
                if (book != null && !string.IsNullOrEmpty(book.FilePath))
                    collection.Add(book);
            }
        }

        public Book this [int i]
        {
            get { return collection[i]; }
        }
    }


}
