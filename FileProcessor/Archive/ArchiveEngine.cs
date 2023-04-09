using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileProcessor.Archive.Exceptions;

namespace FileProcessor.Archive
{
    public class ArchiveEngine
    {
        private ICompressor? Compressor { get; set; }

        private void SetCompressor(ArchiveEngineMode mode)
        {
            Compressor = mode switch
            {
                ArchiveEngineMode.Zip => new ZipCompressor(),

                _ => new ZipCompressor()
            };
        }

        public ArchiveEngine(ArchiveEngineMode mode = ArchiveEngineMode.Zip) 
        {
            SetCompressor(mode);
        }
        public void SetMode(ArchiveEngineMode mode)
        {
            SetCompressor(mode);
        }
        public string CompressDirectory(string path, string destinationPath = "")
        {
            if (!Directory.Exists(path))
                throw new Exceptions.DirectoryNotFoundException($"Directory {path} not found");

            if (destinationPath == string.Empty)
            {

            }

            if (Directory.Exists(destinationPath))
                throw new FileAlreadyExistsException($"File {destinationPath} already exists");



            //Compressor.Compress(path, )

            return string.Empty; // TODO
        }
    }
}
