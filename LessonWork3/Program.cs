using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            var word = Console.ReadLine();
            var reverced = new StringBuilder();
            for (var i = word.Length - 1; i >= 0; i--)
                reverced.Append(word[i]);

            Console.WriteLine(reverced);
            Console.ReadLine();
        }
    }
}
