using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface
{
    public interface IWriteCapitals: IAbleToWrite
    {
        // when you realize interface in the other interface you do not have to implement it's
        void WriteInUpperCase(string text);
    }
}
