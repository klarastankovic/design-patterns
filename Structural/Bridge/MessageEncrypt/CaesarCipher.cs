using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageEncrypt
{
    public class CaesarCipher : IEncryption
    {
        private static int Letters = 26;
        private int Shift {  get; set; }
        public CaesarCipher(int rotation)
        {
            if (rotation > Letters || rotation < 0)
            {
                throw new ArgumentException();
            }
            this.Shift = rotation;
        }
        public String Encrypt(String input)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char character in input)
            {
                builder.Append(this.Rotate(character));
            }
            return builder.ToString();
        }
        public char Rotate(char character)
        {
            if (char.IsLetter(character) == false)
            {
                return character;
            }
            int alphabetStart = Char.IsUpper(character) ? 'A' : 'a';
            int indexInAlphabet = character - alphabetStart;
            indexInAlphabet = (indexInAlphabet + this.Shift) % Letters;
            char shifted = (char) (indexInAlphabet + alphabetStart);
            return shifted;
        }
    }
}
