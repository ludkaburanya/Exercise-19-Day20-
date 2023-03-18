namespace z4
{
    /// <summary>
    /// класс для работы с текстом в файле "z4.txt". Сохранение измененй в файлах "z4.txt" и "z44.txt"
    /// </summary>
    class Program
    {
        /// <summary>
        /// добавить в фалй текст.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///<summary>
            ///создание массива знаков.
            /// </summary>
            char[] text;
            ///<summary>
            ///создание класса StreamReader для считывания строк из текстового файла "z4.txt".
            /// </summary>
            using (StreamReader sr = new StreamReader(@"C:\z3\z4.txt"))
            {
                ///<summary>
                ///ReadToEnd() считывает все символы, начиная с текущей позиции до конца потока.
                ///ToCharArray() извлекает символы из строки в массив символов.
                /// </summary>
                text = sr.ReadToEnd().ToCharArray();
            }
            ///<summary>
            ///объявление цикла for.
            /// создание счетчика для работы со строками.
            /// </summary>
            for (int i = 0; i < text.Length; i++)
            {
                ///<summary>
                ///замена символа 0 на 1.
                /// </summary>
                if (text[i] == '0')
                    text[i] = '1';
                ///<summary>
                ///в ином случае замена символа 1 на 0.
                /// </summary>
                else
                {
                    if (text[i] == '1')
                        text[i] = '0';
                }
            }
            ///<summary>
            ///использование класс StreamWriter для записи итогового результата в новый текстовый файл "z44.txt".
            /// </summary>
            using (StreamWriter sw = new StreamWriter(@"C:\z3\z44.txt"))
            {
                foreach (char c in text)
                    sw.Write(c);
            }
        }
    }
}