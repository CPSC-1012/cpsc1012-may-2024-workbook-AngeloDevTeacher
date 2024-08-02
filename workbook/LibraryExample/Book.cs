using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Book
    {
        internal string _author;
        internal string _title;
        internal Page[] _pages;
        internal bool _isHardCover;
        internal int _isbn;

        // Getters
        /// <summary>
        /// Gets the author.
        /// </summary>
        /// <returns>The author as a string.</returns>
        public string GetAuthor()
        {
            return _author;
        }
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <returns>The title as a string.</returns>
        public string GetTitle()
        {
            return _title;
        }
        /// <summary>
        /// Returns <see langword="true"/> if the book is a hardcover.
        /// </summary>
        /// <returns>A bool describing hardcover.</returns>
        public bool GetIsHardCover()
        {
            return _isHardCover;
        }
        /// <summary>
        /// Gets the ISBN number - <see href="https://library-archives.canada.ca/eng/services/publishers/isbn/Pages/isbn.aspx/">ISBN page</see>
        /// </summary>
        /// <returns>The ISBN as an int.</returns>
        public int GetISBN()
        {
            return _isbn;
        }

        // Specific methods for the book class.

        public void WritePages(int numberOfPages)
        {
            if (numberOfPages > 0)
            {
                _pages = new Page[numberOfPages];
                for (int currentPageNumber = 0; currentPageNumber < numberOfPages; currentPageNumber++)
                {
                    Page thisPage = new Page();

                    thisPage.Write(Console.ReadLine(), currentPageNumber+1);

                    _pages[currentPageNumber] = thisPage;

                }
            }
        }

        /// <summary>
        /// Returns a string containing all of the string content of the pages.
        /// </summary>
        /// <returns>The books word content as a string.</returns>
        public string Read()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string Output = "";
            for (int i = 0; i < _pages.Length; i++)
            {
                Output += _pages[i].Read() + "\n";
            }
            return Output;
        }


    }
}
