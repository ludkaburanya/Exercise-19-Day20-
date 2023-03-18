using System;
using System.Collections.Generic;
using System.IO;

namespace z3
{
    /// <summary>
    /// класс для работы с тектом и сохранения его в файлы "textic.txt" и "reversed.txt".
    /// </summary>
    class Program
    {
        /// <summary>
        /// добавить в файл текст.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// <summaru>
            /// создание списка строк для хранения содержимого файла.
            /// </summaru>
            List<string> lines = new List<string>();

            ///<summary>
            ///запись 5 строк различной длмнны в файл с помощью метода StreamWriter().
            /// </summary>

            using (StreamWriter sw = new StreamWriter(@"C:\z33\textic.txt"))
            {
                sw.WriteLine("Модификации");
                sw.WriteLine("Один два три два один три десять");
                sw.WriteLine("Исчезновение кого-то странного");
                sw.WriteLine("А это Люда");
                sw.WriteLine("Люда");
            }
            /// <summary>
            /// чтение всех строк из файла в список строк с помощью метода StreamReader().
            /// </summary>
            using (StreamReader sr = new StreamReader(@"C:\z33\textic.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            /// <summary>
            /// вывод всего файла на экран.
            /// </summary>
            Console.WriteLine("Содержимое файла:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(new string('-', 50));
            ///<summary>
            ///подсчитывание количества строк.
            /// </summary>
            int numLines = lines.Count;
            Console.WriteLine("Количество строк: {0}", numLines);
            Console.WriteLine(new string('-', 50));

            ///<summary>
            ///подсчитывание количества символов в каждой строке при помощи цикла foreach.
            /// </summary>
            Console.WriteLine("Количество символов в каждой строке:");
            foreach (string line in lines)
            {
                Console.WriteLine("{0}: {1}", line, line.Length);
            }

            ///<summary>
            ///удаление последней строкм из файла.
            /// </summary>
            string lastLine = lines[numLines - 1];
            lines.RemoveAt(numLines - 1);
            using (StreamWriter sw = new StreamWriter(@"C:\z33\textic.txt"))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Удаленная строка: {0}", lastLine);
            Console.WriteLine(new string('-', 50));

            ///<summary>
            ///присваивание s1 и s2 строки, которые нужно вывести на экран.
            /// </summary>
            int s1 = 1;
            int s2 = 3;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Строки с {0} по {1}:", s1, s2);
            ///<summary>
            ///объявление цикла for
            /// /// создание счетчика для работы со строками.
            /// </summary>
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }

            ///<summary>
            ///при помощи цикла foreach находится длинна самой длинной строки.
            /// </summary>
            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Самая длинная строка имеет длину {0} символов.", maxLength);
            Console.WriteLine(new string('-', 50));

            ///<summary>
            ///поиск первого символ "М" в строках.
            /// </summary>
            char startingChar = 'М';
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Строки, начинающиеся с буквы '{0}':", startingChar);

            foreach (string line in lines)
            {
                if (line.StartsWith(startingChar.ToString()))
                {
                    Console.WriteLine(line);
                }
            }

            ///<summary>
            ///переписывание строк в файл "reversed.txt"
            ///изменение порядка строк в новом файле при помощи метода Reverse().
            /// </summary>
            lines.Reverse();
            using (StreamWriter sw = new StreamWriter(@"C:\z33\reversed.txt"))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("\nСтроки переписаны в обратном порядке в файл 'reversed.txt'.");
        }
    }
}