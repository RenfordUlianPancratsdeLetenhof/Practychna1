using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practychna1.pract4
{
    internal class FileWriter : IWrite
    {
        public void Write(string path, IntArray array)
        {
            try
            {
                // Використовуємо StreamWriter для запису у файл
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    // Записуємо значення count у файл
                    writer.WriteLine(array.count);
                }

                Console.WriteLine("Значення count успішно записано у файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при записі у файл: " + ex.Message);
            }
        }
    }
}
