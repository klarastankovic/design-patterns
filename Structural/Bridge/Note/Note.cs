using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public abstract class Note // apstrakcija
    {
        private string message;
        private ITheme theme; // referenca na implementaciju
        public Note (string message, ITheme theme)
        {
            this.message = message;
            this.theme = theme;
        }
        public string Message { get { return message; } }
        public ITheme Theme { set { this.theme = value; } }
        protected void ChangeColor()
        {
            this.theme.SetBackgroundColor();
            this.theme.SetFontColor();
        }
        protected string GetFramedMessage()
        {
            int width = this.message.Length;
            return this.theme.GetHeader(width) + "\n" +
                this.message + "\n" + this.theme.GetFooter(width);
        }
        public abstract void Show();
    }
}
