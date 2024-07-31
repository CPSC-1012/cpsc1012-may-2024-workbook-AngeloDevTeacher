using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Page
    {
        private int _pageNumber;
        private string _pageWordContent;
        // Pretend I can put an image here.

        public string Read()
        {
            return _pageWordContent;
        }

        public void Write(string content, int pageNumber)
        {
            _pageWordContent = content;
            _pageNumber = pageNumber;
        }
    }
}
