using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    // Bad example
    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            string loadTextVar = "Load text";
            Console.WriteLine(loadTextVar);

            return loadTextVar;
        }
        public string SaveText()
        {
            string saveTextVar = "Save text";
            Console.WriteLine(saveTextVar);

            return saveTextVar;
        }
    }

    // Good example
    //public class SqlFile : IWritableSqlFile, IReadableSqlFile
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public string LoadText()
    //    {
    //        string loadTextVar = "Load text";
    //        Console.WriteLine(loadTextVar);

    //        return loadTextVar;
    //    }
    //    public void SaveText()
    //    {
    //        string saveTextVar = "Save text";
    //        Console.WriteLine(saveTextVar);
    //    }
    //}
}
