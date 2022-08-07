using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//скрыли инициалитзацию 3-х классов
namespace _013_Document
{
    class Document
    {
        Title title = null;
        Body body = null;
        Footer footer = null;

        void InitializeDocument()//объявление метода инициализации
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }
        public Document(string title)
        {
            InitializeDocument();//вызов метода инициализации и фактически создание содержимогог объекта
            this.title.Content = title;//передача заголовка объекту
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

        public string Body
        {
            set { this.body.Content = value; }
        }
        public string Footer
        {
            set { this.footer.Content = value; }
        }
    }
}
