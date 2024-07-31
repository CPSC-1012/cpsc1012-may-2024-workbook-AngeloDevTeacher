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

        public string GetPageWordContent()
        {
            return _pageWordContent;
        }

        public void Write(string content)
        {
            _pageWordContent = content;
        }
    }
}
