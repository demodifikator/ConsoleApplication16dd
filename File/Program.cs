using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Desktop\My File.txt";

            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo.Length);

            Console.WriteLine("Please enter the string");
            string text = Console.ReadLine();

            //using (FileStream fileStream = new FileStream(path, FileMode.Append))
            //{
            //    byte[] byteArr = System.Text.Encoding.Default.GetBytes(text);
            //    fileStream.Write(byteArr, 0, byteArr.Length);
            //    Console.WriteLine("Text was wrote to the file");
            //}

            using (StreamWriter sWriter = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 20; i++)
                {
                    sWriter.WriteLine(i);
                }
            }

            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    list.Add(line);
            }
            Console.WriteLine();
        }
    }
}
