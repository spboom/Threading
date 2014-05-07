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
        public int AmountFound;


        public SearchedFile()
        { }

        public SearchedFile(String fileName, int amountFound)
        {
            FileName = fileName;
            AmountFound = amountFound;
        }

        public override string ToString()
        {
            return FileName + ": " + AmountFound;
        }
    }
}
