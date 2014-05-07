using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMeaningOfLife
{
    class SearchedFile
    {
        public String FileName;
        public int amountFound;

        public String toString()
        {
            return FileName + ": " + amountFound;
        }
    }
}
