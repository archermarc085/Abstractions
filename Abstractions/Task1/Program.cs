using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Task1
{
    enum Format { DOC, XML, TXT }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler = null;
            Format format = Format.DOC;

            switch (format)
            {
                case Format.DOC:
                    handler = new DOCHandller();
                    break;
                case Format.TXT:
                    handler = new TXTHandller();
                    break;
                case Format.XML:
                    handler = new XMLHandller();
                    break;
            }

            handler.Create();
            handler.Change();
            handler.Open();

            Console.ReadLine();
        }
    }
}
