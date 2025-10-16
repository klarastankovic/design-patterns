using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Logger
{
    public class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType type, string filePath) : base(type)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            System.IO.StreamWriter writer = 
                new System.IO.StreamWriter(filePath, true);
            writer.WriteLine(type + ": " + DateTime.Now);
            writer.WriteLine(new string('=', message.Length));
            writer.WriteLine(message);
            writer.WriteLine(new string('=', message.Length) + "\n");
            writer.Close();
        }
    }
}
