namespace z1
{
    /// <summary>
    /// класс для работы с тектом в файле "txt". Сохранение изменений в файле "txt".
    /// </summary>
    class Program
    {
        /// <summary>
        /// добавить в файл символы.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// <summary>
            /// создание массива с пятью целыми числами.
            /// создание рандомайзера чисел от -10 до 10.
            /// ///объявление цикла for.
            /// </summary>
            int[] mass = new int[5];
            int GetNegativNumber = 0;
            ///<summary>
            /// запись символов в файл "txt" при помощи класса StreamWriter().
            /// </summary>
            Random random = new Random();
            ///<summary>
            /// чтение файла "txt" при помощи класса StreamReader().
            /// </summary>
            using (StreamWriter sw = new StreamWriter(@"C:\laba\.txt"))
                ///<summary>
                ///объявление цикла for.
                /// создание счетчика для работы со строками.
                /// метод Parse принимает строку и возвращает объект текущего типа.
                /// </summary>
                for (int i = 0; i < mass.Length; i++)
                    sw.WriteLine(random.Next(-10, 10));
            using (StreamReader sr = new StreamReader(@"C:\laba\.txt")) 
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = int.Parse(sr.ReadLine());
                }
            }
            ///<summary>
            ///нахождение минимально, максимально и отрицательного элемента массива  через цикл for.
            /// </summary>
            int max = mass.Max();
            int min = mass.Min();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= 0)
                {
                    GetNegativNumber++;
                }
            }
            Console.WriteLine("Максимум:{0}\nМинимум:{1}\nКоличество отрицательных цифр:{2}", max, min, GetNegativNumber);

        }
    }
}