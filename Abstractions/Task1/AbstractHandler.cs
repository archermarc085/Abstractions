using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   abstract class AbstractHandler
    { 
        virtual protected string FileName { get; set; }
        protected FileInfo file = null;
        public void Open() 
        {
            Console.WriteLine("File: {0} opened", FileName);
            Process.Start(FileName);
        }
        virtual public void Create()
        {
            file = new FileInfo(FileName);
            Save();
            Console.WriteLine("Location: {0}", file.FullName);
            Console.WriteLine("Creation Time: {0}", file.CreationTime);
            Console.WriteLine();
        }
        virtual public void Change() { Console.WriteLine("File: {0} changed", FileName); }
        protected void Save() { Console.WriteLine("File: {0} saved", FileName); }
    }
}
