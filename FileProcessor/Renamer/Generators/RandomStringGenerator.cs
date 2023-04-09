using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer.Generators
{
    internal class RandomStringGenerator : IStringGenerator
    {
        public string GetNext()
        {
            Random r = new Random();
            int length = 7;
            string s = string.Empty;

            for (int i = 0; i < length; i++)
                s += Convert.ToChar(r.Next(97, 122));

            return s;
        }
    }
}
