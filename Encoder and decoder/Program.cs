using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder_and_decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string encoder = "";
            string text = Console.ReadLine();
            text = text.ToUpper();
            char[] letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', ',', '.', '!', '?', ':', ';', '-','1','2','3','4','5','6','7','8','9','0' };
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (text[i]==letters[j])
                    {
                        encoder = encoder + (j + 10).ToString();
                    }
                }
            }
            Console.WriteLine(encoder);

            string decoder = "";
            for (int i = 0; i < encoder.Length; i+=2)
            {
                string bukva = encoder[i].ToString() + encoder[i+1].ToString();
                decoder += letters[int.Parse(bukva) - 10];
            }
            Console.WriteLine(decoder);
        }
    }
}
