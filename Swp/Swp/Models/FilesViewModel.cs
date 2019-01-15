using System;
using System.Collections.Generic;

namespace Swp.Models
{
    public class FileDetails
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Path { get; set; }
        public string format { get; set; }
    }

    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();
    }
}