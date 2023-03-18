namespace z2
{
    /// <summary>
    /// класс для создания папки "New_folder".
    /// </summary>
    class Program
    {
        /// <summary>
        /// создание папки на диске С.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///<summary>
            ///с помощью статического метода CreateDirectory() класса Directory создается папка.
            ///в самом методе указывается путь, где будет распологаться будущая папка "New_folder".
            /// </summary>
            Directory.CreateDirectory("C:\\laba\\New_folder");
        }
    }
}