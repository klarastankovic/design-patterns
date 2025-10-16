using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.RandomGenerator
{
    public class Logger
    {
        private static Logger instance;
        private string filePath;
        private Logger()
        {
            filePath = "file.txt";
        }
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public void Log(string message)
        {
            File.AppendAllText(filePath, message);
        }
    }
}
