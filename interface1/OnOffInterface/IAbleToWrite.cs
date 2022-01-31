using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface
{
    public interface IAbleToWrite : IWrite
    {
        public ConsoleColor ColourW { get; set; }
        void Write(string text);

    }
}
