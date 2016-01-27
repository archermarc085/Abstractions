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
    class XMLHandller:AbstractHandler
    {
        override protected string FileName { get { return "output.xml"; } }

        public override void Open()
        {
            Console.WriteLine("File: {0} opened", FileName);
            Process.Start("explorer.exe", FileName);
        }
        public override void Create()
        {
            if (File.Exists(FileName))
            {
                Console.WriteLine("File is already exist!");
            }
            else
            {
                Console.WriteLine("Create new XML File");
                XmlTextWriter writer = new XmlTextWriter(FileName, System.Text.Encoding.UTF8);
                writer.Close();
                base.Create();
            }
        }
        public override void Change()
        {
            base.Change();
            XmlTextWriter writer = new XmlTextWriter(FileName, null);
            writer.WriteStartElement("game");
            writer.WriteElementString("price", "20");
            writer.WriteEndElement();
            writer.Close();
            Save();
        }
    }
}
