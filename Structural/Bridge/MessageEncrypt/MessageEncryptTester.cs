using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public static class MessageEncryptTester
    {
        public static void Test()
        {
            IEncryption algorithm = new CaesarCipher(3);
            String text = "The enemy is here.";
            String target = "Commander";
            String author = "Mata Hari";
            Message mataHariMessage = new SpyMessage(author, text, target);
            Console.WriteLine(mataHariMessage.Encrypt());
            mataHariMessage.Encryption = algorithm;
            Console.WriteLine(mataHariMessage.Encrypt());

            UserMessage userMessage = new UserMessage(author, text);
            userMessage.AddComment("#Awesome!");
            Console.WriteLine(userMessage.Encrypt());
            userMessage.Encryption = algorithm;
            Console.WriteLine(userMessage.Encrypt());
        }
    }
}
