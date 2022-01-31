using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface
{
    public interface IWrite
    {
        void Write(string text); // you have to keep the properties as it creates reference then
    }
}
