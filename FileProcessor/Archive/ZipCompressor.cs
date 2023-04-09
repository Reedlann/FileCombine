using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace FileProcessor.Archive
{
    internal class ZipCompressor : ICompressor
    {
        public void Compress(string path, string destination)
        {
            ZipFile.CreateFromDirectory(path, destination);
        }

        public void Decompress(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
