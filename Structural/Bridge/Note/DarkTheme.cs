﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public string GetHeader(int width)
        {
            return new string('/', width);
        }
        public string GetFooter(int width)
        {
            return new string('\\', width);
        }
    }
}
