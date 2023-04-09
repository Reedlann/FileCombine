using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renamer
{
    public class Report
    {
        public List<ReportItem> items { get; set; } = new List<ReportItem>();

        public void PushSuccess(FileInfo processedFile)
        {
            items.Add(new ReportItem(processedFile));
        }

        public void PushError(FileInfo processedFile, Exception? ex)
        {
            items.Add(new ReportItem(processedFile, true, ex));
        }
    }
}
