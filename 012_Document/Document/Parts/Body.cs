using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Document//.Document.Parts
{
    class Body
    {
        string content;
        public string Content
        {
            private get
            {
                if(content != null)
                {
                    return content;
                }
                else
                {
                    return "Body of documment is missing!";
                }
            }
            set { content = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
    }
}
