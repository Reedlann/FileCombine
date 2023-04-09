using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileProcessor.Renamer.Generators;

namespace FileProcessor.Renamer
{
    public class Renamer
    {
        private IStringGenerator generator = new UuidGenerator();
        public List<FileInfo> Files { get; set; } = new List<FileInfo>();

        public int AIStartValue { get; set; } = 0;
        public int AIStep { get; set; } = 1;

        public Renamer()
        { }

        public Renamer(List<FileInfo> files, RenamerMode mode)
        {
            Files = files;

            SetMode(mode);
        }

        public void SetMode(RenamerMode mode)
        {
            generator = mode switch
            {
                RenamerMode.UUID => new UuidGenerator(),
                RenamerMode.AUTOINCREMENT => new AutoincrementGenerator(AIStartValue, AIStep),
                RenamerMode.RANDOM_STRING => new RandomStringGenerator(),
                _ => throw new InvalidOperationException(),
            };
        }

        public Report Rename(string prefix)
        {
            Report report = new Report();

            Files.ForEach(f =>
            {
                try
                {
                    string ext = f.Extension;

                    string randomChunk = generator.GetNext();

                    string newTitle = $"{prefix}{randomChunk}{ext}";

                    string path = Path.Combine(f.Directory.FullName, newTitle);

                    f.MoveTo(path);

                    report.PushSuccess(f);
                }
                catch (Exception ex)
                {
                    report.PushError(f, ex);
                }
            });

            return report;
        }
    }
}
