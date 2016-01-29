using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TXTHandller:AbstractHandler
    {
        override protected string FileName { get { return "information.txt"; } }
        public override void Create()
        {
            if (File.Exists(FileName))
            {
                Console.WriteLine("File is already exist!");
            }
            else
            {
                Console.WriteLine("Create new TXT File");
                file = new FileInfo(FileName);
                FileStream fstream = file.Create();
                fstream.Close();
                base.Create();
            }
        }
        public override void Change()
        {
            base.Change();
            FileInfo information = new FileInfo(FileName);
            StreamWriter writer = information.CreateText();
            writer.WriteLine("Infromation");
            writer.WriteLine("C# language");
            writer.WriteLine("Microsoft");
            writer.WriteLine();
            writer.WriteLine(DateTime.Now);
            writer.Close();
            Save();
        }
    }
}
