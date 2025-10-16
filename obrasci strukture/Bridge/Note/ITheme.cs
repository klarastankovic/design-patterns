using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public interface ITheme // implementator
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);
    }
}
