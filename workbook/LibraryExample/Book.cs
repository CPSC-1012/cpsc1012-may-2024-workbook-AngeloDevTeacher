using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Book
    {
        private string _author;
        private string _title;
        private Page[] _pages;
        private bool _isHardCover;
        private int _isbn;

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
            if (numberOfPages < 0)
            {
                for (int i = 0; i < numberOfPages; i++)
                {
                    Page thisPage = new Page();

                    thisPage.Write(Console.ReadLine());

                    _pages[i] = thisPage;

                }
            }
        }

        /// <summary>
        /// Returns a string containing all of the string content of the pages.
        /// </summary>
        /// <returns>The books word content as a string.</returns>
        public string Read()
        {
            string Output = "";
            for (int i = 0; i < _pages.Length; i++)
            {
                Output += _pages[i].GetPageWordContent() + "\n\n";
            }
            return Output;
        }


    }
}
