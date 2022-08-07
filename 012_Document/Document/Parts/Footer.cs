using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Document//.Document.Parts
{
    class Footer
    {
        string content;
        public string Content
        {
            private get
            {
                if (content != null)
                {
                    return content;
                }
                else
                {
                    return "Footer of documment is missing!";
                }
            }
            set { content = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
