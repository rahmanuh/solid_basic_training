using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    public class ReadOnlySqlFile : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            string loadTextVar = "Read only files can only load text";
            Console.WriteLine(loadTextVar);

            return loadTextVar;
        }
    }
}
