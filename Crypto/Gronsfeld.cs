using System;
using System.Linq;
using System.Text;

namespace Crypto
{
    // класс обратимого шифрования
    public class Gronsfeld
    {
        /// <summary> Ключ </summary>
        public string Key = "12345";

        /// <summary> Зашифровать текст </summary>
        public string Crypt(string text)
        {
            string result = null;
            for (int i = 0; i < text.Length; i++)
                result += (char)(text[i] + (Key[i % Key.Length] - '0'));
            return result;
        }

        /// <summary> расшифровать текст </summary>
        public string Decrypt(string text)
        /// <summary> Зашифровать текст </summary>
        {
            string result = null;
            for (int i = 0; i < text.Length; i++)
                result += (char)(text[i] - (Key[i % Key.Length] - '0'));
            return result;
        }
    }
}
