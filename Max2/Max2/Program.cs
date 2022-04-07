using System;
using System.IO;
using System.Collections.Generic;

namespace Max2
{
    class Program
    {
        static List<string> Read_from_file(string file_path)
        {
            try
            {
                List<string> list = new List<string>();
                using (StreamReader sr = new StreamReader(file_path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        static async void Write_to_file(string text, string file_path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(file_path, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(text);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {
            List<string> list = Read_from_file(@"C:\Users\Danil\source\repos\Max2\in.txt");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
