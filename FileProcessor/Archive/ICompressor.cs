using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archive
{
    internal interface ICompressor
    {
        public void Compress(string target, string destination);
        public void Decompress(string zipPath, string extractPath);
    }
}
