using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Archive.Exceptions
{
    public class ArchiverException : Exception
    {
        public ArchiverException(string? message, Exception? innerException = null) :
            base(message, innerException)
        { }
    }
}
