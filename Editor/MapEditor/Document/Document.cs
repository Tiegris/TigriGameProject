using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    public class Document
    {
        public Scenario Scenario { get; set; }
        public string FileName { get; set; }
        public System.IO.DirectoryInfo FilePath { get; set; }
    }
}
