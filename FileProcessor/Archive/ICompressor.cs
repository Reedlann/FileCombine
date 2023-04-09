using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archive
{
    internal interface ICompressor
    {
        public string Compress(string target, string destination);
        public void Decompress();
    }
}
