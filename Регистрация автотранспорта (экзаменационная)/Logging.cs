using System;
using System.IO;
using System.Text;

namespace Registration_autotransport
{
    public class Logging //Метод логирования
    {
        public string Text { get; set; }
        private static readonly string d = DateTime.Now.ToShortDateString(); //преобразованная дата в строку
        private static readonly string writePath = $"Log {d}.txt"; //имя файла

        //Метод создания пустого лога. Вызывается при открытии главной формы программы.
        public static void WriteInFile()
        {
            try
            {
                using FileStream sw = new(writePath, FileMode.OpenOrCreate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //метод дозаписи в существующий лог. Периодически вызывается в разных методах. Метод проверяет, есть лог с таким именем
        //если есть, дозаписываем, если нет, создаем новый и записываем.
        public static void OverWriteInFile(string text)
        {         
            try
            {
                string path = writePath;
                bool exist = File.Exists(path);
                if (exist == true)
                {
                    using FileStream sw = new(path, FileMode.Append);
                    using StreamWriter wr = new(sw);
                    wr.WriteLine(text);
                }
                else
                {
                    using FileStream sw = new(path, FileMode.OpenOrCreate);
                    using StreamWriter wr = new(sw);
                    wr.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
