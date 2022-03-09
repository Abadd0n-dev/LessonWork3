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
            var name = new string[5, 2]{{"Руслан", "+7 985 171 34 83"},{"Федор", "+7 915 343 55 61"},
                {"Александр", "sasha@mail.ru"},{"Алина", "alina@gmail.ru"},{"Андрей", "andrei@list.ru"}};
            for (var i = 0; i < name.GetLength(0); i++)
            {
                for (var j = 0; j < name.GetLength(1); j++)
                    Console.Write(name[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
