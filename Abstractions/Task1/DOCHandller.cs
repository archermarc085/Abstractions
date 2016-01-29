using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DOCHandller:AbstractHandler
    {
        override protected string FileName { get { return "file.docx"; } }
        public override void Create()
        {
            if (File.Exists(FileName))
            {
                Console.WriteLine("File is already exist!");
            }
            else
            {
                Console.WriteLine("Create new Docx File");
                var document = DocX.Create(FileName);
                document.Save();
                base.Create();
            }
        }
        public override void Change()
        {
            base.Change();
            var doc = DocX.Load(FileName);
            string headlineText = "5 фундаментальных правил успеха разработчика ";
            StringBuilder paraOne = new StringBuilder();
            paraOne.AppendLine("1. Не изобретайте колесо");
            paraOne.AppendLine("2. Не тратьте время на код, сосредоточьтесь на скорейшем завершении проекта");
            paraOne.AppendLine("3. Обеспечьте техническую поддержку кода ");
            paraOne.AppendLine("4. Пользуйтесь правом возврата денег при отсутствии ТП");
            paraOne.AppendLine("5. Проверяйте коды и модули на наличие угроз и уязвимостей");

            var headLineFormat = new Novacode.Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Times New Roman");
            headLineFormat.Size = 18D;
            headLineFormat.Position = 12;

            var paraFormat = new Novacode.Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Courier New");
            paraFormat.Size = 10D;

            doc.InsertParagraph("paragraph 1");
            doc.InsertParagraph(headlineText, false, headLineFormat);
            doc.InsertParagraph(paraOne.ToString(), false, paraFormat);
            doc.Save();
            Save();
        }
    }
}
